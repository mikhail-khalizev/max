using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_779d-ff8f3018")]
        public void Method_1008_779d()
        {
            ii(0x1008_779d, 5); push(0x28);                             /* push 0x28 */
            ii(0x1008_77a2, 5); call(Definitions.sys_check_available_stack_size, 0xd_e5ab); /* call 0x10165d52 */
            ii(0x1008_77a7, 1); push(ebx);                              /* push ebx */
            ii(0x1008_77a8, 1); push(ecx);                              /* push ecx */
            ii(0x1008_77a9, 1); push(esi);                              /* push esi */
            ii(0x1008_77aa, 1); push(edi);                              /* push edi */
            ii(0x1008_77ab, 1); push(ebp);                              /* push ebp */
            ii(0x1008_77ac, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_77ae, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_77b4, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_77b7, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_77ba, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_77bc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_77bf, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_77c2, 5); call(0x1013_ad11, 0xb_354a);            /* call 0x1013ad11 */
            ii(0x1008_77c7, 2); test(al, al);                           /* test al, al */
            ii(0x1008_77c9, 2); if(jz(0x1008_77fa, 0x2f)) goto l_0x1008_77fa; /* jz 0x100877fa */
            ii(0x1008_77cb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_77ce, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1008_77d1, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1008_77d4, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x1008_77d7, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_77da, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1008_77dd, 3); call_abs(memd[ds, ebx + 84]);           /* call dword [ebx+0x54] */
            ii(0x1008_77e0, 5); call(0x1008_ac50, 0x346b);              /* call 0x1008ac50 */
            ii(0x1008_77e5, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1008_77e7, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1008_77e9, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1008_77ec, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_77ef, 5); call(0x1015_2962, 0xc_b16e);            /* call 0x10152962 */
            ii(0x1008_77f4, 4); mov(memb[ss, ebp - 12], 0);             /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_77f8, 2); jmp(0x1008_7852, 0x58); goto l_0x1008_7852; /* jmp 0x10087852 */
        l_0x1008_77fa:
            ii(0x1008_77fa, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1008_77fd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_7800, 5); call(0x1015_2a52, 0xc_b24d);            /* call 0x10152a52 */
            ii(0x1008_7805, 2); test(al, al);                           /* test al, al */
            ii(0x1008_7807, 2); if(jnz(0x1008_780f, 6)) goto l_0x1008_780f; /* jnz 0x1008780f */
            ii(0x1008_7809, 4); mov(memb[ss, ebp - 12], 0);             /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_780d, 2); jmp(0x1008_7852, 0x43); goto l_0x1008_7852; /* jmp 0x10087852 */
        l_0x1008_780f:
            ii(0x1008_780f, 5); mov(ebx, 0x1008_774c);                  /* mov ebx, 0x1008774c */
            ii(0x1008_7814, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1008_7817, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_781a, 5); call(0x1007_8d4a, -0xead5);             /* call 0x10078d4a */
            ii(0x1008_781f, 2); test(al, al);                           /* test al, al */
            ii(0x1008_7821, 2); if(jnz(0x1008_7833, 0x10)) goto l_0x1008_7833; /* jnz 0x10087833 */
            ii(0x1008_7823, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_7826, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_7829, 5); call(0x1008_785d, 0x2f);                /* call 0x1008785d */
            ii(0x1008_782e, 3); mov(memb[ss, ebp - 12], al);            /* mov [ebp-0xc], al */
            ii(0x1008_7831, 2); jmp(0x1008_7852, 0x1f); goto l_0x1008_7852; /* jmp 0x10087852 */
        l_0x1008_7833:
            ii(0x1008_7833, 5); call(0x1008_9aac, 0x2274);              /* call 0x10089aac */
            ii(0x1008_7838, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_783a, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1008_783c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_783f, 5); call(0x1007_8840, -0xf004);             /* call 0x10078840 */
            ii(0x1008_7844, 2); test(al, al);                           /* test al, al */
            ii(0x1008_7846, 2); if(jz(0x1008_784e, 6)) goto l_0x1008_784e; /* jz 0x1008784e */
            ii(0x1008_7848, 4); mov(memb[ss, ebp - 12], 1);             /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_784c, 2); jmp(0x1008_7852, 4); goto l_0x1008_7852; /* jmp 0x10087852 */
        l_0x1008_784e:
            ii(0x1008_784e, 4); mov(memb[ss, ebp - 12], 1);             /* mov byte [ebp-0xc], 0x1 */
        l_0x1008_7852:
            ii(0x1008_7852, 3); mov(al, memb[ss, ebp - 12]);            /* mov al, [ebp-0xc] */
            ii(0x1008_7855, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_7857, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_7858, 1); pop(edi);                               /* pop edi */
            ii(0x1008_7859, 1); pop(esi);                               /* pop esi */
            ii(0x1008_785a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_785b, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_785c, 1); ret();                                  /* ret */
        }
    }
}
