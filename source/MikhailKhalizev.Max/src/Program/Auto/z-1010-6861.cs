using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e8a53418-ebfe-406c-a041-b897cf9343d6")]
        public void Method_1010_6861()
        {
            ii(0x1010_6861, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1010_6866, 5); calld(Definitions.sys_check_available_stack_size, 0x5_f4e7); /* call 0x10165d52 */
            ii(0x1010_686b, 1); pushd(esi);                             /* push esi */
            ii(0x1010_686c, 1); pushd(edi);                             /* push edi */
            ii(0x1010_686d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_686e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_6870, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1010_6876, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_6879, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1010_687c, 3); mov(memd_a32[ss, ebp - 0xc], ebx);      /* mov [ebp-0xc], ebx */
            ii(0x1010_687f, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1010_6882, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_6886, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_6889, 6); pushd(memd_a32[ds, eax + 0x101b_8fdc]); /* push dword [eax+0x101b8fdc] */
            ii(0x1010_688f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_6892, 1); pushd(eax);                             /* push eax */
            ii(0x1010_6893, 5); calld(0x1012_36fa, 0x1_ce62);           /* call 0x101236fa */
            ii(0x1010_6898, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1010_689b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_689d, 2); if(jzd(0x1010_68ca, 0x2b)) goto l_0x1010_68ca; /* jz 0x101068ca */
            ii(0x1010_689f, 5); mov(eax, StringDefinitions.Name);       /* mov eax, 0x101a3b52 */
            ii(0x1010_68a4, 1); pushd(eax);                             /* push eax */
            ii(0x1010_68a5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_68a8, 1); pushd(eax);                             /* push eax */
            ii(0x1010_68a9, 5); calld(0x1012_3850, 0x1_cfa2);           /* call 0x10123850 */
            ii(0x1010_68ae, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1010_68b1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_68b3, 2); if(jzd(0x1010_68ca, 0x15)) goto l_0x1010_68ca; /* jz 0x101068ca */
            ii(0x1010_68b5, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1010_68b9, 1); pushd(eax);                             /* push eax */
            ii(0x1010_68ba, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_68bd, 1); pushd(eax);                             /* push eax */
            ii(0x1010_68be, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_68c1, 1); pushd(eax);                             /* push eax */
            ii(0x1010_68c2, 5); calld(0x1012_3b6c, 0x1_d2a5);           /* call 0x10123b6c */
            ii(0x1010_68c7, 3); add(esp, 0xc);                          /* add esp, 0xc */
        l_0x1010_68ca:
            ii(0x1010_68ca, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_68cc, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_68cd, 1); popd(edi);                              /* pop edi */
            ii(0x1010_68ce, 1); popd(esi);                              /* pop esi */
            ii(0x1010_68cf, 1); retd(); return;                         /* ret */
        }
    }
}
