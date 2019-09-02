using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_14f2-9f567028")]
        public void Method_1008_14f2()
        {
            ii(0x1008_14f2, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_14f7, 5); call(Definitions.sys_check_available_stack_size, 0xe_4856); /* call 0x10165d52 */
            ii(0x1008_14fc, 1); push(ebx);                              /* push ebx */
            ii(0x1008_14fd, 1); push(ecx);                              /* push ecx */
            ii(0x1008_14fe, 1); push(esi);                              /* push esi */
            ii(0x1008_14ff, 1); push(edi);                              /* push edi */
            ii(0x1008_1500, 1); push(ebp);                              /* push ebp */
            ii(0x1008_1501, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_1503, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_1509, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_150c, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_150f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_1512, 5); call(0x1007_623c, -0xb2db);             /* call 0x1007623c */
            ii(0x1008_1517, 4); cmp(memb[ds, eax + 22], 0);             /* cmp byte [eax+0x16], 0x0 */
            ii(0x1008_151b, 2); if(jz(0x1008_152c, 0xf)) goto l_0x1008_152c; /* jz 0x1008152c */
            ii(0x1008_151d, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x1008_1522, 5); call(0x1007_5fdc, -0xb54b);             /* call 0x10075fdc */
            ii(0x1008_1527, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x1008_152a, 2); if(jge(0x1008_152e, 2)) goto l_0x1008_152e; /* jge 0x1008152e */
        l_0x1008_152c:
            ii(0x1008_152c, 2); jmp(0x1008_1549, 0x1b); goto l_0x1008_1549; /* jmp 0x10081549 */
        l_0x1008_152e:
            ii(0x1008_152e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_1531, 3); mov(al, memb[ds, eax + 80]);            /* mov al, [eax+0x50] */
            ii(0x1008_1534, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_1539, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_153b, 2); if(jnz(0x1008_1543, 6)) goto l_0x1008_1543; /* jnz 0x10081543 */
            ii(0x1008_153d, 4); mov(memb[ss, ebp - 12], 3);             /* mov byte [ebp-0xc], 0x3 */
            ii(0x1008_1541, 2); jmp(0x1008_156a, 0x27); goto l_0x1008_156a; /* jmp 0x1008156a */
        l_0x1008_1543:
            ii(0x1008_1543, 4); mov(memb[ss, ebp - 12], 1);             /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_1547, 2); jmp(0x1008_156a, 0x21); goto l_0x1008_156a; /* jmp 0x1008156a */
        l_0x1008_1549:
            ii(0x1008_1549, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_154c, 4); cmp(memb[ds, eax + 84], 0);             /* cmp byte [eax+0x54], 0x0 */
            ii(0x1008_1550, 2); if(jnz(0x1008_1560, 0xe)) goto l_0x1008_1560; /* jnz 0x10081560 */
            ii(0x1008_1552, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_1555, 3); mov(eax, memd[ds, eax + 18]);           /* mov eax, [eax+0x12] */
            ii(0x1008_1558, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1008_155b, 3); cmp(eax, 6);                            /* cmp eax, 0x6 */
            ii(0x1008_155e, 2); if(jl(0x1008_1566, 6)) goto l_0x1008_1566; /* jl 0x10081566 */
        l_0x1008_1560:
            ii(0x1008_1560, 4); mov(memb[ss, ebp - 12], 2);             /* mov byte [ebp-0xc], 0x2 */
            ii(0x1008_1564, 2); jmp(0x1008_156a, 4); goto l_0x1008_156a; /* jmp 0x1008156a */
        l_0x1008_1566:
            ii(0x1008_1566, 4); mov(memb[ss, ebp - 12], 3);             /* mov byte [ebp-0xc], 0x3 */
        l_0x1008_156a:
            ii(0x1008_156a, 3); mov(al, memb[ss, ebp - 12]);            /* mov al, [ebp-0xc] */
            ii(0x1008_156d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_156f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_1570, 1); pop(edi);                               /* pop edi */
            ii(0x1008_1571, 1); pop(esi);                               /* pop esi */
            ii(0x1008_1572, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_1573, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_1574, 1); ret();                                  /* ret */
        }
    }
}
