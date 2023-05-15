graph = {}

graph["start"] = {}

graph["start"]["a"] = 6
graph["start"]["b"] = 2

graph["a"] = {}
graph["a"]["fin"] = 1
graph["b"] = {}
graph["b"]["a"] = 3
graph["b"]["fin"] = 5
graph["fin"] = {}

infinity = 9999999

costs = {}
costs["a"] = 6
costs["b"] = 2
costs["fin"] = float('inf')

parents = {}
parents["a"] = "start"
parents["b"] = "start"
parents["fin"] = None

processed = []


def find_lowest_cost_node(costs_p):
    minValue = 999999
    minName = None

    for cost_p in costs_p.keys():
        isProcessed = False

        if costs_p[cost_p] < minValue:

            for proc in processed:
                if proc == cost_p:
                    isProcessed = True

            if(isProcessed == False):
                minValue = costs_p[cost_p]
                minName = cost_p

    return minName


node = find_lowest_cost_node(costs)
while node is not None:

    cost = costs[node]
    neighbors = graph[node]

    for n in neighbors.keys():
        new_cost = cost + neighbors[n]
        if costs[n] > new_cost:
            costs[n] = new_cost
            parents[n] = node
    processed.append(node)
    node = find_lowest_cost_node(costs)

