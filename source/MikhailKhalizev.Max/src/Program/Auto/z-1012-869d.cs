using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_869d-e78264df")]
        public void Method_1012_869d()
        {
            ii(0x1012_869d, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1012_86a2, 5); call(Definitions.sys_check_available_stack_size, 0x3_d6ab); /* call 0x10165d52 */
            ii(0x1012_86a7, 1); push(ebx);                              /* push ebx */
            ii(0x1012_86a8, 1); push(ecx);                              /* push ecx */
            ii(0x1012_86a9, 1); push(edx);                              /* push edx */
            ii(0x1012_86aa, 1); push(esi);                              /* push esi */
            ii(0x1012_86ab, 1); push(edi);                              /* push edi */
            ii(0x1012_86ac, 1); push(ebp);                              /* push ebp */
            ii(0x1012_86ad, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_86af, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_86b5, 3); mov(memb[ss, ebp - 4], al);             /* mov [ebp-0x4], al */
            ii(0x1012_86b8, 5); call(0x1012_75ed, -0x10d0);             /* call 0x101275ed */
            ii(0x1012_86bd, 7); cmp(memb[ds, 0x101c_391e], 3);          /* cmp byte [0x101c391e], 0x3 */
            ii(0x1012_86c4, 2); if(jz(0x1012_86cf, 9)) goto l_0x1012_86cf; /* jz 0x101286cf */
            ii(0x1012_86c6, 7); cmp(memb[ds, 0x101c_391e], 7);          /* cmp byte [0x101c391e], 0x7 */
            ii(0x1012_86cd, 2); if(jnz(0x1012_86d1, 2)) goto l_0x1012_86d1; /* jnz 0x101286d1 */
        l_0x1012_86cf:
            ii(0x1012_86cf, 2); jmp(0x1012_86da, 9); goto l_0x1012_86da; /* jmp 0x101286da */
        l_0x1012_86d1:
            ii(0x1012_86d1, 7); cmp(memb[ds, 0x101c_391e], 0xa);        /* cmp byte [0x101c391e], 0xa */
            ii(0x1012_86d8, 2); if(jnz(0x1012_86dc, 2)) goto l_0x1012_86dc; /* jnz 0x101286dc */
        l_0x1012_86da:
            ii(0x1012_86da, 2); jmp(0x1012_86e5, 9); goto l_0x1012_86e5; /* jmp 0x101286e5 */
        l_0x1012_86dc:
            ii(0x1012_86dc, 7); cmp(memb[ds, 0x101c_391e], 0xc);        /* cmp byte [0x101c391e], 0xc */
            ii(0x1012_86e3, 2); if(jnz(0x1012_86e7, 2)) goto l_0x1012_86e7; /* jnz 0x101286e7 */
        l_0x1012_86e5:
            ii(0x1012_86e5, 2); jmp(0x1012_86f0, 9); goto l_0x1012_86f0; /* jmp 0x101286f0 */
        l_0x1012_86e7:
            ii(0x1012_86e7, 7); cmp(memb[ds, 0x101c_391e], 0xd);        /* cmp byte [0x101c391e], 0xd */
            ii(0x1012_86ee, 2); if(jnz(0x1012_8706, 0x16)) goto l_0x1012_8706; /* jnz 0x10128706 */
        l_0x1012_86f0:
            ii(0x1012_86f0, 5); call(0x1014_82f4, 0x1_fbff);            /* call 0x101482f4 */
            ii(0x1012_86f5, 5); mov(memd[ds, 0x101c_61a4], eax);        /* mov [0x101c61a4], eax */
            ii(0x1012_86fa, 7); mov(memb[ds, 0x101c_59c4], 1);          /* mov byte [0x101c59c4], 0x1 */
            ii(0x1012_8701, 5); jmp(0x1012_882c, 0x126); goto l_0x1012_882c; /* jmp 0x1012882c */
        l_0x1012_8706:
            ii(0x1012_8706, 5); call(0x1014_82f4, 0x1_fbe9);            /* call 0x101482f4 */
            ii(0x1012_870b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1012_870e, 4); mov(memb[ss, ebp - 12], 1);             /* mov byte [ebp-0xc], 0x1 */
        l_0x1012_8712:
            ii(0x1012_8712, 4); cmp(memb[ss, ebp - 12], 0);             /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1012_8716, 2); if(jz(0x1012_8721, 9)) goto l_0x1012_8721; /* jz 0x10128721 */
            ii(0x1012_8718, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x1012_871f, 2); if(jnz(0x1012_8726, 5)) goto l_0x1012_8726; /* jnz 0x10128726 */
        l_0x1012_8721:
            ii(0x1012_8721, 5); jmp(0x1012_880d, 0xe7); goto l_0x1012_880d; /* jmp 0x1012880d */
        l_0x1012_8726:
            ii(0x1012_8726, 5); call(0x1012_75ed, -0x113e);             /* call 0x101275ed */
            ii(0x1012_872b, 5); call(0x100e_a7e7, -0x3_df49);           /* call 0x100ea7e7 */
            ii(0x1012_8730, 7); cmp(memb[ds, 0x101c_59c4], 0);          /* cmp byte [0x101c59c4], 0x0 */
            ii(0x1012_8737, 2); if(jnz(0x1012_8748, 0xf)) goto l_0x1012_8748; /* jnz 0x10128748 */
            ii(0x1012_8739, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_873c, 5); call(0x1014_85ad, 0x1_fe6c);            /* call 0x101485ad */
            ii(0x1012_8741, 5); cmp(eax, 0x1f4);                        /* cmp eax, 0x1f4 */
            ii(0x1012_8746, 2); if(jbe(0x1012_8773, 0x2b)) goto l_0x1012_8773; /* jbe 0x10128773 */
        l_0x1012_8748:
            ii(0x1012_8748, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_874a, 6); mov(bl, memb[ds, 0x101c_59bc]);         /* mov bl, [0x101c59bc] */
            ii(0x1012_8750, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_8752, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1012_8757, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_875a, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1012_875f, 5); call(0x1012_8897, 0x133);               /* call 0x10128897 */
            ii(0x1012_8764, 5); call(0x1014_82f4, 0x1_fb8b);            /* call 0x101482f4 */
            ii(0x1012_8769, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1012_876c, 7); mov(memb[ds, 0x101c_59c4], 0);          /* mov byte [0x101c59c4], 0x0 */
        l_0x1012_8773:
            ii(0x1012_8773, 4); mov(memb[ss, ebp - 12], 0);             /* mov byte [ebp-0xc], 0x0 */
            ii(0x1012_8777, 7); mov(memd[ss, ebp - 16], 4);             /* mov dword [ebp-0x10], 0x4 */
        l_0x1012_877e:
            ii(0x1012_877e, 3); dec(memd[ss, ebp - 16]);                /* dec dword [ebp-0x10] */
            ii(0x1012_8781, 5); cmp(memw[ss, ebp - 16], -1 /* 0xff */); /* cmp word [ebp-0x10], 0xffff */
            ii(0x1012_8786, 2); if(jz(0x1012_87ee, 0x66)) goto l_0x1012_87ee; /* jz 0x101287ee */
            ii(0x1012_8788, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1012_878c, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_8792, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1012_8798, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_879d, 3); cmp(eax, 3);                            /* cmp eax, 0x3 */
            ii(0x1012_87a0, 2); if(jnz(0x1012_87ec, 0x4a)) goto l_0x1012_87ec; /* jnz 0x101287ec */
            ii(0x1012_87a2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_87a4, 5); mov(al, memb[ds, 0x101c_59bc]);         /* mov al, [0x101c59bc] */
            ii(0x1012_87a9, 1); dec(eax);                               /* dec eax */
            ii(0x1012_87aa, 3); and(eax, 0x3f);                         /* and eax, 0x3f */
            ii(0x1012_87ad, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_87af, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1012_87b3, 6); mov(al, memb[ds, eax + 0x101c_59c0]);   /* mov al, [eax+0x101c59c0] */
            ii(0x1012_87b9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_87be, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1012_87c0, 2); if(jnz(0x1012_87ec, 0x2a)) goto l_0x1012_87ec; /* jnz 0x101287ec */
            ii(0x1012_87c2, 5); mov(eax, memd[ds, 0x101c_61a4]);        /* mov eax, [0x101c61a4] */
            ii(0x1012_87c7, 5); call(0x1014_85ad, 0x1_fde1);            /* call 0x101485ad */
            ii(0x1012_87cc, 5); cmp(eax, 0x7530);                       /* cmp eax, 0x7530 */
            ii(0x1012_87d1, 2); if(jbe(0x1012_87e8, 0x15)) goto l_0x1012_87e8; /* jbe 0x101287e8 */
            ii(0x1012_87d3, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1012_87d8, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1012_87dd, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1012_87e1, 5); call(0x1012_748f, -0x1357);             /* call 0x1012748f */
            ii(0x1012_87e6, 2); jmp(0x1012_87ee, 6); goto l_0x1012_87ee; /* jmp 0x101287ee */
        l_0x1012_87e8:
            ii(0x1012_87e8, 4); mov(memb[ss, ebp - 12], 1);             /* mov byte [ebp-0xc], 0x1 */
        l_0x1012_87ec:
            ii(0x1012_87ec, 2); jmp(0x1012_877e, -0x70); goto l_0x1012_877e; /* jmp 0x1012877e */
        l_0x1012_87ee:
            ii(0x1012_87ee, 4); cmp(memb[ss, ebp - 12], 0);             /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1012_87f2, 2); if(jz(0x1012_87fa, 6)) goto l_0x1012_87fa; /* jz 0x101287fa */
            ii(0x1012_87f4, 4); cmp(memb[ss, ebp - 4], 0);              /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1012_87f8, 2); if(jnz(0x1012_87fc, 2)) goto l_0x1012_87fc; /* jnz 0x101287fc */
        l_0x1012_87fa:
            ii(0x1012_87fa, 2); jmp(0x1012_8808, 0xc); goto l_0x1012_8808; /* jmp 0x10128808 */
        l_0x1012_87fc:
            ii(0x1012_87fc, 5); call(0x1014_82f4, 0x1_faf3);            /* call 0x101482f4 */
            ii(0x1012_8801, 5); mov(memd[ds, 0x101c_61a4], eax);        /* mov [0x101c61a4], eax */
            ii(0x1012_8806, 2); jmp(0x1012_882c, 0x24); goto l_0x1012_882c; /* jmp 0x1012882c */
        l_0x1012_8808:
            ii(0x1012_8808, 5); jmp(0x1012_8712, -0xfb); goto l_0x1012_8712; /* jmp 0x10128712 */
        l_0x1012_880d:
            ii(0x1012_880d, 5); mov(al, memb[ds, 0x101c_59bc]);         /* mov al, [0x101c59bc] */
            ii(0x1012_8812, 2); inc(al);                                /* inc al */
            ii(0x1012_8814, 2); and(al, 0x3f);                          /* and al, 0x3f */
            ii(0x1012_8816, 5); mov(memb[ds, 0x101c_59bc], al);         /* mov [0x101c59bc], al */
            ii(0x1012_881b, 5); call(0x1014_82f4, 0x1_fad4);            /* call 0x101482f4 */
            ii(0x1012_8820, 5); mov(memd[ds, 0x101c_61a4], eax);        /* mov [0x101c61a4], eax */
            ii(0x1012_8825, 7); mov(memb[ds, 0x101c_59c4], 1);          /* mov byte [0x101c59c4], 0x1 */
        l_0x1012_882c:
            ii(0x1012_882c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_882e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_882f, 1); pop(edi);                               /* pop edi */
            ii(0x1012_8830, 1); pop(esi);                               /* pop esi */
            ii(0x1012_8831, 1); pop(edx);                               /* pop edx */
            ii(0x1012_8832, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_8833, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_8834, 1); ret();                                  /* ret */
        }
    }
}
