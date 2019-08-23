using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_b3dd-f76a807f")]
        public void Method_1012_b3dd()
        {
            ii(0x1012_b3dd, 5); push(0x38);                             /* push 0x38 */
            ii(0x1012_b3e2, 5); call(Definitions.sys_check_available_stack_size, 0x3_a96b); /* call 0x10165d52 */
            ii(0x1012_b3e7, 1); push(ebx);                              /* push ebx */
            ii(0x1012_b3e8, 1); push(ecx);                              /* push ecx */
            ii(0x1012_b3e9, 1); push(esi);                              /* push esi */
            ii(0x1012_b3ea, 1); push(edi);                              /* push edi */
            ii(0x1012_b3eb, 1); push(ebp);                              /* push ebp */
            ii(0x1012_b3ec, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_b3ee, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1012_b3f4, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_b3f7, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1012_b3fa, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1012_b3fe, 6); inc(memb[ds, eax + 0x101c_59d4]);       /* inc byte [eax+0x101c59d4] */
            ii(0x1012_b404, 4); movsx(ebx, memw[ss, ebp - 0x4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x1012_b408, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1012_b40c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_b40e, 6); mov(dl, memb[ds, eax + 0x101c_59d4]);   /* mov dl, [eax+0x101c59d4] */
            ii(0x1012_b414, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1012_b418, 5); call(0x1012_b37b, -0xa2);               /* call 0x1012b37b */
            ii(0x1012_b41d, 5); call(0x1014_82f4, 0x1_ced2);            /* call 0x101482f4 */
            ii(0x1012_b422, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1012_b425, 5); call(0x1014_82f4, 0x1_ceca);            /* call 0x101482f4 */
            ii(0x1012_b42a, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1012_b42d, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
        l_0x1012_b431:
            ii(0x1012_b431, 4); cmp(memb[ss, ebp - 0xc], 0);            /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1012_b435, 2); if(jz(0x1012_b440, 0x9)) goto l_0x1012_b440; /* jz 0x1012b440 */
            ii(0x1012_b437, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x1012_b43e, 2); if(jnz(0x1012_b445, 0x5)) goto l_0x1012_b445; /* jnz 0x1012b445 */
        l_0x1012_b440:
            ii(0x1012_b440, 5); jmp(0x1012_b4ff, 0xba); goto l_0x1012_b4ff; /* jmp 0x1012b4ff */
        l_0x1012_b445:
            ii(0x1012_b445, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_b44a, 5); call(0x1012_8835, -0x2c1a);             /* call 0x10128835 */
            ii(0x1012_b44f, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_b452, 5); call(0x1014_85ad, 0x1_d156);            /* call 0x101485ad */
            ii(0x1012_b457, 5); cmp(eax, 0xbb8);                        /* cmp eax, 0xbb8 */
            ii(0x1012_b45c, 2); if(jbe(0x1012_b47f, 0x21)) goto l_0x1012_b47f; /* jbe 0x1012b47f */
            ii(0x1012_b45e, 4); movsx(ebx, memw[ss, ebp - 0x4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x1012_b462, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1012_b466, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_b468, 6); mov(dl, memb[ds, eax + 0x101c_59d4]);   /* mov dl, [eax+0x101c59d4] */
            ii(0x1012_b46e, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1012_b472, 5); call(0x1012_b37b, -0xfc);               /* call 0x1012b37b */
            ii(0x1012_b477, 5); call(0x1014_82f4, 0x1_ce78);            /* call 0x101482f4 */
            ii(0x1012_b47c, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
        l_0x1012_b47f:
            ii(0x1012_b47f, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1012_b483, 7); mov(memd[ss, ebp - 0x1c], 0x4);         /* mov dword [ebp-0x1c], 0x4 */
        l_0x1012_b48a:
            ii(0x1012_b48a, 3); dec(memd[ss, ebp - 0x1c]);              /* dec dword [ebp-0x1c] */
            ii(0x1012_b48d, 5); cmp(memw[ss, ebp - 0x1c], -0x1 /* 0xff */); /* cmp word [ebp-0x1c], 0xffff */
            ii(0x1012_b492, 2); if(jz(0x1012_b4ec, 0x58)) goto l_0x1012_b4ec; /* jz 0x1012b4ec */
            ii(0x1012_b494, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1012_b498, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_b49e, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1012_b4a4, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_b4a9, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1012_b4ac, 2); if(jnz(0x1012_b4ea, 0x3c)) goto l_0x1012_b4ea; /* jnz 0x1012b4ea */
            ii(0x1012_b4ae, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1012_b4b2, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1012_b4b6, 6); mov(dl, memb[ds, edx + 0x101c_59d4]);   /* mov dl, [edx+0x101c59d4] */
            ii(0x1012_b4bc, 6); cmp(dl, memb[ds, eax + 0x101c_59d4]);   /* cmp dl, [eax+0x101c59d4] */
            ii(0x1012_b4c2, 2); if(jz(0x1012_b4ea, 0x26)) goto l_0x1012_b4ea; /* jz 0x1012b4ea */
            ii(0x1012_b4c4, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x1012_b4c8, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_b4cb, 5); call(0x1014_85ad, 0x1_d0dd);            /* call 0x101485ad */
            ii(0x1012_b4d0, 5); cmp(eax, 0x7530);                       /* cmp eax, 0x7530 */
            ii(0x1012_b4d5, 2); if(jbe(0x1012_b4ea, 0x13)) goto l_0x1012_b4ea; /* jbe 0x1012b4ea */
            ii(0x1012_b4d7, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x1012_b4dc, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1012_b4e1, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1012_b4e5, 5); call(0x1012_748f, -0x405b);             /* call 0x1012748f */
        l_0x1012_b4ea:
            ii(0x1012_b4ea, 2); jmp(0x1012_b48a, -0x62); goto l_0x1012_b48a; /* jmp 0x1012b48a */
        l_0x1012_b4ec:
            ii(0x1012_b4ec, 5); call(/* sys */ 0x1016_b208, 0x3_fd17);  /* call 0x1016b208 */
            ii(0x1012_b4f1, 3); cmp(eax, 0x1b);                         /* cmp eax, 0x1b */
            ii(0x1012_b4f4, 2); if(jnz(0x1012_b4fa, 0x4)) goto l_0x1012_b4fa; /* jnz 0x1012b4fa */
            ii(0x1012_b4f6, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
        l_0x1012_b4fa:
            ii(0x1012_b4fa, 5); jmp(0x1012_b431, -0xce); goto l_0x1012_b431; /* jmp 0x1012b431 */
        l_0x1012_b4ff:
            ii(0x1012_b4ff, 7); mov(memd[ss, ebp - 0x10], 0x4);         /* mov dword [ebp-0x10], 0x4 */
        l_0x1012_b506:
            ii(0x1012_b506, 3); dec(memd[ss, ebp - 0x10]);              /* dec dword [ebp-0x10] */
            ii(0x1012_b509, 5); cmp(memw[ss, ebp - 0x10], -0x1 /* 0xff */); /* cmp word [ebp-0x10], 0xffff */
            ii(0x1012_b50e, 2); if(jz(0x1012_b553, 0x43)) goto l_0x1012_b553; /* jz 0x1012b553 */
            ii(0x1012_b510, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1012_b514, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_b51a, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1012_b520, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_b525, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1012_b528, 2); if(jnz(0x1012_b551, 0x27)) goto l_0x1012_b551; /* jnz 0x1012b551 */
            ii(0x1012_b52a, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1012_b52e, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1012_b530, 7); mov(ax, memw[ds, eax + 0x101c_59e4]);   /* mov ax, [eax+0x101c59e4] */
            ii(0x1012_b537, 4); cmp(ax, memw[ss, ebp - 0x4]);           /* cmp ax, [ebp-0x4] */
            ii(0x1012_b53b, 2); if(jz(0x1012_b546, 0x9)) goto l_0x1012_b546; /* jz 0x1012b546 */
            ii(0x1012_b53d, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x1012_b544, 2); if(jnz(0x1012_b548, 0x2)) goto l_0x1012_b548; /* jnz 0x1012b548 */
        l_0x1012_b546:
            ii(0x1012_b546, 2); jmp(0x1012_b551, 0x9); goto l_0x1012_b551; /* jmp 0x1012b551 */
        l_0x1012_b548:
            ii(0x1012_b548, 7); mov(memd[ss, ebp - 0x20], 0);           /* mov dword [ebp-0x20], 0x0 */
            ii(0x1012_b54f, 2); jmp(0x1012_b55a, 0x9); goto l_0x1012_b55a; /* jmp 0x1012b55a */
        l_0x1012_b551:
            ii(0x1012_b551, 2); jmp(0x1012_b506, -0x4d); goto l_0x1012_b506; /* jmp 0x1012b506 */
        l_0x1012_b553:
            ii(0x1012_b553, 7); mov(memd[ss, ebp - 0x20], 0x1);         /* mov dword [ebp-0x20], 0x1 */
        l_0x1012_b55a:
            ii(0x1012_b55a, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1012_b55d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_b55f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_b560, 1); pop(edi);                               /* pop edi */
            ii(0x1012_b561, 1); pop(esi);                               /* pop esi */
            ii(0x1012_b562, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_b563, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_b564, 1); ret();                                  /* ret */
        }
    }
}
