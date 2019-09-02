using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_dfd1-24347f78")]
        public void Method_1013_dfd1()
        {
            ii(0x1013_dfd1, 5); push(0x38);                             /* push 0x38 */
            ii(0x1013_dfd6, 5); call(Definitions.sys_check_available_stack_size, 0x2_7d77); /* call 0x10165d52 */
            ii(0x1013_dfdb, 1); push(ebx);                              /* push ebx */
            ii(0x1013_dfdc, 1); push(ecx);                              /* push ecx */
            ii(0x1013_dfdd, 1); push(esi);                              /* push esi */
            ii(0x1013_dfde, 1); push(edi);                              /* push edi */
            ii(0x1013_dfdf, 1); push(ebp);                              /* push ebp */
            ii(0x1013_dfe0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_dfe2, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1013_dfe8, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_dfeb, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_dfee, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_dff1, 7); cmp(memd[ds, eax + 28], 0xffff);        /* cmp dword [eax+0x1c], 0xffff */
            ii(0x1013_dff8, 2); if(jz(0x1013_e003, 9)) goto l_0x1013_e003; /* jz 0x1013e003 */
            ii(0x1013_dffa, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_dffd, 4); cmp(memw[ds, eax], -1 /* 0xff */);      /* cmp word [eax], 0xffff */
            ii(0x1013_e001, 2); if(jnz(0x1013_e005, 2)) goto l_0x1013_e005; /* jnz 0x1013e005 */
        l_0x1013_e003:
            ii(0x1013_e003, 2); jmp(0x1013_e015, 0x10); goto l_0x1013_e015; /* jmp 0x1013e015 */
        l_0x1013_e005:
            ii(0x1013_e005, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_e008, 3); mov(al, memb[ds, eax + 32]);            /* mov al, [eax+0x20] */
            ii(0x1013_e00b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_e010, 3); cmp(eax, 0x14);                         /* cmp eax, 0x14 */
            ii(0x1013_e013, 2); if(jnz(0x1013_e01a, 5)) goto l_0x1013_e01a; /* jnz 0x1013e01a */
        l_0x1013_e015:
            ii(0x1013_e015, 5); jmp(0x1013_e1a6, 0x18c); goto l_0x1013_e1a6; /* jmp 0x1013e1a6 */
        l_0x1013_e01a:
            ii(0x1013_e01a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_e01d, 4); cmp(memb[ds, eax + 10], 2);             /* cmp byte [eax+0xa], 0x2 */
            ii(0x1013_e021, 6); if(jg(0x1013_e112, 0xeb)) goto l_0x1013_e112; /* jg 0x1013e112 */
            ii(0x1013_e027, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_e029, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1013_e02c, 3); mov(al, memb[ds, edx + 32]);            /* mov al, [edx+0x20] */
            ii(0x1013_e02f, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
        l_0x1013_e032:
            ii(0x1013_e032, 3); dec(memd[ss, ebp - 16]);                /* dec dword [ebp-0x10] */
            ii(0x1013_e035, 5); cmp(memw[ss, ebp - 16], -1 /* 0xff */); /* cmp word [ebp-0x10], 0xffff */
            ii(0x1013_e03a, 6); if(jz(0x1013_e0aa, 0x6a)) goto l_0x1013_e0aa; /* jz 0x1013e0aa */
            ii(0x1013_e040, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1013_e044, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1013_e047, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1013_e04a, 3); add(edx, 0x21);                         /* add edx, 0x21 */
            ii(0x1013_e04d, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_e04f, 3); mov(memd[ss, ebp - 20], edx);           /* mov [ebp-0x14], edx */
            ii(0x1013_e052, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_e055, 3); mov(dx, memw[ds, eax]);                 /* mov dx, [eax] */
            ii(0x1013_e058, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1013_e05b, 3); cmp(dx, memw[ds, eax]);                 /* cmp dx, [eax] */
            ii(0x1013_e05e, 2); if(jnz(0x1013_e07f, 0x1f)) goto l_0x1013_e07f; /* jnz 0x1013e07f */
            ii(0x1013_e060, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_e063, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x1013_e066, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1013_e069, 3); cmp(edx, memd[ds, eax + 2]);            /* cmp edx, [eax+0x2] */
            ii(0x1013_e06c, 2); if(jbe(0x1013_e07a, 0xc)) goto l_0x1013_e07a; /* jbe 0x1013e07a */
            ii(0x1013_e06e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_e071, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x1013_e074, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1013_e077, 3); mov(memd[ds, eax + 2], edx);            /* mov [eax+0x2], edx */
        l_0x1013_e07a:
            ii(0x1013_e07a, 5); jmp(0x1013_e1a6, 0x127); goto l_0x1013_e1a6; /* jmp 0x1013e1a6 */
        l_0x1013_e07f:
            ii(0x1013_e07f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_e082, 4); cmp(memb[ds, eax + 10], 1);             /* cmp byte [eax+0xa], 0x1 */
            ii(0x1013_e086, 2); if(jnz(0x1013_e091, 9)) goto l_0x1013_e091; /* jnz 0x1013e091 */
            ii(0x1013_e088, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1013_e08b, 4); cmp(memb[ds, eax + 10], 1);             /* cmp byte [eax+0xa], 0x1 */
            ii(0x1013_e08f, 2); if(jz(0x1013_e093, 2)) goto l_0x1013_e093; /* jz 0x1013e093 */
        l_0x1013_e091:
            ii(0x1013_e091, 2); jmp(0x1013_e0a8, 0x15); goto l_0x1013_e0a8; /* jmp 0x1013e0a8 */
        l_0x1013_e093:
            ii(0x1013_e093, 5); mov(ebx, 0x1c);                         /* mov ebx, 0x1c */
            ii(0x1013_e098, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1013_e09b, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1013_e09e, 5); call(Definitions.sys_memcpy, 0x2_7da8); /* call 0x10165e4b */
            ii(0x1013_e0a3, 5); jmp(0x1013_e1a6, 0xfe); goto l_0x1013_e1a6; /* jmp 0x1013e1a6 */
        l_0x1013_e0a8:
            ii(0x1013_e0a8, 2); jmp(0x1013_e032, -0x78); goto l_0x1013_e032; /* jmp 0x1013e032 */
        l_0x1013_e0aa:
            ii(0x1013_e0aa, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_e0ad, 4); cmp(memb[ds, eax + 10], 2);             /* cmp byte [eax+0xa], 0x2 */
            ii(0x1013_e0b1, 2); if(jnz(0x1013_e112, 0x5f)) goto l_0x1013_e112; /* jnz 0x1013e112 */
            ii(0x1013_e0b3, 7); mov(memd[ss, ebp - 16], 0x14);          /* mov dword [ebp-0x10], 0x14 */
        l_0x1013_e0ba:
            ii(0x1013_e0ba, 3); dec(memd[ss, ebp - 16]);                /* dec dword [ebp-0x10] */
            ii(0x1013_e0bd, 5); cmp(memw[ss, ebp - 16], -1 /* 0xff */); /* cmp word [ebp-0x10], 0xffff */
            ii(0x1013_e0c2, 2); if(jz(0x1013_e112, 0x4e)) goto l_0x1013_e112; /* jz 0x1013e112 */
            ii(0x1013_e0c4, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1013_e0c8, 6); imul(eax, eax, 0x91);                   /* imul eax, eax, 0x91 */
            ii(0x1013_e0ce, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1013_e0d1, 6); add(edx, 0x251);                        /* add edx, 0x251 */
            ii(0x1013_e0d7, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_e0d9, 3); mov(memd[ss, ebp - 24], edx);           /* mov [ebp-0x18], edx */
            ii(0x1013_e0dc, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1013_e0df, 4); mov(dx, memw[ds, eax + 4]);             /* mov dx, [eax+0x4] */
            ii(0x1013_e0e3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_e0e6, 3); cmp(dx, memw[ds, eax]);                 /* cmp dx, [eax] */
            ii(0x1013_e0e9, 2); if(jnz(0x1013_e0f6, 0xb)) goto l_0x1013_e0f6; /* jnz 0x1013e0f6 */
            ii(0x1013_e0eb, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1013_e0ee, 6); cmp(memd[ds, eax], 0xffff);             /* cmp dword [eax], 0xffff */
            ii(0x1013_e0f4, 2); if(jnz(0x1013_e0f8, 2)) goto l_0x1013_e0f8; /* jnz 0x1013e0f8 */
        l_0x1013_e0f6:
            ii(0x1013_e0f6, 2); jmp(0x1013_e110, 0x18); goto l_0x1013_e110; /* jmp 0x1013e110 */
        l_0x1013_e0f8:
            ii(0x1013_e0f8, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1013_e0fb, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1013_e0fd, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_e100, 3); mov(eax, memd[ds, eax + 28]);           /* mov eax, [eax+0x1c] */
            ii(0x1013_e103, 5); call(/* sys */ 0x1018_0dff, 0x4_2cf7);  /* call 0x10180dff */
            ii(0x1013_e108, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_e10a, 6); if(jz(0x1013_e1a6, 0x96)) goto l_0x1013_e1a6; /* jz 0x1013e1a6 */
        l_0x1013_e110:
            ii(0x1013_e110, 2); jmp(0x1013_e0ba, -0x58); goto l_0x1013_e0ba; /* jmp 0x1013e0ba */
        l_0x1013_e112:
            ii(0x1013_e112, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_e114, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1013_e117, 3); mov(al, memb[ds, edx + 32]);            /* mov al, [edx+0x20] */
            ii(0x1013_e11a, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1013_e11d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_e120, 3); mov(eax, memd[ds, eax + 21]);           /* mov eax, [eax+0x15] */
            ii(0x1013_e123, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_e126, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_e128, 2); if(jle(0x1013_e184, 0x5a)) goto l_0x1013_e184; /* jle 0x1013e184 */
            ii(0x1013_e12a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_e12c, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1013_e12f, 3); mov(al, memb[ds, edx + 32]);            /* mov al, [edx+0x20] */
            ii(0x1013_e132, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
        l_0x1013_e135:
            ii(0x1013_e135, 3); dec(memd[ss, ebp - 28]);                /* dec dword [ebp-0x1c] */
            ii(0x1013_e138, 5); cmp(memw[ss, ebp - 28], -1 /* 0xff */); /* cmp word [ebp-0x1c], 0xffff */
            ii(0x1013_e13d, 2); if(jz(0x1013_e184, 0x45)) goto l_0x1013_e184; /* jz 0x1013e184 */
            ii(0x1013_e13f, 4); movsx(eax, memw[ss, ebp - 28]);         /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_e143, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1013_e146, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1013_e149, 3); add(edx, 0x21);                         /* add edx, 0x21 */
            ii(0x1013_e14c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_e14e, 3); mov(memd[ss, ebp - 32], edx);           /* mov [ebp-0x20], edx */
            ii(0x1013_e151, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x1013_e154, 4); mov(dx, memw[ds, eax + 23]);            /* mov dx, [eax+0x17] */
            ii(0x1013_e158, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_e15b, 4); cmp(dx, memw[ds, eax + 23]);            /* cmp dx, [eax+0x17] */
            ii(0x1013_e15f, 2); if(jge(0x1013_e184, 0x23)) goto l_0x1013_e184; /* jge 0x1013e184 */
            ii(0x1013_e161, 5); mov(ebx, 0x1c);                         /* mov ebx, 0x1c */
            ii(0x1013_e166, 3); mov(edx, memd[ss, ebp - 32]);           /* mov edx, [ebp-0x20] */
            ii(0x1013_e169, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1013_e16d, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1013_e170, 5); mov(ecx, 0x101c_7299);                  /* mov ecx, 0x101c7299 */
            ii(0x1013_e175, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1013_e177, 5); call(Definitions.sys_memcpy, 0x2_7ccf); /* call 0x10165e4b */
            ii(0x1013_e17c, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_e17f, 3); dec(memd[ss, ebp - 12]);                /* dec dword [ebp-0xc] */
            ii(0x1013_e182, 2); jmp(0x1013_e135, -0x4f); goto l_0x1013_e135; /* jmp 0x1013e135 */
        l_0x1013_e184:
            ii(0x1013_e184, 5); mov(ebx, 0x1c);                         /* mov ebx, 0x1c */
            ii(0x1013_e189, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1013_e18c, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1013_e190, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1013_e193, 3); mov(ecx, memd[ss, ebp - 8]);            /* mov ecx, [ebp-0x8] */
            ii(0x1013_e196, 3); add(ecx, 0x21);                         /* add ecx, 0x21 */
            ii(0x1013_e199, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1013_e19b, 5); call(Definitions.sys_memcpy, 0x2_7cab); /* call 0x10165e4b */
            ii(0x1013_e1a0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_e1a3, 3); inc(memb[ds, eax + 32]);                /* inc byte [eax+0x20] */
        l_0x1013_e1a6:
            ii(0x1013_e1a6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_e1a8, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_e1a9, 1); pop(edi);                               /* pop edi */
            ii(0x1013_e1aa, 1); pop(esi);                               /* pop esi */
            ii(0x1013_e1ab, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_e1ac, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_e1ad, 1); ret();                                  /* ret */
        }
    }
}
