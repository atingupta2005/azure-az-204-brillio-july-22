 - When you send events to Event Hubs, the default approach is for the messages to be distributed among partitions in a round-robin fashion. However, if a partition key is provided, this value can be used to influence the selection of the actual partition instead. The partition key is a string, and any events sent to Event Hubs that share the same partition key value (or more precisely, whose hash of the partition key is the same) are delivered in order to the same partition.

- The messages arrive at the EventProcessor in batches. It is preferable to set Checkpoint after processing each batch.

- Checkpointing can be in various patterns, like the end of batch processing or at regular intervals.

- A checkpoint is a location, or offset, for a given partition, within a given consumer group, at which point you are satisfied that you have processed the messages.

- Each partition should have only one active reader at a time.

- The logical group of consumers that receive messages from each Event Hub partition is called a consumer group. The intention of a consumer group is to represent a single downstream processing application, where that application consists of multiple parallel processes, each consuming and processing messages from a partition. All consumers must belong to a consumer group. The consumer group also acts to limit concurrent access to a given partition by multiple consumers, which is desired for most applications, because two consumers could mean data is being redundantly processed by downstream components and could have unintended consequences.

- In the situation where multiple processes need to consume events from a partition, there are two options. First, consider if the parallel processing required should belong in a new consumer group. Event Hubs has a soft limit that allows you to create up to 20 consumer groups. Second, if the parallel processing makes sense within the context of a single consumer group, then note that Event Hubs will allow up to five such processes within the same consumer group to process events concurrently from a single partition.


- The consumer (also referred to as the receiver) of the Event Hub draws events from a single partition within an Event Hub. Therefore, an Event Hub with four partitions will have four consumers—one assigned to consume from each partition

- The logical group of consumers that receive messages from each Event Hub partition is called a consumer group.

- The intention of a consumer group is to represent a single downstream processing application, where that application consists of multiple paral lel processes, each consuming and processing messages from a partition. All consumers must belong to a consumer group.

- On the event consumer side, Event Hubs works differently from traditional queues. In the traditional queue, you typically see a pattern called competing consumers. It is so named because each consumer targeting a queue is effectively competing against all other consumers targeting the same queue for the next message: the first consumer to get the message wins, and the other consumers will not get that message

- By contrast, you can look at Event Hubs (or more precisely, the partitions within an Event Hubs instance) as following a multiconsumer (or broadcast) pattern where every consumer can receive every message

- The critical difference between the two dequeuing patterns amounts to state management. In competing consumers, the queue system itself keeps track of the delivery state of every message. In Event Hubs, no such state is tracked, so managing the state of progress through the queue becomes the responsibility of the individual consumer.

- So what is this state that the consumers manage? It boils down to byte offsets and message sequence numbers in a process called checkpointing.

- An important side effect of outsourcing this state management to the consumer is that messages are no longer deleted from the queue when processed (as in the competing consumers pattern). Instead, Event Hubs queues have a retention period of 1 to 7 day

- Consumer groups manage one final value, which has to do with the versioning of the consumer application: the epoch. For a given partition, the epoch represents the numeric “version” or “phase” of the consumer and can be used to ensure that only the latest is allowed to pull events. When a higher-valued epoch receiver is launched, the lower-valued one is disconnected

- It is possible to create a receiver without an epoch, in which case the epochs are not enforced, but it is here that you are limited to five concurrent consumers per partition/consumer group combination. The epoch value is typically supplied when the consumer is created (at the same time where it might indicate an offset).
