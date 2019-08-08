using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("44b5cbc4-156b-45b3-9a41-db1a47ae5f11")]
        public void Method_1015_14ef()
        {
            ii(0x1015_14ef, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1015_14f4, 5); calld(Definitions.sys_check_available_stack_size, 0x1_4859); /* call 0x10165d52 */
            ii(0x1015_14f9, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_14fa, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_14fb, 1); pushd(edx);                             /* push edx */
            ii(0x1015_14fc, 1); pushd(esi);                             /* push esi */
            ii(0x1015_14fd, 1); pushd(edi);                             /* push edi */
            ii(0x1015_14fe, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_14ff, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_1501, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_1507, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_150a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_150d, 4); test(memb_a32[ds, eax + 0x13], 0x1);    /* test byte [eax+0x13], 0x1 */
            ii(0x1015_1511, 2); if(jzd(0x1015_151f, 0xc)) goto l_0x1015_151f; /* jz 0x1015151f */
            ii(0x1015_1513, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_1516, 4); mov(ax, memw_a32[ds, eax + 0x78]);      /* mov ax, [eax+0x78] */
            ii(0x1015_151a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_151d, 2); jmpd(0x1015_1559, 0x3a); goto l_0x1015_1559; /* jmp 0x10151559 */
        l_0x1015_151f:
            ii(0x1015_151f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_1522, 3); mov(ebx, memd_a32[ds, eax + 0x50]);     /* mov ebx, [eax+0x50] */
            ii(0x1015_1525, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_1528, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_152b, 3); mov(al, memb_a32[ds, eax + 0x45]);      /* mov al, [eax+0x45] */
            ii(0x1015_152e, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_1530, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_1533, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_1536, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1015_1539, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_153c, 5); calld(0x100d_4c69, -0x7_c8d8);          /* call 0x100d4c69 */
            ii(0x1015_1541, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_1544, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1015_1548, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_154b, 3); mov(eax, memd_a32[ds, eax + 0x76]);     /* mov eax, [eax+0x76] */
            ii(0x1015_154e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_1551, 5); calld(Definitions.my_min, -0xc_7dd2);   /* call 0x10089784 */
            ii(0x1015_1556, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x1015_1559:
            ii(0x1015_1559, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_155c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_155e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_155f, 1); popd(edi);                              /* pop edi */
            ii(0x1015_1560, 1); popd(esi);                              /* pop esi */
            ii(0x1015_1561, 1); popd(edx);                              /* pop edx */
            ii(0x1015_1562, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_1563, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_1564, 1); retd(); return;                         /* ret */
        }
    }
}
