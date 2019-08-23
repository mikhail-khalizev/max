using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_85b8-d27b716b")]
        public void Method_100a_85b8()
        {
            ii(0x100a_85b8, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_85bd, 5); call(Definitions.sys_check_available_stack_size, 0xb_d790); /* call 0x10165d52 */
            ii(0x100a_85c2, 1); push(ebx);                              /* push ebx */
            ii(0x100a_85c3, 1); push(ecx);                              /* push ecx */
            ii(0x100a_85c4, 1); push(esi);                              /* push esi */
            ii(0x100a_85c5, 1); push(edi);                              /* push edi */
            ii(0x100a_85c6, 1); push(ebp);                              /* push ebp */
            ii(0x100a_85c7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_85c9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_85cf, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_85d2, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_85d5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_85d8, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_85db, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_85dd, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_85e0, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_85e3, 5); call(0x1013_ad71, 0x9_2789);            /* call 0x1013ad71 */
            ii(0x100a_85e8, 2); test(al, al);                           /* test al, al */
            ii(0x100a_85ea, 2); if(jz(0x100a_8661, 0x75)) goto l_0x100a_8661; /* jz 0x100a8661 */
            ii(0x100a_85ec, 5); call(0x1008_ac50, -0x1_d9a1);           /* call 0x1008ac50 */
            ii(0x100a_85f1, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_85f3, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100a_85f5, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100a_85f8, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_85fb, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_85fe, 5); call(0x1007_6574, -0x3_208f);           /* call 0x10076574 */
            ii(0x100a_8603, 5); call(0x1015_2962, 0xa_a35a);            /* call 0x10152962 */
            ii(0x100a_8608, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_860b, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_860e, 5); call(0x1007_6574, -0x3_209f);           /* call 0x10076574 */
            ii(0x100a_8613, 5); call(0x1015_26ac, 0xa_a094);            /* call 0x101526ac */
            ii(0x100a_8618, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_861a, 2); if(jnz(0x100a_863c, 0x20)) goto l_0x100a_863c; /* jnz 0x100a863c */
            ii(0x100a_861c, 5); call(0x1008_a79c, -0x1_de85);           /* call 0x1008a79c */
            ii(0x100a_8621, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_8623, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100a_8625, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_8628, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_862b, 5); call(0x1007_65d0, -0x3_2060);           /* call 0x100765d0 */
            ii(0x100a_8630, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_8632, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_8637, 5); call(0x100a_53ac, -0x3290);             /* call 0x100a53ac */
        l_0x100a_863c:
            ii(0x100a_863c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_863e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_8641, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_8644, 5); call(0x1007_6630, -0x3_2019);           /* call 0x10076630 */
            ii(0x100a_8649, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_864c, 4); mov(memb[ds, eax + 0x13], 0);           /* mov byte [eax+0x13], 0x0 */
            ii(0x100a_8650, 5); call(0x100a_b288, 0x2c33);              /* call 0x100ab288 */
            ii(0x100a_8655, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_8657, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100a_8659, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_865c, 5); call(0x100a_28ff, -0x5d62);             /* call 0x100a28ff */
        l_0x100a_8661:
            ii(0x100a_8661, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_8663, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_8664, 1); pop(edi);                               /* pop edi */
            ii(0x100a_8665, 1); pop(esi);                               /* pop esi */
            ii(0x100a_8666, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_8667, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_8668, 1); ret();                                  /* ret */
        }
    }
}
