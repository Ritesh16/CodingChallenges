SELECT
    id,
    CASE
        WHEN t.id = (SELECT atree.id FROM tree atree WHERE atree.p_id IS NULL)
          THEN 'Root'
        WHEN t.id IN (SELECT atree.p_id FROM tree atree)
          THEN 'Inner'
        ELSE 'Leaf'
    END AS Type
FROM
    tree t
ORDER BY Id