using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_4fa5-2260d9df")]
        public void Method_1012_4fa5()
        {
            ii(0x1012_4fa5, 5); push(0x30);                             /* push 0x30 */
            ii(0x1012_4faa, 5); call(Definitions.sys_check_available_stack_size, 0x4_0da3); /* call 0x10165d52 */
            ii(0x1012_4faf, 1); push(ebx);                              /* push ebx */
            ii(0x1012_4fb0, 1); push(ecx);                              /* push ecx */
            ii(0x1012_4fb1, 1); push(edx);                              /* push edx */
            ii(0x1012_4fb2, 1); push(esi);                              /* push esi */
            ii(0x1012_4fb3, 1); push(edi);                              /* push edi */
            ii(0x1012_4fb4, 1); push(ebp);                              /* push ebp */
            ii(0x1012_4fb5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_4fb7, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1012_4fbd, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1012_4fc0, 4); cmp(memd[ss, ebp - 4], 0);              /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1012_4fc4, 2); if(jnz(0x1012_4fd2, 0xc)) goto l_0x1012_4fd2; /* jnz 0x10124fd2 */
            ii(0x1012_4fc6, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x1012_4fcd, 5); jmp(0x1012_511c, 0x14a); goto l_0x1012_511c; /* jmp 0x1012511c */
        l_0x1012_4fd2:
            ii(0x1012_4fd2, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_4fd5, 3); add(edx, 4);                            /* add edx, 0x4 */
            ii(0x1012_4fd8, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1012_4fda, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1012_4fdb, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1012_4fde, 5); mov(eax, 0x1f);                         /* mov eax, 0x1f */
            ii(0x1012_4fe3, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_4fe6, 3); add(edx, 4);                            /* add edx, 0x4 */
            ii(0x1012_4fe9, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1012_4fea, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1012_4fef, 5); call(/* sys */ 0x1017_d584, 0x5_8590);  /* call 0x1017d584 */
            ii(0x1012_4ff4, 1); cli();                                  /* cli */
            ii(0x1012_4ff5, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_4ff8, 3); add(edx, 6);                            /* add edx, 0x6 */
            ii(0x1012_4ffb, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1012_4ffd, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1012_4ffe, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1012_5001, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_5004, 3); add(edx, 6);                            /* add edx, 0x6 */
            ii(0x1012_5007, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1012_5009, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1012_500a, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1012_500d, 1); sti();                                  /* sti */
            ii(0x1012_500e, 1); cld();                                  /* cld */
            ii(0x1012_500f, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1012_5012, 3); and(eax, 0x3f);                         /* and eax, 0x3f */
            ii(0x1012_5015, 3); cmp(eax, 0x30);                         /* cmp eax, 0x30 */
            ii(0x1012_5018, 2); if(jz(0x1012_5026, 0xc)) goto l_0x1012_5026; /* jz 0x10125026 */
            ii(0x1012_501a, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x1012_5021, 5); jmp(0x1012_511c, 0xf6); goto l_0x1012_511c; /* jmp 0x1012511c */
        l_0x1012_5026:
            ii(0x1012_5026, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1012_5029, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_502c, 3); add(edx, 4);                            /* add edx, 0x4 */
            ii(0x1012_502f, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1012_5030, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1012_5035, 5); call(/* sys */ 0x1017_d584, 0x5_854a);  /* call 0x1017d584 */
            ii(0x1012_503a, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_503d, 3); add(edx, 7);                            /* add edx, 0x7 */
            ii(0x1012_5040, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1012_5042, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1012_5043, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1012_5046, 5); mov(eax, 0x55);                         /* mov eax, 0x55 */
            ii(0x1012_504b, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_504e, 3); add(edx, 7);                            /* add edx, 0x7 */
            ii(0x1012_5051, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1012_5052, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1012_5057, 5); call(/* sys */ 0x1017_d584, 0x5_8528);  /* call 0x1017d584 */
            ii(0x1012_505c, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_505f, 3); add(edx, 7);                            /* add edx, 0x7 */
            ii(0x1012_5062, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1012_5064, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1012_5065, 3); cmp(eax, 0x55);                         /* cmp eax, 0x55 */
            ii(0x1012_5068, 2); if(jz(0x1012_5076, 0xc)) goto l_0x1012_5076; /* jz 0x10125076 */
            ii(0x1012_506a, 7); mov(memd[ss, ebp - 8], 1);              /* mov dword [ebp-0x8], 0x1 */
            ii(0x1012_5071, 5); jmp(0x1012_511c, 0xa6); goto l_0x1012_511c; /* jmp 0x1012511c */
        l_0x1012_5076:
            ii(0x1012_5076, 5); mov(eax, 0xaa);                         /* mov eax, 0xaa */
            ii(0x1012_507b, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_507e, 3); add(edx, 7);                            /* add edx, 0x7 */
            ii(0x1012_5081, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1012_5082, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1012_5087, 5); call(/* sys */ 0x1017_d584, 0x5_84f8);  /* call 0x1017d584 */
            ii(0x1012_508c, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_508f, 3); add(edx, 7);                            /* add edx, 0x7 */
            ii(0x1012_5092, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1012_5094, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1012_5095, 5); cmp(eax, 0xaa);                         /* cmp eax, 0xaa */
            ii(0x1012_509a, 2); if(jz(0x1012_50a8, 0xc)) goto l_0x1012_50a8; /* jz 0x101250a8 */
            ii(0x1012_509c, 7); mov(memd[ss, ebp - 8], 1);              /* mov dword [ebp-0x8], 0x1 */
            ii(0x1012_50a3, 5); jmp(0x1012_511c, 0x74); goto l_0x1012_511c; /* jmp 0x1012511c */
        l_0x1012_50a8:
            ii(0x1012_50a8, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1012_50ab, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_50ae, 3); add(edx, 7);                            /* add edx, 0x7 */
            ii(0x1012_50b1, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1012_50b2, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1012_50b7, 5); call(/* sys */ 0x1017_d584, 0x5_84c8);  /* call 0x1017d584 */
            ii(0x1012_50bc, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1012_50c1, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_50c4, 3); add(edx, 2);                            /* add edx, 0x2 */
            ii(0x1012_50c7, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1012_50c8, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1012_50cd, 5); call(/* sys */ 0x1017_d584, 0x5_84b2);  /* call 0x1017d584 */
            ii(0x1012_50d2, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_50d5, 3); add(edx, 2);                            /* add edx, 0x2 */
            ii(0x1012_50d8, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1012_50da, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1012_50db, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1012_50de, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_50e0, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_50e3, 3); add(edx, 2);                            /* add edx, 0x2 */
            ii(0x1012_50e6, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1012_50e7, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1012_50ec, 5); call(/* sys */ 0x1017_d584, 0x5_8493);  /* call 0x1017d584 */
            ii(0x1012_50f1, 7); test(memd[ss, ebp - 16], 0x80);         /* test dword [ebp-0x10], 0x80 */
            ii(0x1012_50f8, 2); if(jnz(0x1012_5103, 9)) goto l_0x1012_5103; /* jnz 0x10125103 */
            ii(0x1012_50fa, 7); mov(memd[ss, ebp - 8], 2);              /* mov dword [ebp-0x8], 0x2 */
            ii(0x1012_5101, 2); jmp(0x1012_511c, 0x19); goto l_0x1012_511c; /* jmp 0x1012511c */
        l_0x1012_5103:
            ii(0x1012_5103, 7); test(memd[ss, ebp - 16], 0x40);         /* test dword [ebp-0x10], 0x40 */
            ii(0x1012_510a, 2); if(jnz(0x1012_5115, 9)) goto l_0x1012_5115; /* jnz 0x10125115 */
            ii(0x1012_510c, 7); mov(memd[ss, ebp - 8], 3);              /* mov dword [ebp-0x8], 0x3 */
            ii(0x1012_5113, 2); jmp(0x1012_511c, 7); goto l_0x1012_511c; /* jmp 0x1012511c */
        l_0x1012_5115:
            ii(0x1012_5115, 7); mov(memd[ss, ebp - 8], 3);              /* mov dword [ebp-0x8], 0x3 */
        l_0x1012_511c:
            ii(0x1012_511c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_511f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_5121, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_5122, 1); pop(edi);                               /* pop edi */
            ii(0x1012_5123, 1); pop(esi);                               /* pop esi */
            ii(0x1012_5124, 1); pop(edx);                               /* pop edx */
            ii(0x1012_5125, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_5126, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_5127, 1); ret();                                  /* ret */
        }
    }
}
