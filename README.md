# JobApplicationRelated

Simple job exercise application.

Assumptions and design decisions: 
* Only one discount is valid at the moment of the transaction.
* The system does not automatically select the best rental choice according to the duration of the rent, instead it is selected earlier, at least on this layer. 
* Strategy pattern used for Rentals.
* Different kind of discounts, like a coupon code should be easy to implement as well.

Tests can be run through visual studio from the corresponding project.
