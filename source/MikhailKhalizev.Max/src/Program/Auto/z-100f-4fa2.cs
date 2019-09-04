using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_4fa2-f3cd1e13")]
        public void Method_100f_4fa2()
        {
            ii(0x100f_4fa2, 5); push(0x28);                             /* push 0x28 */
            ii(0x100f_4fa7, 5); call(Definitions.sys_check_available_stack_size, 0x7_0da6); /* call 0x10165d52 */
            ii(0x100f_4fac, 1); push(ebx);                              /* push ebx */
            ii(0x100f_4fad, 1); push(ecx);                              /* push ecx */
            ii(0x100f_4fae, 1); push(edx);                              /* push edx */
            ii(0x100f_4faf, 1); push(esi);                              /* push esi */
            ii(0x100f_4fb0, 1); push(edi);                              /* push edi */
            ii(0x100f_4fb1, 1); push(ebp);                              /* push ebp */
            ii(0x100f_4fb2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_4fb4, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100f_4fba, 3); mov(memb[ss, ebp - 4], al);             /* mov [ebp-0x4], al */
            ii(0x100f_4fbd, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_4fbf, 5); mov(al, memb[ds, 0x101c_37c8]);         /* mov al, [0x101c37c8] */
            ii(0x100f_4fc4, 5); add(eax, 0x110);                        /* add eax, 0x110 */
            ii(0x100f_4fc9, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100f_4fcc, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x100f_4fd0, 5); mov(eax, memd[ds, 0x101b_8895]);        /* mov eax, [0x101b8895] */
            ii(0x100f_4fd5, 5); call(0x100c_f211, -0x2_5dc9);           /* call 0x100cf211 */
            ii(0x100f_4fda, 5); call(0x100d_51c4, -0x1_fe1b);           /* call 0x100d51c4 */
            ii(0x100f_4fdf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_4fe1, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100f_4fe3, 5); mov(eax, memd[ds, 0x101b_8895]);        /* mov eax, [0x101b8895] */
            ii(0x100f_4fe8, 5); call(0x100c_fb06, -0x2_54e7);           /* call 0x100cfb06 */
            ii(0x100f_4fed, 5); call(0x100d_51e4, -0x1_fe0e);           /* call 0x100d51e4 */
            ii(0x100f_4ff2, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_4ff4, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100f_4ff6, 5); call(0x100d_5204, -0x1_fdf7);           /* call 0x100d5204 */
            ii(0x100f_4ffb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_4ffd, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100f_4fff, 5); mov(eax, memd[ds, 0x101b_8895]);        /* mov eax, [0x101b8895] */
            ii(0x100f_5004, 5); call(0x100c_fa7c, -0x2_558d);           /* call 0x100cfa7c */
            ii(0x100f_5009, 4); cmp(memb[ss, ebp - 4], 0);              /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100f_500d, 2); if(jnz(0x100f_5015, 6)) goto l_0x100f_5015; /* jnz 0x100f5015 */
            ii(0x100f_500f, 4); mov(memb[ss, ebp - 8], 1);              /* mov byte [ebp-0x8], 0x1 */
            ii(0x100f_5013, 2); jmp(0x100f_5019, 4); goto l_0x100f_5019; /* jmp 0x100f5019 */
        l_0x100f_5015:
            ii(0x100f_5015, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
        l_0x100f_5019:
            ii(0x100f_5019, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_501b, 3); mov(dl, memb[ss, ebp - 8]);             /* mov dl, [ebp-0x8] */
            ii(0x100f_501e, 5); mov(eax, memd[ds, 0x101b_8895]);        /* mov eax, [0x101b8895] */
            ii(0x100f_5023, 5); call(0x100c_fb73, -0x2_54b5);           /* call 0x100cfb73 */
            ii(0x100f_5028, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_502a, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_502b, 1); pop(edi);                               /* pop edi */
            ii(0x100f_502c, 1); pop(esi);                               /* pop esi */
            ii(0x100f_502d, 1); pop(edx);                               /* pop edx */
            ii(0x100f_502e, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_502f, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_5030, 1); ret();                                  /* ret */
        }
    }
}
