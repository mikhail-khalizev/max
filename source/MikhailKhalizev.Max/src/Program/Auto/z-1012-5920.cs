using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4418a358-ce71-41bc-b5ae-9cbe1f88d6cd")]
        public void Method_1012_5920()
        {
            ii(0x1012_5920, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1012_5925, 5); calld(Definitions.sys_check_available_stack_size, 0x40428); /* call 0x10165d52 */
            ii(0x1012_592a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_592b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_592c, 1); pushd(edx);                             /* push edx */
            ii(0x1012_592d, 1); pushd(esi);                             /* push esi */
            ii(0x1012_592e, 1); pushd(edi);                             /* push edi */
            ii(0x1012_592f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_5930, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_5932, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_5938, 6); mov(edx, memd_a32[ds, 0x101c_586c]);    /* mov edx, [0x101c586c] */
            ii(0x1012_593e, 5); mov(eax, memd_a32[ds, 0x101c_5870]);    /* mov eax, [0x101c5870] */
            ii(0x1012_5943, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1012_5945, 2); cmp(edx, memd_a32[ds, eax]);            /* cmp edx, [eax] */
            ii(0x1012_5947, 2); jnzd_func(0x1012_5981, 0x38);           /* jnz 0x10125981 */
            ii(0x1012_5949, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_594b, 5); mov(al, memb_a32[ds, 0x101c_5631]);     /* mov al, [0x101c5631] */
            ii(0x1012_5950, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_5952, 2); if(jzd(0x1012_5975, 0x21)) goto l_0x1012_5975; /* jz 0x10125975 */
            ii(0x1012_5954, 5); mov(eax, memd_a32[ds, 0x101c_61a0]);    /* mov eax, [0x101c61a0] */
            ii(0x1012_5959, 5); calld(0x1014_85ad, 0x22c4f);            /* call 0x101485ad */
            ii(0x1012_595e, 5); cmp(eax, 0x1f4);                        /* cmp eax, 0x1f4 */
            ii(0x1012_5963, 2); if(jbed(0x1012_596e, 0x9)) goto l_0x1012_596e; /* jbe 0x1012596e */
            ii(0x1012_5965, 7); cmp(memb_a32[ds, 0x101c_59c9], 0);      /* cmp byte [0x101c59c9], 0x0 */
            ii(0x1012_596c, 2); if(jnzd(0x1012_5970, 0x2)) goto l_0x1012_5970; /* jnz 0x10125970 */
        l_0x1012_596e:
            ii(0x1012_596e, 2); jmpd(0x1012_5975, 0x5); goto l_0x1012_5975; /* jmp 0x10125975 */
        l_0x1012_5970:
            ii(0x1012_5970, 5); calld(0x1012_5807, -0x16e);             /* call 0x10125807 */
        l_0x1012_5975:
            ii(0x1012_5975, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1012_597c, 5); jmpd_func(0x1012_5bdd, 0x25c); return;  /* jmp 0x10125bdd */
        }
    }
}
