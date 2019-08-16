using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f9df205c-e82d-4286-8bf6-57203820c6c5")]
        public void Method_1013_13bf()
        {
            ii(0x1013_13bf, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1013_13c4, 5); calld(Definitions.sys_check_available_stack_size, 0x3_4989); /* call 0x10165d52 */
            ii(0x1013_13c9, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_13ca, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_13cb, 1); pushd(esi);                             /* push esi */
            ii(0x1013_13cc, 1); pushd(edi);                             /* push edi */
            ii(0x1013_13cd, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_13ce, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_13d0, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1013_13d6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_13d9, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_13dc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_13df, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_13e2, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_13e5, 3); mov(al, memb_a32[ds, eax + 0x17]);      /* mov al, [eax+0x17] */
            ii(0x1013_13e8, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1013_13eb, 5); jmpd(0x1013_148e, 0x9e); goto l_0x1013_148e; /* jmp 0x1013148e */
        l_0x1013_13f0:
            ii(0x1013_13f0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_13f3, 4); mov(dx, memw_a32[ds, eax + 0x3a]);      /* mov dx, [eax+0x3a] */
            ii(0x1013_13f7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_13fa, 4); sub(memw_a32[ds, eax + 0x30], dx);      /* sub [eax+0x30], dx */
            ii(0x1013_13fe, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_1401, 3); mov(eax, memd_a32[ds, eax + 0x2e]);     /* mov eax, [eax+0x2e] */
            ii(0x1013_1404, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_1407, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_1409, 2); if(jged(0x1013_1414, 0x9)) goto l_0x1013_1414; /* jge 0x10131414 */
            ii(0x1013_140b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_140e, 6); mov(memw_a32[ds, eax + 0x30], 0);       /* mov word [eax+0x30], 0x0 */
        l_0x1013_1414:
            ii(0x1013_1414, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_1419, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_141c, 5); calld(0x1013_0c16, -0x80b);             /* call 0x10130c16 */
            ii(0x1013_1421, 5); jmpd(0x1013_14b4, 0x8e); goto l_0x1013_14b4; /* jmp 0x101314b4 */
        l_0x1013_1426:
            ii(0x1013_1426, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_1429, 4); mov(dx, memw_a32[ds, eax + 0x3c]);      /* mov dx, [eax+0x3c] */
            ii(0x1013_142d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_1430, 4); sub(memw_a32[ds, eax + 0x32], dx);      /* sub [eax+0x32], dx */
            ii(0x1013_1434, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_1437, 3); mov(eax, memd_a32[ds, eax + 0x30]);     /* mov eax, [eax+0x30] */
            ii(0x1013_143a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_143d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_143f, 2); if(jged(0x1013_144a, 0x9)) goto l_0x1013_144a; /* jge 0x1013144a */
            ii(0x1013_1441, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_1444, 6); mov(memw_a32[ds, eax + 0x32], 0);       /* mov word [eax+0x32], 0x0 */
        l_0x1013_144a:
            ii(0x1013_144a, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_144f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_1452, 5); calld(0x1013_0c16, -0x841);             /* call 0x10130c16 */
            ii(0x1013_1457, 2); jmpd(0x1013_14b4, 0x5b); goto l_0x1013_14b4; /* jmp 0x101314b4 */
        l_0x1013_1459:
            ii(0x1013_1459, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_145c, 4); mov(dx, memw_a32[ds, eax + 0x3e]);      /* mov dx, [eax+0x3e] */
            ii(0x1013_1460, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_1463, 4); sub(memw_a32[ds, eax + 0x34], dx);      /* sub [eax+0x34], dx */
            ii(0x1013_1467, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_146a, 3); mov(eax, memd_a32[ds, eax + 0x32]);     /* mov eax, [eax+0x32] */
            ii(0x1013_146d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_1470, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_1472, 2); if(jged(0x1013_147d, 0x9)) goto l_0x1013_147d; /* jge 0x1013147d */
            ii(0x1013_1474, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_1477, 6); mov(memw_a32[ds, eax + 0x34], 0);       /* mov word [eax+0x34], 0x0 */
        l_0x1013_147d:
            ii(0x1013_147d, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_1482, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_1485, 5); calld(0x1013_0c16, -0x874);             /* call 0x10130c16 */
            ii(0x1013_148a, 2); jmpd(0x1013_14b4, 0x28); goto l_0x1013_14b4; /* jmp 0x101314b4 */
        l_0x1013_148c:
            ii(0x1013_148c, 2); jmpd(0x1013_14b4, 0x26); goto l_0x1013_14b4; /* jmp 0x101314b4 */
        l_0x1013_148e:
            ii(0x1013_148e, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1013_1491, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x1013_1494, 4); cmp(memb_a32[ss, ebp - 0x14], 0x1);     /* cmp byte [ebp-0x14], 0x1 */
            ii(0x1013_1498, 2); if(jbd(0x1013_14a8, 0xe)) goto l_0x1013_14a8; /* jb 0x101314a8 */
            ii(0x1013_149a, 4); cmp(memb_a32[ss, ebp - 0x14], 0x1);     /* cmp byte [ebp-0x14], 0x1 */
            ii(0x1013_149e, 2); if(jbed(0x1013_1426, -0x7a)) goto l_0x1013_1426; /* jbe 0x10131426 */
            ii(0x1013_14a0, 4); cmp(memb_a32[ss, ebp - 0x14], 0x3);     /* cmp byte [ebp-0x14], 0x3 */
            ii(0x1013_14a4, 2); if(jzd(0x1013_1459, -0x4d)) goto l_0x1013_1459; /* jz 0x10131459 */
            ii(0x1013_14a6, 2); jmpd(0x1013_148c, -0x1c); goto l_0x1013_148c; /* jmp 0x1013148c */
        l_0x1013_14a8:
            ii(0x1013_14a8, 4); cmp(memb_a32[ss, ebp - 0x14], 0);       /* cmp byte [ebp-0x14], 0x0 */
            ii(0x1013_14ac, 6); if(jzd(0x1013_13f0, -0xc2)) goto l_0x1013_13f0; /* jz 0x101313f0 */
            ii(0x1013_14b2, 2); jmpd(0x1013_148c, -0x28); goto l_0x1013_148c; /* jmp 0x1013148c */
        l_0x1013_14b4:
            ii(0x1013_14b4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_14b6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_14b7, 1); popd(edi);                              /* pop edi */
            ii(0x1013_14b8, 1); popd(esi);                              /* pop esi */
            ii(0x1013_14b9, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_14ba, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_14bb, 1); retd(); return;                         /* ret */
        }
    }
}