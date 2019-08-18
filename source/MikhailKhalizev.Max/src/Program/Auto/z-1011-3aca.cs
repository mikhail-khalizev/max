using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("80349c64-e87c-483c-b42b-879037889135")]
        public void Method_1011_3aca()
        {
            ii(0x1011_3aca, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1011_3acf, 5); calld(Definitions.sys_check_available_stack_size, 0x5_227e); /* call 0x10165d52 */
            ii(0x1011_3ad4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_3ad5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_3ad6, 1); pushd(esi);                             /* push esi */
            ii(0x1011_3ad7, 1); pushd(edi);                             /* push edi */
            ii(0x1011_3ad8, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_3ad9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_3adb, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_3ae1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_3ae4, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1011_3ae7, 5); calld(/* sys */ 0x1016_be34, 0x5_8348); /* call 0x1016be34 */
            ii(0x1011_3aec, 5); calld(0x100d_533c, -0x3_e7b5);          /* call 0x100d533c */
            ii(0x1011_3af1, 1); cwde();                                 /* cwde */
            ii(0x1011_3af2, 1); pushd(eax);                             /* push eax */
            ii(0x1011_3af3, 5); calld(0x100d_5360, -0x3_e798);          /* call 0x100d5360 */
            ii(0x1011_3af8, 1); cwde();                                 /* cwde */
            ii(0x1011_3af9, 1); pushd(eax);                             /* push eax */
            ii(0x1011_3afa, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_3afc, 1); pushd(eax);                             /* push eax */
            ii(0x1011_3afd, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_3aff, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1011_3b02, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1011_3b05, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_3b08, 2); mov(ebx, memd_a32[ds, eax]);            /* mov ebx, [eax] */
            ii(0x1011_3b0a, 3); mov(ebx, memd_a32[ds, ebx + 0xe]);      /* mov ebx, [ebx+0xe] */
            ii(0x1011_3b0d, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_3b10, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_3b13, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1011_3b15, 5); mov(eax, 0x6d0);                        /* mov eax, 0x6d0 */
            ii(0x1011_3b1a, 5); calld(0x100e_8c51, -0x2_aece);          /* call 0x100e8c51 */
            ii(0x1011_3b1f, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1011_3b24, 5); calld(/* sys */ 0x1016_a24c, 0x5_6723); /* call 0x1016a24c */
            ii(0x1011_3b29, 5); mov(edx, 0x101c_3678);                  /* mov edx, 0x101c3678 */
            ii(0x1011_3b2e, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1011_3b31, 5); calld(0x100d_4d78, -0x3_edbe);          /* call 0x100d4d78 */
            ii(0x1011_3b36, 1); pushd(eax);                             /* push eax */
            ii(0x1011_3b37, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1011_3b3c, 1); pushd(eax);                             /* push eax */
            ii(0x1011_3b3d, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1011_3b42, 1); pushd(eax);                             /* push eax */
            ii(0x1011_3b43, 5); mov(eax, 0x19);                         /* mov eax, 0x19 */
            ii(0x1011_3b48, 1); pushd(eax);                             /* push eax */
            ii(0x1011_3b49, 5); mov(eax, 0x6a);                         /* mov eax, 0x6a */
            ii(0x1011_3b4e, 1); pushd(eax);                             /* push eax */
            ii(0x1011_3b4f, 5); mov(ecx, 0x193);                        /* mov ecx, 0x193 */
            ii(0x1011_3b54, 5); mov(ebx, 0x1c);                         /* mov ebx, 0x1c */
            ii(0x1011_3b59, 5); mov(edx, StringDefinitions.Messages3);  /* mov edx, 0x101a4816 */
            ii(0x1011_3b5e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_3b61, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_3b63, 5); calld(0x100e_ab9d, -0x2_8fcb);          /* call 0x100eab9d */
            ii(0x1011_3b68, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_3b6b, 9); mov(memw_a32[ds, eax + 0x5d5], 0xffff); /* mov word [eax+0x5d5], 0xffff */
            ii(0x1011_3b74, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_3b77, 5); calld(0x1011_390d, -0x26f);             /* call 0x1011390d */
            ii(0x1011_3b7c, 5); calld(/* sys */ 0x1016_bcc4, 0x5_8143); /* call 0x1016bcc4 */
            ii(0x1011_3b81, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_3b83, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_3b84, 1); popd(edi);                              /* pop edi */
            ii(0x1011_3b85, 1); popd(esi);                              /* pop esi */
            ii(0x1011_3b86, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_3b87, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_3b88, 1); retd(); return;                         /* ret */
        }
    }
}
