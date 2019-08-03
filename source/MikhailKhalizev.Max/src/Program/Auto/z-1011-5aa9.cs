using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b7fd4a43-27c0-4f0c-9906-3d26b74c63a8")]
        public void Method_1011_5aa9()
        {
            ii(0x1011_5aa9, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1011_5aae, 5); calld(Definitions.sys_check_available_stack_size, 0x5029f); /* call 0x10165d52 */
            ii(0x1011_5ab3, 1); pushd(esi);                             /* push esi */
            ii(0x1011_5ab4, 1); pushd(edi);                             /* push edi */
            ii(0x1011_5ab5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_5ab6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_5ab8, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1011_5abe, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_5ac1, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_5ac4, 3); mov(memd_a32[ss, ebp - 0xc], ebx);      /* mov [ebp-0xc], ebx */
            ii(0x1011_5ac7, 3); mov(memd_a32[ss, ebp - 0x8], ecx);      /* mov [ebp-0x8], ecx */
            ii(0x1011_5aca, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1011_5ad1, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1011_5ad6, 5); calld(/* sys */ 0x1016_a24c, 0x54771);  /* call 0x1016a24c */
            ii(0x1011_5adb, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1011_5adf, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_5ae2, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1011_5ae5, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1011_5ae8, 5); cmp(memw_a32[ss, ebp + 0x18], 0);       /* cmp word [ebp+0x18], 0x0 */
            ii(0x1011_5aed, 2); if(jzd(0x1011_5af8, 0x9)) goto l_0x1011_5af8; /* jz 0x10115af8 */
            ii(0x1011_5aef, 7); mov(memd_a32[ss, ebp - 0x18], 0x4_0000); /* mov dword [ebp-0x18], 0x40000 */
            ii(0x1011_5af6, 2); jmpd(0x1011_5aff, 0x7); goto l_0x1011_5aff; /* jmp 0x10115aff */
        l_0x1011_5af8:
            ii(0x1011_5af8, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
        l_0x1011_5aff:
            ii(0x1011_5aff, 4); movsx(eax, memw_a32[ss, ebp + 0x14]);   /* movsx eax, word [ebp+0x14] */
            ii(0x1011_5b03, 5); add(eax, 0x1_0000);                     /* add eax, 0x10000 */
            ii(0x1011_5b08, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x1011_5b0b, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_5b0d, 3); mov(memd_a32[ss, ebp - 0x1c], edx);     /* mov [ebp-0x1c], edx */
        l_0x1011_5b10:
            ii(0x1011_5b10, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1011_5b13, 1); pushd(eax);                             /* push eax */
            ii(0x1011_5b14, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x1011_5b18, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1011_5b1c, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1011_5b20, 3); add(edx, memd_a32[ss, ebp + 0x10]);     /* add edx, [ebp+0x10] */
            ii(0x1011_5b23, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_5b26, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1011_5b29, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_5b2c, 6); calld_abs(memd_a32[ds, 0x101b_ddec]);   /* call dword [0x101bddec] */
            ii(0x1011_5b32, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1011_5b36, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x1011_5b39, 3); add(memd_a32[ss, ebp - 0x8], eax);      /* add [ebp-0x8], eax */
            ii(0x1011_5b3c, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1011_5b40, 3); add(eax, memd_a32[ss, ebp + 0x10]);     /* add eax, [ebp+0x10] */
            ii(0x1011_5b43, 5); calld(Definitions.sys_strlen, 0x5c37f); /* call 0x10171ec7 */
            ii(0x1011_5b48, 1); inc(eax);                               /* inc eax */
            ii(0x1011_5b49, 3); add(memd_a32[ss, ebp - 0x14], eax);     /* add [ebp-0x14], eax */
            ii(0x1011_5b4c, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1011_5b50, 3); add(eax, memd_a32[ss, ebp + 0x10]);     /* add eax, [ebp+0x10] */
            ii(0x1011_5b53, 3); cmp(memb_a32[ds, eax], 0);              /* cmp byte [eax], 0x0 */
            ii(0x1011_5b56, 2); if(jnzd(0x1011_5b10, -0x48)) goto l_0x1011_5b10; /* jnz 0x10115b10 */
            ii(0x1011_5b58, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_5b5a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_5b5b, 1); popd(edi);                              /* pop edi */
            ii(0x1011_5b5c, 1); popd(esi);                              /* pop esi */
            ii(0x1011_5b5d, 3); retd(0xc); return;                      /* ret 0xc */
        }
    }
}