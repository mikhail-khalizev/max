using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_5bda-a7143695")]
        public void Method_1016_5bda()
        {
            ii(0x1016_5bda, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1016_5bdf, 5); calld(Definitions.sys_check_available_stack_size, 0x16e); /* call 0x10165d52 */
            ii(0x1016_5be4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_5be5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_5be6, 1); pushd(edx);                             /* push edx */
            ii(0x1016_5be7, 1); pushd(esi);                             /* push esi */
            ii(0x1016_5be8, 1); pushd(edi);                             /* push edi */
            ii(0x1016_5be9, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_5bea, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_5bec, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1016_5bf2, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1016_5bf5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_5bf8, 4); mov(memb_a32[ds, eax + 0x47], 0);       /* mov byte [eax+0x47], 0x0 */
        l_0x1016_5bfc:
            ii(0x1016_5bfc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_5bff, 4); cmp(memb_a32[ds, eax + 0x47], 0);       /* cmp byte [eax+0x47], 0x0 */
            ii(0x1016_5c03, 6); if(jnzd(0x1016_5c8e, 0x85)) goto l_0x1016_5c8e; /* jnz 0x10165c8e */
            ii(0x1016_5c09, 5); calld(/* sys */ 0x1016_b208, 0x55fa);   /* call 0x1016b208 */
            ii(0x1016_5c0e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_5c11, 7); cmp(memb_a32[ds, 0x101c_37d2], 0);      /* cmp byte [0x101c37d2], 0x0 */
            ii(0x1016_5c18, 2); if(jnzd(0x1016_5c26, 0xc)) goto l_0x1016_5c26; /* jnz 0x10165c26 */
            ii(0x1016_5c1a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_5c1d, 3); mov(eax, memd_a32[ds, eax + 0x19]);     /* mov eax, [eax+0x19] */
            ii(0x1016_5c20, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1a);    /* cmp byte [eax+0x3d], 0x1a */
            ii(0x1016_5c24, 2); if(jnzd(0x1016_5c28, 0x2)) goto l_0x1016_5c28; /* jnz 0x10165c28 */
        l_0x1016_5c26:
            ii(0x1016_5c26, 2); jmpd(0x1016_5c34, 0xc); goto l_0x1016_5c34; /* jmp 0x10165c34 */
        l_0x1016_5c28:
            ii(0x1016_5c28, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_5c2b, 3); mov(eax, memd_a32[ds, eax + 0x1d]);     /* mov eax, [eax+0x1d] */
            ii(0x1016_5c2e, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1a);    /* cmp byte [eax+0x3d], 0x1a */
            ii(0x1016_5c32, 2); if(jnzd(0x1016_5c36, 0x2)) goto l_0x1016_5c36; /* jnz 0x10165c36 */
        l_0x1016_5c34:
            ii(0x1016_5c34, 2); jmpd(0x1016_5c4c, 0x16); goto l_0x1016_5c4c; /* jmp 0x10165c4c */
        l_0x1016_5c36:
            ii(0x1016_5c36, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_5c39, 3); mov(eax, memd_a32[ds, eax + 0x19]);     /* mov eax, [eax+0x19] */
            ii(0x1016_5c3c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_5c3e, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1016_5c41, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_5c43, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1016_5c48, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1016_5c4a, 2); if(jzd(0x1016_5c4e, 0x2)) goto l_0x1016_5c4e; /* jz 0x10165c4e */
        l_0x1016_5c4c:
            ii(0x1016_5c4c, 2); jmpd(0x1016_5c64, 0x16); goto l_0x1016_5c64; /* jmp 0x10165c64 */
        l_0x1016_5c4e:
            ii(0x1016_5c4e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_5c51, 3); mov(eax, memd_a32[ds, eax + 0x1d]);     /* mov eax, [eax+0x1d] */
            ii(0x1016_5c54, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_5c56, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1016_5c59, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_5c5b, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1016_5c60, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1016_5c62, 2); if(jzd(0x1016_5c6b, 0x7)) goto l_0x1016_5c6b; /* jz 0x10165c6b */
        l_0x1016_5c64:
            ii(0x1016_5c64, 7); mov(memd_a32[ss, ebp - 0x8], 0x1b);     /* mov dword [ebp-0x8], 0x1b */
        l_0x1016_5c6b:
            ii(0x1016_5c6b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1016_5c6e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_5c71, 5); calld(0x1016_5a54, -0x222);             /* call 0x10165a54 */
            ii(0x1016_5c76, 5); calld(0x100d_5094, -0x9_0be7);          /* call 0x100d5094 */
            ii(0x1016_5c7b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_5c7d, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1016_5c7f, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1016_5c84, 5); calld(0x1010_0e32, -0x6_4e57);          /* call 0x10100e32 */
            ii(0x1016_5c89, 5); jmpd(0x1016_5bfc, -0x92); goto l_0x1016_5bfc; /* jmp 0x10165bfc */
        l_0x1016_5c8e:
            ii(0x1016_5c8e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_5c90, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_5c91, 1); popd(edi);                              /* pop edi */
            ii(0x1016_5c92, 1); popd(esi);                              /* pop esi */
            ii(0x1016_5c93, 1); popd(edx);                              /* pop edx */
            ii(0x1016_5c94, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_5c95, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_5c96, 1); retd(); return;                         /* ret */
        }
    }
}
