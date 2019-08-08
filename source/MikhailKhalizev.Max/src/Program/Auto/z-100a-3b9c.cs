using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4a916550-6a33-48dd-824c-2ec346068b56")]
        public void Method_100a_3b9c()
        {
            ii(0x100a_3b9c, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x100a_3ba1, 5); calld(Definitions.sys_check_available_stack_size, 0xc_21ac); /* call 0x10165d52 */
            ii(0x100a_3ba6, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_3ba7, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_3ba8, 1); pushd(esi);                             /* push esi */
            ii(0x100a_3ba9, 1); pushd(edi);                             /* push edi */
            ii(0x100a_3baa, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_3bab, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_3bad, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100a_3bb3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_3bb6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_3bb9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3bbc, 5); calld(0x100a_a0b0, 0x64ef);             /* call 0x100aa0b0 */
            ii(0x100a_3bc1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_3bc4, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_3bc7, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100a_3bca, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_3bcd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3bd0, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_3bd3, 5); calld(0x1007_66ac, -0x2_d52c);          /* call 0x100766ac */
            ii(0x100a_3bd8, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x100a_3bdb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_3bde, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_3be1, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_3be4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3be7, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_4f04); /* mov dword [eax+0x2], 0x101b4f04 */
            ii(0x100a_3bee, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100a_3bf2, 2); if(jzd(0x100a_3bfd, 0x9)) goto l_0x100a_3bfd; /* jz 0x100a3bfd */
            ii(0x100a_3bf4, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100a_3bfb, 2); jmpd(0x100a_3c16, 0x19); goto l_0x100a_3c16; /* jmp 0x100a3c16 */
        l_0x100a_3bfd:
            ii(0x100a_3bfd, 5); mov(ecx, 0x672);                        /* mov ecx, 0x672 */
            ii(0x100a_3c02, 5); mov(ebx, StringDefinitions.AiMainCpp);  /* mov ebx, 0x101a0c20 */
            ii(0x100a_3c07, 5); mov(edx, StringDefinitions.NewUnitNotEqual0); /* mov edx, 0x101a0c2c */
            ii(0x100a_3c0c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_3c0e, 5); calld(Definitions.sys_assert, 0xc_217f); /* call 0x10165d92 */
            ii(0x100a_3c13, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x100a_3c16:
            ii(0x100a_3c16, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100a_3c1b, 5); mov(edx, 0x100);                        /* mov edx, 0x100 */
            ii(0x100a_3c20, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_3c23, 5); calld(0x100a_b120, 0x74f8);             /* call 0x100ab120 */
            ii(0x100a_3c28, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_3c2b, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100a_3c2e, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100a_3c31, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_3c33, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_3c34, 1); popd(edi);                              /* pop edi */
            ii(0x100a_3c35, 1); popd(esi);                              /* pop esi */
            ii(0x100a_3c36, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_3c37, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_3c38, 1); retd(); return;                         /* ret */
        }
    }
}
