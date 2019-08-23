using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_6752-e2464b72")]
        public void Method_1010_6752()
        {
            ii(0x1010_6752, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1010_6757, 5); calld(Definitions.sys_check_available_stack_size, 0x5_f5f6); /* call 0x10165d52 */
            ii(0x1010_675c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_675d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_675e, 1); pushd(esi);                             /* push esi */
            ii(0x1010_675f, 1); pushd(edi);                             /* push edi */
            ii(0x1010_6760, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_6761, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_6763, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_6769, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_676c, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_676f, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1010_6773, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_6776, 6); pushd(memd_a32[ds, eax + 0x101b_8fdc]); /* push dword [eax+0x101b8fdc] */
            ii(0x1010_677c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_677f, 1); pushd(eax);                             /* push eax */
            ii(0x1010_6780, 5); calld(0x1012_36fa, 0x1_cf75);           /* call 0x101236fa */
            ii(0x1010_6785, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1010_6788, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_678a, 2); if(jzd(0x1010_67cf, 0x43)) goto l_0x1010_67cf; /* jz 0x101067cf */
            ii(0x1010_678c, 5); mov(eax, StringDefinitions.Gold4);      /* mov eax, 0x101a3b10 */
            ii(0x1010_6791, 1); pushd(eax);                             /* push eax */
            ii(0x1010_6792, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_6795, 1); pushd(eax);                             /* push eax */
            ii(0x1010_6796, 5); calld(0x1012_3850, 0x1_d0b5);           /* call 0x10123850 */
            ii(0x1010_679b, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1010_679e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_67a0, 2); if(jzd(0x1010_67cf, 0x2d)) goto l_0x1010_67cf; /* jz 0x101067cf */
            ii(0x1010_67a2, 2); pushd(0x14);                            /* push 0x14 */
            ii(0x1010_67a4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_67a7, 5); add(eax, 0xac);                         /* add eax, 0xac */
            ii(0x1010_67ac, 1); pushd(eax);                             /* push eax */
            ii(0x1010_67ad, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_67b0, 1); pushd(eax);                             /* push eax */
            ii(0x1010_67b1, 5); calld(0x1012_3b6c, 0x1_d3b6);           /* call 0x10123b6c */
            ii(0x1010_67b6, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1010_67b9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_67bb, 2); if(jzd(0x1010_67cf, 0x12)) goto l_0x1010_67cf; /* jz 0x101067cf */
            ii(0x1010_67bd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_67c0, 5); add(eax, 0xac);                         /* add eax, 0xac */
            ii(0x1010_67c5, 5); calld(/* sys */ 0x1017_90ce, 0x7_2904); /* call 0x101790ce */
            ii(0x1010_67ca, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_67cd, 2); jmpd(0x1010_67d6, 0x7); goto l_0x1010_67d6; /* jmp 0x101067d6 */
        l_0x1010_67cf:
            ii(0x1010_67cf, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
        l_0x1010_67d6:
            ii(0x1010_67d6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_67d9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_67db, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_67dc, 1); popd(edi);                              /* pop edi */
            ii(0x1010_67dd, 1); popd(esi);                              /* pop esi */
            ii(0x1010_67de, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_67df, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_67e0, 1); retd();                                 /* ret */
        }
    }
}
