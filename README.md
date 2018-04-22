# JobApplicationRelated

Simple job application exercise.

Assumptions and design decisions: 
* Only one discount is valid at the moment of the transaction.
* The system does not automatically select the best rental choice according to the duration of the rent, instead it is selected earlier, at least on this layer. 
* Strategy pattern used for Rentals.
* Different kind of discounts, like a coupon code should be easy to implement as well.
* For simplicity, discount is manually set on the transaction, another approach could be to have a DiscountManager that receives a Transaction and based on information there (e.g. discount on the mornings or every thursday), set the discount that fits the transaction.   

Tests can be run through visual studio from the corresponding project.
