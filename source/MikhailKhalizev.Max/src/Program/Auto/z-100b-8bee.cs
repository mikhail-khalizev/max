using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cf14430e-346c-4a6d-ba2e-655b38ddc5aa")]
        public void Method_100b_8bee()
        {
            ii(0x100b_8bee, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x100b_8bf3, 5); calld(Definitions.sys_check_available_stack_size, 0xad15a); /* call 0x10165d52 */
            ii(0x100b_8bf8, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_8bf9, 1); pushd(esi);                             /* push esi */
            ii(0x100b_8bfa, 1); pushd(edi);                             /* push edi */
            ii(0x100b_8bfb, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_8bfc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_8bfe, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100b_8c04, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_8c07, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100b_8c0a, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100b_8c0d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_8c10, 5); calld(0x1013_aaa8, 0x81e93);            /* call 0x1013aaa8 */
            ii(0x100b_8c15, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_8c18, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100b_8c1b, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_8c1e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_8c21, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100b_8c24, 5); calld(Definitions.my_ctor_0x101b38f8, -0x42539); /* call 0x100766f0 */
            ii(0x100b_8c29, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x100b_8c2c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_8c2f, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100b_8c32, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100b_8c35, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_8c38, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x100b_8c3b, 5); calld(Definitions.my_ctor_0x101b3b58, -0x2db9c); /* call 0x1008b0a4 */
            ii(0x100b_8c40, 3); sub(eax, 0xa);                          /* sub eax, 0xa */
            ii(0x100b_8c43, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_8c46, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100b_8c49, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100b_8c4c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_8c4f, 3); add(eax, 0x10);                         /* add eax, 0x10 */
            ii(0x100b_8c52, 5); calld(Definitions.my_ctor_0x101b4184, -0x42167); /* call 0x10076af0 */
            ii(0x100b_8c57, 3); sub(eax, 0x10);                         /* sub eax, 0x10 */
            ii(0x100b_8c5a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_8c5d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_8c60, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_58fc); /* mov dword [eax+0x2], 0x101b58fc */
            ii(0x100b_8c67, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_8c6a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_8c6d, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100b_8c70, 5); calld(0x1007_6630, -0x42645);           /* call 0x10076630 */
            ii(0x100b_8c75, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_8c78, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100b_8c7b, 4); mov(memw_a32[ds, edx + 0xe], ax);       /* mov [edx+0xe], ax */
            ii(0x100b_8c7f, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100b_8c83, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_8c86, 5); calld(0x1007_6074, -0x42c17);           /* call 0x10076074 */
            ii(0x100b_8c8b, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100b_8c8d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_8c90, 3); mov(memb_a32[ds, eax + 0x14], dl);      /* mov [eax+0x14], dl */
            ii(0x100b_8c93, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_8c96, 4); mov(dx, memw_a32[ds, eax + 0x1a]);      /* mov dx, [eax+0x1a] */
            ii(0x100b_8c9a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_8c9d, 4); mov(memw_a32[ds, eax + 0x10], dx);      /* mov [eax+0x10], dx */
            ii(0x100b_8ca1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_8ca4, 4); mov(dx, memw_a32[ds, eax + 0x1c]);      /* mov dx, [eax+0x1c] */
            ii(0x100b_8ca8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_8cab, 4); mov(memw_a32[ds, eax + 0x12], dx);      /* mov [eax+0x12], dx */
            ii(0x100b_8caf, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_8cb2, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100b_8cb5, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100b_8cb8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_8cba, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_8cbb, 1); popd(edi);                              /* pop edi */
            ii(0x100b_8cbc, 1); popd(esi);                              /* pop esi */
            ii(0x100b_8cbd, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_8cbe, 1); retd(); return;                         /* ret */
        }
    }
}
