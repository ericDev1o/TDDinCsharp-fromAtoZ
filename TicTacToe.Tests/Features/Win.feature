Feature: Win the TicTacToe game
@newtest
Scenario: PlayVerticalZeroesLine
    Given an empty board
    When I play zeroes on first column
    Then I should win the game
Scenario: PlayHorizontalCrossesLine
    Given an empty board
    When I play crosses on first line
    Then I should win the game
Scenario: PlayDiagonalZeroesLine
    Given an empty board
    When I play zeroes on backslash diagonal
    Then I should win the game