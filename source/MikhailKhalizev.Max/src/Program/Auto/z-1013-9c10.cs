using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_9c10-4b299097")]
        public void Method_1013_9c10()
        {
            ii(0x1013_9c10, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_9c15, 5); calld(Definitions.sys_check_available_stack_size, 0x2_c138); /* call 0x10165d52 */
            ii(0x1013_9c1a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_9c1b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_9c1c, 1); pushd(edx);                             /* push edx */
            ii(0x1013_9c1d, 1); pushd(esi);                             /* push esi */
            ii(0x1013_9c1e, 1); pushd(edi);                             /* push edi */
            ii(0x1013_9c1f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_9c20, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_9c22, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_9c28, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x1013_9c2d, 5); calld(0x1007_5fdc, -0xc_3c56);          /* call 0x10075fdc */
            ii(0x1013_9c32, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x1013_9c35, 4); cmp(memb_a32[ss, ebp - 0x4], 0x1);      /* cmp byte [ebp-0x4], 0x1 */
            ii(0x1013_9c39, 2); if(jzd(0x1013_9c41, 0x6)) goto l_0x1013_9c41; /* jz 0x10139c41 */
            ii(0x1013_9c3b, 4); cmp(memb_a32[ss, ebp - 0x4], 0x2);      /* cmp byte [ebp-0x4], 0x2 */
            ii(0x1013_9c3f, 2); if(jnzd(0x1013_9c43, 0x2)) goto l_0x1013_9c43; /* jnz 0x10139c43 */
        l_0x1013_9c41:
            ii(0x1013_9c41, 2); jmpd(0x1013_9c49, 0x6); goto l_0x1013_9c49; /* jmp 0x10139c49 */
        l_0x1013_9c43:
            ii(0x1013_9c43, 4); cmp(memb_a32[ss, ebp - 0x4], 0x8);      /* cmp byte [ebp-0x4], 0x8 */
            ii(0x1013_9c47, 2); if(jnzd(0x1013_9c4f, 0x6)) goto l_0x1013_9c4f; /* jnz 0x10139c4f */
        l_0x1013_9c49:
            ii(0x1013_9c49, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1013_9c4d, 2); jmpd(0x1013_9c7f, 0x30); goto l_0x1013_9c7f; /* jmp 0x10139c7f */
        l_0x1013_9c4f:
            ii(0x1013_9c4f, 4); cmp(memb_a32[ss, ebp - 0x4], 0x9);      /* cmp byte [ebp-0x4], 0x9 */
            ii(0x1013_9c53, 2); if(jnzd(0x1013_9c79, 0x24)) goto l_0x1013_9c79; /* jnz 0x10139c79 */
            ii(0x1013_9c55, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x1013_9c5c, 2); if(jzd(0x1013_9c64, 0x6)) goto l_0x1013_9c64; /* jz 0x10139c64 */
            ii(0x1013_9c5e, 4); mov(memb_a32[ss, ebp - 0x8], 0x4);      /* mov byte [ebp-0x8], 0x4 */
            ii(0x1013_9c62, 2); jmpd(0x1013_9c7f, 0x1b); goto l_0x1013_9c7f; /* jmp 0x10139c7f */
        l_0x1013_9c64:
            ii(0x1013_9c64, 7); cmp(memb_a32[ds, 0x101c_388b], 0);      /* cmp byte [0x101c388b], 0x0 */
            ii(0x1013_9c6b, 2); if(jzd(0x1013_9c73, 0x6)) goto l_0x1013_9c73; /* jz 0x10139c73 */
            ii(0x1013_9c6d, 4); mov(memb_a32[ss, ebp - 0x8], 0x3);      /* mov byte [ebp-0x8], 0x3 */
            ii(0x1013_9c71, 2); jmpd(0x1013_9c7f, 0xc); goto l_0x1013_9c7f; /* jmp 0x10139c7f */
        l_0x1013_9c73:
            ii(0x1013_9c73, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1013_9c77, 2); jmpd(0x1013_9c7f, 0x6); goto l_0x1013_9c7f; /* jmp 0x10139c7f */
        l_0x1013_9c79:
            ii(0x1013_9c79, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1013_9c7c, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
        l_0x1013_9c7f:
            ii(0x1013_9c7f, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1013_9c82, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_9c84, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_9c85, 1); popd(edi);                              /* pop edi */
            ii(0x1013_9c86, 1); popd(esi);                              /* pop esi */
            ii(0x1013_9c87, 1); popd(edx);                              /* pop edx */
            ii(0x1013_9c88, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_9c89, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_9c8a, 1); retd(); return;                         /* ret */
        }
    }
}
