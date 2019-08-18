using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_8cbf-365a3097")]
        public void my_ctor_c14()
        {
            ii(0x100b_8cbf, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x100b_8cc4, 5); calld(Definitions.sys_check_available_stack_size, 0xa_d089); /* call 0x10165d52 */
            ii(0x100b_8cc9, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_8cca, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_8ccb, 1); pushd(esi);                             /* push esi */
            ii(0x100b_8ccc, 1); pushd(edi);                             /* push edi */
            ii(0x100b_8ccd, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_8cce, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_8cd0, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100b_8cd6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_8cd9, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_8cdc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_8cdf, 5); calld(0x1013_aaa8, 0x8_1dc4);           /* call 0x1013aaa8 */
            ii(0x100b_8ce4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_8ce7, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100b_8cea, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100b_8ced, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_8cf0, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100b_8cf3, 5); calld(Definitions.my_ctor_0x101b_38f8, -0x4_2608); /* call 0x100766f0 */
            ii(0x100b_8cf8, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x100b_8cfb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_8cfe, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100b_8d01, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_8d04, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_8d07, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x100b_8d0a, 5); calld(Definitions.my_ctor_0x101b_3b58, -0x2_dc6b); /* call 0x1008b0a4 */
            ii(0x100b_8d0f, 3); sub(eax, 0xa);                          /* sub eax, 0xa */
            ii(0x100b_8d12, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_8d15, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100b_8d18, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_8d1b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_8d1e, 3); add(eax, 0x10);                         /* add eax, 0x10 */
            ii(0x100b_8d21, 5); calld(Definitions.my_ctor_0x101b_4184, -0x4_2236); /* call 0x10076af0 */
            ii(0x100b_8d26, 3); sub(eax, 0x10);                         /* sub eax, 0x10 */
            ii(0x100b_8d29, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_8d2c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_8d2f, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_58fc); /* mov dword [eax+0x2], 0x101b58fc */
            ii(0x100b_8d36, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_8d39, 5); calld(0x1013_bc8c, 0x8_2f4e);           /* call 0x1013bc8c */
            ii(0x100b_8d3e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_8d40, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_8d43, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100b_8d46, 5); calld(0x1007_6630, -0x4_271b);          /* call 0x10076630 */
            ii(0x100b_8d4b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_8d4e, 3); add(edx, 0xe);                          /* add edx, 0xe */
            ii(0x100b_8d51, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_8d54, 5); calld(0x1013_bb7b, 0x8_2e22);           /* call 0x1013bb7b */
            ii(0x100b_8d59, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_8d5c, 3); add(edx, 0x14);                         /* add edx, 0x14 */
            ii(0x100b_8d5f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_8d62, 5); calld(0x1013_bb11, 0x8_2daa);           /* call 0x1013bb11 */
            ii(0x100b_8d67, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x100b_8d6c, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_8d6f, 3); add(edx, 0x10);                         /* add edx, 0x10 */
            ii(0x100b_8d72, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_8d75, 5); calld(0x1013_ba86, 0x8_2d0c);           /* call 0x1013ba86 */
            ii(0x100b_8d7a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_8d7d, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100b_8d80, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100b_8d83, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_8d85, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_8d86, 1); popd(edi);                              /* pop edi */
            ii(0x100b_8d87, 1); popd(esi);                              /* pop esi */
            ii(0x100b_8d88, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_8d89, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_8d8a, 1); retd(); return;                         /* ret */
        }
    }
}
