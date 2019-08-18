using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2430277d-d9ab-4e04-afa3-6bda52cfdbaf")]
        public void Method_1012_8a34()
        {
            ii(0x1012_8a34, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1012_8a39, 5); calld(Definitions.sys_check_available_stack_size, 0x3_d314); /* call 0x10165d52 */
            ii(0x1012_8a3e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_8a3f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_8a40, 1); pushd(esi);                             /* push esi */
            ii(0x1012_8a41, 1); pushd(edi);                             /* push edi */
            ii(0x1012_8a42, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_8a43, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_8a45, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_8a4b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_8a4e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_8a51, 7); mov(memd_a32[ss, ebp - 0xc], 0x101c_5c21); /* mov dword [ebp-0xc], 0x101c5c21 */
            ii(0x1012_8a58, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1012_8a5c, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x1012_8a60, 6); imul(ebx, ebx, 0x247);                  /* imul ebx, ebx, 0x247 */
            ii(0x1012_8a66, 5); mov(eax, 0x101c_a468);                  /* mov eax, 0x101ca468 */
            ii(0x1012_8a6b, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1012_8a6d, 5); calld(0x100d_fd2c, -0x4_8d46);          /* call 0x100dfd2c */
            ii(0x1012_8a72, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_8a74, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_8a77, 5); calld(0x1007_6800, -0xb_227c);          /* call 0x10076800 */
            ii(0x1012_8a7c, 7); mov(memb_a32[ds, 0x101c_5c1c], 0xa);    /* mov byte [0x101c5c1c], 0xa */
            ii(0x1012_8a83, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_8a86, 6); mov(memw_a32[ds, 0x101c_5c1d], ax);     /* mov [0x101c5c1d], ax */
            ii(0x1012_8a8c, 9); mov(memw_a32[ds, 0x101c_5c1f], 0x1c);   /* mov word [0x101c5c1f], 0x1c */
            ii(0x1012_8a95, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_8a98, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_8a9b, 3); mov(memw_a32[ds, edx], ax);             /* mov [edx], ax */
            ii(0x1012_8a9e, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_8aa1, 5); calld(0x1007_6730, -0xb_2376);          /* call 0x10076730 */
            ii(0x1012_8aa6, 4); mov(dx, memw_a32[ds, eax + 0x8]);       /* mov dx, [eax+0x8] */
            ii(0x1012_8aaa, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_8aad, 4); mov(memw_a32[ds, eax + 0x2], dx);       /* mov [eax+0x2], dx */
            ii(0x1012_8ab1, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_8ab4, 5); calld(0x1007_6730, -0xb_2389);          /* call 0x10076730 */
            ii(0x1012_8ab9, 4); mov(dx, memw_a32[ds, eax + 0xa]);       /* mov dx, [eax+0xa] */
            ii(0x1012_8abd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_8ac0, 4); mov(memw_a32[ds, eax + 0x4], dx);       /* mov [eax+0x4], dx */
            ii(0x1012_8ac4, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_8ac7, 5); calld(0x1007_6730, -0xb_239c);          /* call 0x10076730 */
            ii(0x1012_8acc, 4); mov(dx, memw_a32[ds, eax + 0xc]);       /* mov dx, [eax+0xc] */
            ii(0x1012_8ad0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_8ad3, 4); mov(memw_a32[ds, eax + 0x6], dx);       /* mov [eax+0x6], dx */
            ii(0x1012_8ad7, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_8ada, 5); calld(0x1007_6730, -0xb_23af);          /* call 0x10076730 */
            ii(0x1012_8adf, 4); mov(dx, memw_a32[ds, eax + 0xe]);       /* mov dx, [eax+0xe] */
            ii(0x1012_8ae3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_8ae6, 4); mov(memw_a32[ds, eax + 0x8], dx);       /* mov [eax+0x8], dx */
            ii(0x1012_8aea, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_8aed, 5); calld(0x1007_6730, -0xb_23c2);          /* call 0x10076730 */
            ii(0x1012_8af2, 4); mov(dx, memw_a32[ds, eax + 0x10]);      /* mov dx, [eax+0x10] */
            ii(0x1012_8af6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_8af9, 4); mov(memw_a32[ds, eax + 0xa], dx);       /* mov [eax+0xa], dx */
            ii(0x1012_8afd, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_8b00, 5); calld(0x1007_6730, -0xb_23d5);          /* call 0x10076730 */
            ii(0x1012_8b05, 4); mov(dx, memw_a32[ds, eax + 0x12]);      /* mov dx, [eax+0x12] */
            ii(0x1012_8b09, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_8b0c, 4); mov(memw_a32[ds, eax + 0xc], dx);       /* mov [eax+0xc], dx */
            ii(0x1012_8b10, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_8b13, 5); calld(0x1007_6730, -0xb_23e8);          /* call 0x10076730 */
            ii(0x1012_8b18, 4); mov(dx, memw_a32[ds, eax + 0x14]);      /* mov dx, [eax+0x14] */
            ii(0x1012_8b1c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_8b1f, 4); mov(memw_a32[ds, eax + 0xe], dx);       /* mov [eax+0xe], dx */
            ii(0x1012_8b23, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_8b26, 5); calld(0x1007_6730, -0xb_23fb);          /* call 0x10076730 */
            ii(0x1012_8b2b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_8b2d, 3); mov(dl, memb_a32[ds, eax + 0x16]);      /* mov dl, [eax+0x16] */
            ii(0x1012_8b30, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_8b33, 4); mov(memw_a32[ds, eax + 0x10], dx);      /* mov [eax+0x10], dx */
            ii(0x1012_8b37, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_8b3a, 5); calld(0x1007_6730, -0xb_240f);          /* call 0x10076730 */
            ii(0x1012_8b3f, 4); mov(dx, memw_a32[ds, eax + 0x17]);      /* mov dx, [eax+0x17] */
            ii(0x1012_8b43, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_8b46, 4); mov(memw_a32[ds, eax + 0x12], dx);      /* mov [eax+0x12], dx */
            ii(0x1012_8b4a, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_8b4d, 5); calld(0x1007_6730, -0xb_2422);          /* call 0x10076730 */
            ii(0x1012_8b52, 4); mov(dx, memw_a32[ds, eax + 0x19]);      /* mov dx, [eax+0x19] */
            ii(0x1012_8b56, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_8b59, 4); mov(memw_a32[ds, eax + 0x14], dx);      /* mov [eax+0x14], dx */
            ii(0x1012_8b5d, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_8b60, 5); calld(0x1007_6730, -0xb_2435);          /* call 0x10076730 */
            ii(0x1012_8b65, 4); mov(dx, memw_a32[ds, eax + 0x1b]);      /* mov dx, [eax+0x1b] */
            ii(0x1012_8b69, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_8b6c, 4); mov(memw_a32[ds, eax + 0x16], dx);      /* mov [eax+0x16], dx */
            ii(0x1012_8b70, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_8b73, 5); calld(0x1007_6730, -0xb_2448);          /* call 0x10076730 */
            ii(0x1012_8b78, 4); mov(dx, memw_a32[ds, eax + 0x1d]);      /* mov dx, [eax+0x1d] */
            ii(0x1012_8b7c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_8b7f, 4); mov(memw_a32[ds, eax + 0x18], dx);      /* mov [eax+0x18], dx */
            ii(0x1012_8b83, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_8b86, 5); calld(0x1007_6730, -0xb_245b);          /* call 0x10076730 */
            ii(0x1012_8b8b, 4); mov(dx, memw_a32[ds, eax + 0x1f]);      /* mov dx, [eax+0x1f] */
            ii(0x1012_8b8f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_8b92, 4); mov(memw_a32[ds, eax + 0x1a], dx);      /* mov [eax+0x1a], dx */
            ii(0x1012_8b96, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1012_8b9b, 5); calld(0x1012_5be9, -0x2fb7);            /* call 0x10125be9 */
            ii(0x1012_8ba0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_8ba2, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1012_8ba5, 5); calld(0x1007_5eec, -0xb_2cbe);          /* call 0x10075eec */
            ii(0x1012_8baa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_8bac, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_8bad, 1); popd(edi);                              /* pop edi */
            ii(0x1012_8bae, 1); popd(esi);                              /* pop esi */
            ii(0x1012_8baf, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_8bb0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_8bb1, 1); retd(); return;                         /* ret */
        }
    }
}
