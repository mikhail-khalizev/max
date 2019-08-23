using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_9b07-9e2dd41a")]
        public void Method_1014_9b07()
        {
            ii(0x1014_9b07, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_9b0c, 5); calld(Definitions.sys_check_available_stack_size, 0x1_c241); /* call 0x10165d52 */
            ii(0x1014_9b11, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_9b12, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_9b13, 1); pushd(esi);                             /* push esi */
            ii(0x1014_9b14, 1); pushd(edi);                             /* push edi */
            ii(0x1014_9b15, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_9b16, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_9b18, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_9b1e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_9b21, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_9b24, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_9b27, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_9b2a, 7); cmp(ax, memw_a32[ds, edx + 0xd5]);      /* cmp ax, [edx+0xd5] */
            ii(0x1014_9b31, 2); if(jzd(0x1014_9b93, 0x60)) goto l_0x1014_9b93; /* jz 0x10149b93 */
            ii(0x1014_9b33, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_9b35, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1014_9b3a, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_9b3d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_9b40, 5); calld(0x1007_6074, -0xd_3ad1);          /* call 0x10076074 */
            ii(0x1014_9b45, 2); test(al, al);                           /* test al, al */
            ii(0x1014_9b47, 2); if(jnzd(0x1014_9b52, 0x9)) goto l_0x1014_9b52; /* jnz 0x10149b52 */
            ii(0x1014_9b49, 7); cmp(memb_a32[ds, 0x101c_3980], 0);      /* cmp byte [0x101c3980], 0x0 */
            ii(0x1014_9b50, 2); if(jzd(0x1014_9b58, 0x6)) goto l_0x1014_9b58; /* jz 0x10149b58 */
        l_0x1014_9b52:
            ii(0x1014_9b52, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1014_9b56, 2); jmpd(0x1014_9b5c, 0x4); goto l_0x1014_9b5c; /* jmp 0x10149b5c */
        l_0x1014_9b58:
            ii(0x1014_9b58, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x1014_9b5c:
            ii(0x1014_9b5c, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1014_9b5f, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x1014_9b62, 4); cmp(memb_a32[ss, ebp - 0x10], 0);       /* cmp byte [ebp-0x10], 0x0 */
            ii(0x1014_9b66, 2); if(jzd(0x1014_9b70, 0x8)) goto l_0x1014_9b70; /* jz 0x10149b70 */
            ii(0x1014_9b68, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_9b6b, 5); calld(0x1014_9fa8, 0x438);              /* call 0x10149fa8 */
        l_0x1014_9b70:
            ii(0x1014_9b70, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_9b73, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_9b76, 7); mov(memw_a32[ds, edx + 0xd5], ax);      /* mov [edx+0xd5], ax */
            ii(0x1014_9b7d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_9b80, 5); calld(0x1014_9cd1, 0x14c);              /* call 0x10149cd1 */
            ii(0x1014_9b85, 4); cmp(memb_a32[ss, ebp - 0x10], 0);       /* cmp byte [ebp-0x10], 0x0 */
            ii(0x1014_9b89, 2); if(jzd(0x1014_9b93, 0x8)) goto l_0x1014_9b93; /* jz 0x10149b93 */
            ii(0x1014_9b8b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_9b8e, 5); calld(0x1014_9fa8, 0x415);              /* call 0x10149fa8 */
        l_0x1014_9b93:
            ii(0x1014_9b93, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_9b95, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_9b96, 1); popd(edi);                              /* pop edi */
            ii(0x1014_9b97, 1); popd(esi);                              /* pop esi */
            ii(0x1014_9b98, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_9b99, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_9b9a, 1); retd();                                 /* ret */
        }
    }
}
