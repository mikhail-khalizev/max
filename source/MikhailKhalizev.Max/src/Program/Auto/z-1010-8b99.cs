using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_8b99-cc7d599b")]
        public void Method_1010_8b99()
        {
            ii(0x1010_8b99, 5); push(0x42c);                            /* push 0x42c */
            ii(0x1010_8b9e, 5); call(Definitions.sys_check_available_stack_size, 0x5_d1af); /* call 0x10165d52 */
            ii(0x1010_8ba3, 1); push(ebx);                              /* push ebx */
            ii(0x1010_8ba4, 1); push(ecx);                              /* push ecx */
            ii(0x1010_8ba5, 1); push(edx);                              /* push edx */
            ii(0x1010_8ba6, 1); push(esi);                              /* push esi */
            ii(0x1010_8ba7, 1); push(edi);                              /* push edi */
            ii(0x1010_8ba8, 1); push(ebp);                              /* push ebp */
            ii(0x1010_8ba9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_8bab, 6); sub(esp, 0x40c);                        /* sub esp, 0x40c */
            ii(0x1010_8bb1, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_8bb4, 7); mov(memd[ss, ebp - 0xc], 0x1);          /* mov dword [ebp-0xc], 0x1 */
            ii(0x1010_8bbb, 2); jmp(0x1010_8bc3, 0x6); goto l_0x1010_8bc3; /* jmp 0x10108bc3 */
        l_0x1010_8bbd:
            ii(0x1010_8bbd, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_8bc0, 3); inc(memd[ss, ebp - 0xc]);               /* inc dword [ebp-0xc] */
        l_0x1010_8bc3:
            ii(0x1010_8bc3, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1010_8bc7, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1010_8bca, 6); if(jg(0x1010_8c70, 0xa0)) goto l_0x1010_8c70; /* jg 0x10108c70 */
            ii(0x1010_8bd0, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1010_8bd3, 3); mov(memb[ss, ebp - 0x14], al);          /* mov [ebp-0x14], al */
            ii(0x1010_8bd6, 5); mov(ecx, 0x64);                         /* mov ecx, 0x64 */
            ii(0x1010_8bdb, 6); lea(ebx, ebp - 0x20c);                  /* lea ebx, [ebp-0x20c] */
            ii(0x1010_8be1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_8be3, 3); mov(al, memb[ss, ebp - 0x14]);          /* mov al, [ebp-0x14] */
            ii(0x1010_8be6, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1010_8be9, 5); mov(eax, 0x101c_3c4c);                  /* mov eax, 0x101c3c4c */
            ii(0x1010_8bee, 5); call(0x1010_6861, -0x2392);             /* call 0x10106861 */
            ii(0x1010_8bf3, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1010_8bf7, 3); imul(edx, edx, 0x14);                   /* imul edx, edx, 0x14 */
            ii(0x1010_8bfa, 6); lea(eax, ebp - 0x20c);                  /* lea eax, [ebp-0x20c] */
            ii(0x1010_8c00, 6); mov(memd[ds, edx + 0x101b_9960], eax);  /* mov [edx+0x101b9960], eax */
            ii(0x1010_8c06, 5); call(0x1011_5318, 0xc70d);              /* call 0x10115318 */
            ii(0x1010_8c0b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_8c10, 6); mov(memd[ss, ebp - 0x210], eax);        /* mov [ebp-0x210], eax */
            ii(0x1010_8c16, 6); push(memd[ss, ebp - 0x210]);            /* push dword [ebp-0x210] */
            ii(0x1010_8c1c, 10); mov(memd[ss, ebp - 0x214], 0x1);       /* mov dword [ebp-0x214], 0x1 */
            ii(0x1010_8c26, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_8c29, 3); mov(eax, memd[ds, eax + 0x9]);          /* mov eax, [eax+0x9] */
            ii(0x1010_8c2c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_8c2f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_8c31, 3); mov(dl, memb[ss, ebp - 0x14]);          /* mov dl, [ebp-0x14] */
            ii(0x1010_8c34, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1010_8c36, 2); if(jnz(0x1010_8c3e, 0x6)) goto l_0x1010_8c3e; /* jnz 0x10108c3e */
            ii(0x1010_8c38, 4); mov(memb[ss, ebp - 0x18], 0x2);         /* mov byte [ebp-0x18], 0x2 */
            ii(0x1010_8c3c, 2); jmp(0x1010_8c42, 0x4); goto l_0x1010_8c42; /* jmp 0x10108c42 */
        l_0x1010_8c3e:
            ii(0x1010_8c3e, 4); mov(memb[ss, ebp - 0x18], 0xa2);        /* mov byte [ebp-0x18], 0xa2 */
        l_0x1010_8c42:
            ii(0x1010_8c42, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_8c44, 3); mov(bl, memb[ss, ebp - 0x18]);          /* mov bl, [ebp-0x18] */
            ii(0x1010_8c47, 6); or(ebx, 0x1_0000);                      /* or ebx, 0x10000 */
            ii(0x1010_8c4d, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1010_8c51, 3); imul(eax, eax, 0x14);                   /* imul eax, eax, 0x14 */
            ii(0x1010_8c54, 5); mov(edx, 0x101b_9950);                  /* mov edx, 0x101b9950 */
            ii(0x1010_8c59, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_8c5b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_8c5e, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_8c60, 6); mov(ecx, memd[ss, ebp - 0x214]);        /* mov ecx, [ebp-0x214] */
            ii(0x1010_8c66, 5); call(0x1010_8a05, -0x266);              /* call 0x10108a05 */
            ii(0x1010_8c6b, 5); jmp(0x1010_8bbd, -0xb3); goto l_0x1010_8bbd; /* jmp 0x10108bbd */
        l_0x1010_8c70:
            ii(0x1010_8c70, 7); mov(memd[ss, ebp - 0x10], 0x101b_9a04); /* mov dword [ebp-0x10], 0x101b9a04 */
            ii(0x1010_8c77, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_8c7a, 3); mov(ecx, memd[ds, eax + 0x2]);          /* mov ecx, [eax+0x2] */
            ii(0x1010_8c7d, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1010_8c80, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_8c83, 3); movsx(ebx, memw[ds, eax]);              /* movsx ebx, word [eax] */
            ii(0x1010_8c86, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_8c89, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1010_8c8b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_8c8e, 3); mov(eax, memd[ds, eax + 0x11]);         /* mov eax, [eax+0x11] */
            ii(0x1010_8c91, 5); call(0x100d_809f, -0x3_0bf7);           /* call 0x100d809f */
            ii(0x1010_8c96, 7); mov(memd[ss, ebp - 0x8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1010_8c9d, 5); mov(ecx, 0x64);                         /* mov ecx, 0x64 */
            ii(0x1010_8ca2, 6); lea(ebx, ebp - 0x20c);                  /* lea ebx, [ebp-0x20c] */
            ii(0x1010_8ca8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_8cab, 3); mov(edx, memd[ds, eax + 0x9]);          /* mov edx, [eax+0x9] */
            ii(0x1010_8cae, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_8cb1, 5); mov(eax, 0x101c_3c4c);                  /* mov eax, 0x101c3c4c */
            ii(0x1010_8cb6, 5); call(0x1010_67e1, -0x24da);             /* call 0x101067e1 */
            ii(0x1010_8cbb, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x1010_8cc0, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_8cc3, 3); inc(memd[ss, ebp - 0x8]);               /* inc dword [ebp-0x8] */
            ii(0x1010_8cc6, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1010_8cc9, 6); lea(edx, ebp - 0x20c);                  /* lea edx, [ebp-0x20c] */
            ii(0x1010_8ccf, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_8cd2, 5); call(0x1010_8aa1, -0x236);              /* call 0x10108aa1 */
        l_0x1010_8cd7:
            ii(0x1010_8cd7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_8cda, 5); cmp(memw[ds, eax + 0xb], 0);            /* cmp word [eax+0xb], 0x0 */
            ii(0x1010_8cdf, 6); if(jz(0x1010_8da9, 0xc4)) goto l_0x1010_8da9; /* jz 0x10108da9 */
            ii(0x1010_8ce5, 5); mov(ebx, 0x64);                         /* mov ebx, 0x64 */
            ii(0x1010_8cea, 6); lea(edx, ebp - 0x408);                  /* lea edx, [ebp-0x408] */
            ii(0x1010_8cf0, 5); mov(eax, 0x101c_3c4c);                  /* mov eax, 0x101c3c4c */
            ii(0x1010_8cf5, 5); call(0x1010_6715, -0x25e5);             /* call 0x10106715 */
            ii(0x1010_8cfa, 5); mov(edx, StringDefinitions.Control40);  /* mov edx, 0x101a4572 */
            ii(0x1010_8cff, 6); lea(eax, ebp - 0x408);                  /* lea eax, [ebp-0x408] */
            ii(0x1010_8d05, 5); call(Definitions.sys_strstr, 0x7_0306); /* call 0x10179010 */
            ii(0x1010_8d0a, 6); mov(memd[ss, ebp - 0x40c], eax);        /* mov [ebp-0x40c], eax */
            ii(0x1010_8d10, 7); cmp(memd[ss, ebp - 0x40c], 0);          /* cmp dword [ebp-0x40c], 0x0 */
            ii(0x1010_8d17, 6); if(jz(0x1010_8da9, 0x8c)) goto l_0x1010_8da9; /* jz 0x10108da9 */
            ii(0x1010_8d1d, 6); mov(eax, memd[ss, ebp - 0x40c]);        /* mov eax, [ebp-0x40c] */
            ii(0x1010_8d23, 3); mov(memb[ds, eax], 0);                  /* mov byte [eax], 0x0 */
            ii(0x1010_8d26, 6); lea(edx, ebp - 0x408);                  /* lea edx, [ebp-0x408] */
            ii(0x1010_8d2c, 6); lea(eax, ebp - 0x20c);                  /* lea eax, [ebp-0x20c] */
            ii(0x1010_8d32, 5); call(Definitions.sys_strcpy, 0x5_d198); /* call 0x10165ecf */
            ii(0x1010_8d37, 5); mov(edx, StringDefinitions.Name2);      /* mov edx, 0x101a4574 */
            ii(0x1010_8d3c, 6); lea(eax, ebp - 0x20c);                  /* lea eax, [ebp-0x20c] */
            ii(0x1010_8d42, 5); call(Definitions.sys_strcasecmp, 0x5_d3e9); /* call 0x10166130 */
            ii(0x1010_8d47, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_8d49, 2); if(jz(0x1010_8d5f, 0x14)) goto l_0x1010_8d5f; /* jz 0x10108d5f */
            ii(0x1010_8d4b, 5); mov(edx, StringDefinitions.Text2);      /* mov edx, 0x101a4579 */
            ii(0x1010_8d50, 6); lea(eax, ebp - 0x20c);                  /* lea eax, [ebp-0x20c] */
            ii(0x1010_8d56, 5); call(Definitions.sys_strcasecmp, 0x5_d3d5); /* call 0x10166130 */
            ii(0x1010_8d5b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_8d5d, 2); if(jnz(0x1010_8d61, 0x2)) goto l_0x1010_8d61; /* jnz 0x10108d61 */
        l_0x1010_8d5f:
            ii(0x1010_8d5f, 2); jmp(0x1010_8da4, 0x43); goto l_0x1010_8da4; /* jmp 0x10108da4 */
        l_0x1010_8d61:
            ii(0x1010_8d61, 5); mov(edx, StringDefinitions.Control41);  /* mov edx, 0x101a457e */
            ii(0x1010_8d66, 6); lea(eax, ebp - 0x20c);                  /* lea eax, [ebp-0x20c] */
            ii(0x1010_8d6c, 5); call(Definitions.sys_strcat, 0x5_d1c0); /* call 0x10165f31 */
            ii(0x1010_8d71, 6); inc(memd[ss, ebp - 0x40c]);             /* inc dword [ebp-0x40c] */
            ii(0x1010_8d77, 6); mov(edx, memd[ss, ebp - 0x40c]);        /* mov edx, [ebp-0x40c] */
            ii(0x1010_8d7d, 6); lea(eax, ebp - 0x20c);                  /* lea eax, [ebp-0x20c] */
            ii(0x1010_8d83, 5); call(Definitions.sys_strcat, 0x5_d1a9); /* call 0x10165f31 */
            ii(0x1010_8d88, 5); mov(ecx, 0xa2);                         /* mov ecx, 0xa2 */
            ii(0x1010_8d8d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_8d90, 3); inc(memd[ss, ebp - 0x8]);               /* inc dword [ebp-0x8] */
            ii(0x1010_8d93, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1010_8d96, 6); lea(edx, ebp - 0x20c);                  /* lea edx, [ebp-0x20c] */
            ii(0x1010_8d9c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_8d9f, 5); call(0x1010_8aa1, -0x303);              /* call 0x10108aa1 */
        l_0x1010_8da4:
            ii(0x1010_8da4, 5); jmp(0x1010_8cd7, -0xd2); goto l_0x1010_8cd7; /* jmp 0x10108cd7 */
        l_0x1010_8da9:
            ii(0x1010_8da9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_8dac, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_8dae, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x1010_8db1, 5); call(Definitions.sys_display_draw_0, 0x5_e6ce); /* call 0x10167484 */
            ii(0x1010_8db6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_8db8, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_8db9, 1); pop(edi);                               /* pop edi */
            ii(0x1010_8dba, 1); pop(esi);                               /* pop esi */
            ii(0x1010_8dbb, 1); pop(edx);                               /* pop edx */
            ii(0x1010_8dbc, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_8dbd, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_8dbe, 1); ret();                                  /* ret */
        }
    }
}
