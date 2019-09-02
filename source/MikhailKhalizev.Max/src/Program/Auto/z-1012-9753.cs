using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_9753-23dc3580")]
        public void Method_1012_9753()
        {
            ii(0x1012_9753, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1012_9758, 5); call(Definitions.sys_check_available_stack_size, 0x3_c5f5); /* call 0x10165d52 */
            ii(0x1012_975d, 1); push(ebx);                              /* push ebx */
            ii(0x1012_975e, 1); push(ecx);                              /* push ecx */
            ii(0x1012_975f, 1); push(edx);                              /* push edx */
            ii(0x1012_9760, 1); push(esi);                              /* push esi */
            ii(0x1012_9761, 1); push(edi);                              /* push edi */
            ii(0x1012_9762, 1); push(ebp);                              /* push ebp */
            ii(0x1012_9763, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_9765, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_976b, 5); mov(eax, 0x15);                         /* mov eax, 0x15 */
            ii(0x1012_9770, 5); call(0x1012_0d94, -0x89e1);             /* call 0x10120d94 */
            ii(0x1012_9775, 7); mov(memb[ds, 0x101c_609e], 0);          /* mov byte [0x101c609e], 0x0 */
            ii(0x1012_977c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_977e, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1012_9783, 6); inc(memb[ds, eax + 0x101c_59d0]);       /* inc byte [eax+0x101c59d0] */
            ii(0x1012_9789, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_978b, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1012_9790, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_9792, 6); mov(bl, memb[ds, eax + 0x101c_59d0]);   /* mov bl, [eax+0x101c59d0] */
            ii(0x1012_9798, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_979a, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1012_979f, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_97a2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_97a4, 5); call(0x1012_8897, -0xf12);              /* call 0x10128897 */
            ii(0x1012_97a9, 5); call(0x1014_82f4, 0x1_eb46);            /* call 0x101482f4 */
            ii(0x1012_97ae, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1012_97b1, 5); call(0x1014_82f4, 0x1_eb3e);            /* call 0x101482f4 */
            ii(0x1012_97b6, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1012_97b9, 4); mov(memb[ss, ebp - 4], 1);              /* mov byte [ebp-0x4], 0x1 */
        l_0x1012_97bd:
            ii(0x1012_97bd, 4); cmp(memb[ss, ebp - 4], 0);              /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1012_97c1, 2); if(jz(0x1012_97cc, 9)) goto l_0x1012_97cc; /* jz 0x101297cc */
            ii(0x1012_97c3, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x1012_97ca, 2); if(jnz(0x1012_97d1, 5)) goto l_0x1012_97d1; /* jnz 0x101297d1 */
        l_0x1012_97cc:
            ii(0x1012_97cc, 5); jmp(0x1012_9895, 0xc4); goto l_0x1012_9895; /* jmp 0x10129895 */
        l_0x1012_97d1:
            ii(0x1012_97d1, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1012_97d6, 5); call(0x1012_8835, -0xfa6);              /* call 0x10128835 */
            ii(0x1012_97db, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_97de, 5); call(0x1014_85ad, 0x1_edca);            /* call 0x101485ad */
            ii(0x1012_97e3, 5); cmp(eax, 0xbb8);                        /* cmp eax, 0xbb8 */
            ii(0x1012_97e8, 2); if(jbe(0x1012_9812, 0x28)) goto l_0x1012_9812; /* jbe 0x10129812 */
            ii(0x1012_97ea, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_97ec, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1012_97f1, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_97f3, 6); mov(bl, memb[ds, eax + 0x101c_59d0]);   /* mov bl, [eax+0x101c59d0] */
            ii(0x1012_97f9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_97fb, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1012_9800, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_9803, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_9805, 5); call(0x1012_8897, -0xf73);              /* call 0x10128897 */
            ii(0x1012_980a, 5); call(0x1014_82f4, 0x1_eae5);            /* call 0x101482f4 */
            ii(0x1012_980f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x1012_9812:
            ii(0x1012_9812, 4); mov(memb[ss, ebp - 4], 0);              /* mov byte [ebp-0x4], 0x0 */
            ii(0x1012_9816, 7); mov(memd[ss, ebp - 0x10], 4);           /* mov dword [ebp-0x10], 0x4 */
        l_0x1012_981d:
            ii(0x1012_981d, 3); dec(memd[ss, ebp - 0x10]);              /* dec dword [ebp-0x10] */
            ii(0x1012_9820, 5); cmp(memw[ss, ebp - 0x10], -1 /* 0xff */); /* cmp word [ebp-0x10], 0xffff */
            ii(0x1012_9825, 2); if(jz(0x1012_9882, 0x5b)) goto l_0x1012_9882; /* jz 0x10129882 */
            ii(0x1012_9827, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1012_982b, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_9831, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1012_9837, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_983c, 3); cmp(eax, 3);                            /* cmp eax, 0x3 */
            ii(0x1012_983f, 2); if(jnz(0x1012_9880, 0x3f)) goto l_0x1012_9880; /* jnz 0x10129880 */
            ii(0x1012_9841, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1012_9845, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_9847, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1012_984c, 6); mov(dl, memb[ds, edx + 0x101c_59d0]);   /* mov dl, [edx+0x101c59d0] */
            ii(0x1012_9852, 6); cmp(dl, memb[ds, eax + 0x101c_59d0]);   /* cmp dl, [eax+0x101c59d0] */
            ii(0x1012_9858, 2); if(jz(0x1012_9880, 0x26)) goto l_0x1012_9880; /* jz 0x10129880 */
            ii(0x1012_985a, 4); mov(memb[ss, ebp - 4], 1);              /* mov byte [ebp-0x4], 0x1 */
            ii(0x1012_985e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_9861, 5); call(0x1014_85ad, 0x1_ed47);            /* call 0x101485ad */
            ii(0x1012_9866, 5); cmp(eax, 0x7530);                       /* cmp eax, 0x7530 */
            ii(0x1012_986b, 2); if(jbe(0x1012_9880, 0x13)) goto l_0x1012_9880; /* jbe 0x10129880 */
            ii(0x1012_986d, 5); mov(ebx, 2);                            /* mov ebx, 0x2 */
            ii(0x1012_9872, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1012_9877, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1012_987b, 5); call(0x1012_748f, -0x23f1);             /* call 0x1012748f */
        l_0x1012_9880:
            ii(0x1012_9880, 2); jmp(0x1012_981d, -0x65); goto l_0x1012_981d; /* jmp 0x1012981d */
        l_0x1012_9882:
            ii(0x1012_9882, 5); call(/* sys */ 0x1016_b208, 0x4_1981);  /* call 0x1016b208 */
            ii(0x1012_9887, 3); cmp(eax, 0x1b);                         /* cmp eax, 0x1b */
            ii(0x1012_988a, 2); if(jnz(0x1012_9890, 4)) goto l_0x1012_9890; /* jnz 0x10129890 */
            ii(0x1012_988c, 4); mov(memb[ss, ebp - 4], 0);              /* mov byte [ebp-0x4], 0x0 */
        l_0x1012_9890:
            ii(0x1012_9890, 5); jmp(0x1012_97bd, -0xd8); goto l_0x1012_97bd; /* jmp 0x101297bd */
        l_0x1012_9895:
            ii(0x1012_9895, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_9897, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_9898, 1); pop(edi);                               /* pop edi */
            ii(0x1012_9899, 1); pop(esi);                               /* pop esi */
            ii(0x1012_989a, 1); pop(edx);                               /* pop edx */
            ii(0x1012_989b, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_989c, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_989d, 1); ret();                                  /* ret */
        }
    }
}
