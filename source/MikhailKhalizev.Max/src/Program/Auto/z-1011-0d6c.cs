using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4a8c06ad-9ab1-4302-b185-7664e0325469")]
        public void Method_1011_0d6c()
        {
            ii(0x1011_0d6c, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1011_0d71, 5); calld(Definitions.sys_check_available_stack_size, 0x5_4fdc); /* call 0x10165d52 */
            ii(0x1011_0d76, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_0d77, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_0d78, 1); pushd(edx);                             /* push edx */
            ii(0x1011_0d79, 1); pushd(esi);                             /* push esi */
            ii(0x1011_0d7a, 1); pushd(edi);                             /* push edi */
            ii(0x1011_0d7b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_0d7c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_0d7e, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1011_0d84, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_0d87, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_0d8a, 7); cmp(memb_a32[ds, eax + 0x143], 0x1);    /* cmp byte [eax+0x143], 0x1 */
            ii(0x1011_0d91, 2); if(jnzd(0x1011_0daa, 0x17)) goto l_0x1011_0daa; /* jnz 0x10110daa */
            ii(0x1011_0d93, 5); calld(0x100d_4e6c, -0x3_bf2c);          /* call 0x100d4e6c */
            ii(0x1011_0d98, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_0d9a, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1011_0d9c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_0d9e, 5); mov(eax, 0x1a);                         /* mov eax, 0x1a */
            ii(0x1011_0da3, 5); calld(0x1010_5b00, -0xb2a8);            /* call 0x10105b00 */
            ii(0x1011_0da8, 2); jmpd(0x1011_0e05, 0x5b); goto l_0x1011_0e05; /* jmp 0x10110e05 */
        l_0x1011_0daa:
            ii(0x1011_0daa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_0dad, 7); cmp(memb_a32[ds, eax + 0x143], 0x8);    /* cmp byte [eax+0x143], 0x8 */
            ii(0x1011_0db4, 2); if(jnzd(0x1011_0dcd, 0x17)) goto l_0x1011_0dcd; /* jnz 0x10110dcd */
            ii(0x1011_0db6, 5); calld(0x100d_4e6c, -0x3_bf4f);          /* call 0x100d4e6c */
            ii(0x1011_0dbb, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_0dbd, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1011_0dbf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_0dc1, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1011_0dc6, 5); calld(0x1010_5b00, -0xb2cb);            /* call 0x10105b00 */
            ii(0x1011_0dcb, 2); jmpd(0x1011_0e05, 0x38); goto l_0x1011_0e05; /* jmp 0x10110e05 */
        l_0x1011_0dcd:
            ii(0x1011_0dcd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_0dd0, 7); cmp(memb_a32[ds, eax + 0x143], 0x2);    /* cmp byte [eax+0x143], 0x2 */
            ii(0x1011_0dd7, 2); if(jnzd(0x1011_0df0, 0x17)) goto l_0x1011_0df0; /* jnz 0x10110df0 */
            ii(0x1011_0dd9, 5); calld(0x100d_4e6c, -0x3_bf72);          /* call 0x100d4e6c */
            ii(0x1011_0dde, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_0de0, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1011_0de2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_0de4, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x1011_0de9, 5); calld(0x1010_5b00, -0xb2ee);            /* call 0x10105b00 */
            ii(0x1011_0dee, 2); jmpd(0x1011_0e05, 0x15); goto l_0x1011_0e05; /* jmp 0x10110e05 */
        l_0x1011_0df0:
            ii(0x1011_0df0, 5); calld(0x100d_4e6c, -0x3_bf89);          /* call 0x100d4e6c */
            ii(0x1011_0df5, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_0df7, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1011_0df9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_0dfb, 5); mov(eax, 0x1f);                         /* mov eax, 0x1f */
            ii(0x1011_0e00, 5); calld(0x1010_5b00, -0xb305);            /* call 0x10105b00 */
        l_0x1011_0e05:
            ii(0x1011_0e05, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_0e07, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_0e08, 1); popd(edi);                              /* pop edi */
            ii(0x1011_0e09, 1); popd(esi);                              /* pop esi */
            ii(0x1011_0e0a, 1); popd(edx);                              /* pop edx */
            ii(0x1011_0e0b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_0e0c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_0e0d, 1); retd(); return;                         /* ret */
        }
    }
}
