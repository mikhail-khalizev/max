using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("61b21b6a-09f2-49bf-a936-32fc416be2ae")]
        public void Method_1011_2a06()
        {
            ii(0x1011_2a06, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1011_2a0b, 5); calld(Definitions.sys_check_available_stack_size, 0x5_3342); /* call 0x10165d52 */
            ii(0x1011_2a10, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_2a11, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_2a12, 1); pushd(esi);                             /* push esi */
            ii(0x1011_2a13, 1); pushd(edi);                             /* push edi */
            ii(0x1011_2a14, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_2a15, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_2a17, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_2a1d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_2a20, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1011_2a23, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1011_2a26, 5); mov(memb_a32[ds, 0x101c_391e], al);     /* mov [0x101c391e], al */
            ii(0x1011_2a2b, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x1011_2a30, 5); calld(0x1007_5fdc, -0x9_ca59);          /* call 0x10075fdc */
            ii(0x1011_2a35, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_2a37, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_2a3a, 6); mov(memb_a32[ds, eax + 0x50f], dl);     /* mov [eax+0x50f], dl */
            ii(0x1011_2a40, 5); mov(eax, 0x46);                         /* mov eax, 0x46 */
            ii(0x1011_2a45, 5); calld(0x1007_5fdc, -0x9_ca6e);          /* call 0x10075fdc */
            ii(0x1011_2a4a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_2a4d, 7); mov(memw_a32[ds, edx + 0x510], ax);     /* mov [edx+0x510], ax */
            ii(0x1011_2a54, 5); mov(eax, 0x47);                         /* mov eax, 0x47 */
            ii(0x1011_2a59, 5); calld(0x1007_5fdc, -0x9_ca82);          /* call 0x10075fdc */
            ii(0x1011_2a5e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_2a60, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_2a63, 7); mov(memw_a32[ds, eax + 0x512], dx);     /* mov [eax+0x512], dx */
            ii(0x1011_2a6a, 5); mov(eax, 0x48);                         /* mov eax, 0x48 */
            ii(0x1011_2a6f, 5); calld(0x1007_5fdc, -0x9_ca98);          /* call 0x10075fdc */
            ii(0x1011_2a74, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_2a76, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_2a79, 7); mov(memw_a32[ds, eax + 0x515], dx);     /* mov [eax+0x515], dx */
            ii(0x1011_2a80, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x1011_2a85, 5); calld(0x1007_5fdc, -0x9_caae);          /* call 0x10075fdc */
            ii(0x1011_2a8a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_2a8c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_2a8f, 6); mov(memb_a32[ds, eax + 0x514], dl);     /* mov [eax+0x514], dl */
            ii(0x1011_2a95, 6); mov(dl, memb_a32[ds, 0x101c_3966]);     /* mov dl, [0x101c3966] */
            ii(0x1011_2a9b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_2a9e, 6); mov(memb_a32[ds, eax + 0x51b], dl);     /* mov [eax+0x51b], dl */
            ii(0x1011_2aa4, 7); mov(dx, memw_a32[ds, 0x101c_3968]);     /* mov dx, [0x101c3968] */
            ii(0x1011_2aab, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_2aae, 7); mov(memw_a32[ds, eax + 0x51c], dx);     /* mov [eax+0x51c], dx */
            ii(0x1011_2ab5, 5); mov(eax, 0x4d);                         /* mov eax, 0x4d */
            ii(0x1011_2aba, 5); calld(0x1007_5fdc, -0x9_cae3);          /* call 0x10075fdc */
            ii(0x1011_2abf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_2ac1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_2ac4, 6); mov(memb_a32[ds, eax + 0x517], dl);     /* mov [eax+0x517], dl */
            ii(0x1011_2aca, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1011_2acf, 5); calld(0x1007_5fdc, -0x9_caf8);          /* call 0x10075fdc */
            ii(0x1011_2ad4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_2ad6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_2ad9, 6); mov(memb_a32[ds, eax + 0x518], dl);     /* mov [eax+0x518], dl */
            ii(0x1011_2adf, 5); mov(eax, 0x4f);                         /* mov eax, 0x4f */
            ii(0x1011_2ae4, 5); calld(0x1007_5fdc, -0x9_cb0d);          /* call 0x10075fdc */
            ii(0x1011_2ae9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_2aeb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_2aee, 6); mov(memb_a32[ds, eax + 0x519], dl);     /* mov [eax+0x519], dl */
            ii(0x1011_2af4, 5); mov(eax, 0x50);                         /* mov eax, 0x50 */
            ii(0x1011_2af9, 5); calld(0x1007_5fdc, -0x9_cb22);          /* call 0x10075fdc */
            ii(0x1011_2afe, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_2b01, 6); mov(memb_a32[ds, edx + 0x51a], al);     /* mov [edx+0x51a], al */
            ii(0x1011_2b07, 5); mov(eax, 0x45);                         /* mov eax, 0x45 */
            ii(0x1011_2b0c, 5); calld(0x1007_5fdc, -0x9_cb35);          /* call 0x10075fdc */
            ii(0x1011_2b11, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_2b14, 6); mov(memb_a32[ds, edx + 0x50e], al);     /* mov [edx+0x50e], al */
            ii(0x1011_2b1a, 7); cmp(memb_a32[ds, 0x101c_391e], 0x6);    /* cmp byte [0x101c391e], 0x6 */
            ii(0x1011_2b21, 2); if(jnzd(0x1011_2b44, 0x21)) goto l_0x1011_2b44; /* jnz 0x10112b44 */
            ii(0x1011_2b23, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_2b26, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_2b28, 6); mov(dl, memb_a32[ds, eax + 0x50e]);     /* mov dl, [eax+0x50e] */
            ii(0x1011_2b2e, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1011_2b31, 6); mov(edx, memd_a32[ds, edx + 0x101b_9794]); /* mov edx, [edx+0x101b9794] */
            ii(0x1011_2b37, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_2b3a, 5); add(eax, 0x4f0);                        /* add eax, 0x4f0 */
            ii(0x1011_2b3f, 5); calld(Definitions.sys_strcpy, 0x5_338b); /* call 0x10165ecf */
        l_0x1011_2b44:
            ii(0x1011_2b44, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_2b46, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_2b47, 1); popd(edi);                              /* pop edi */
            ii(0x1011_2b48, 1); popd(esi);                              /* pop esi */
            ii(0x1011_2b49, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_2b4a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_2b4b, 1); retd(); return;                         /* ret */
        }
    }
}
