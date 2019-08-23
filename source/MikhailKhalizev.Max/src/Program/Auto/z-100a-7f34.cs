using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_7f34-9e127756")]
        public void Method_100a_7f34()
        {
            ii(0x100a_7f34, 5); push(0x94);                             /* push 0x94 */
            ii(0x100a_7f39, 5); call(Definitions.sys_check_available_stack_size, 0xb_de14); /* call 0x10165d52 */
            ii(0x100a_7f3e, 1); push(ecx);                              /* push ecx */
            ii(0x100a_7f3f, 1); push(esi);                              /* push esi */
            ii(0x100a_7f40, 1); push(edi);                              /* push edi */
            ii(0x100a_7f41, 1); push(ebp);                              /* push ebp */
            ii(0x100a_7f42, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_7f44, 6); sub(esp, 0x7c);                         /* sub esp, 0x7c */
            ii(0x100a_7f4a, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_7f4d, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100a_7f50, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100a_7f53, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_7f56, 3); mov(eax, memd[ds, eax + 0x4]);          /* mov eax, [eax+0x4] */
            ii(0x100a_7f59, 5); call(0x100a_2edb, -0x5083);             /* call 0x100a2edb */
            ii(0x100a_7f5e, 2); test(al, al);                           /* test al, al */
            ii(0x100a_7f60, 6); if(jz(0x100a_83e3, 0x47d)) goto l_0x100a_83e3; /* jz 0x100a83e3 */
            ii(0x100a_7f66, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_7f69, 3); mov(ecx, memd[ds, eax + 0x52]);         /* mov ecx, [eax+0x52] */
            ii(0x100a_7f6c, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_7f6f, 3); mov(ebx, memd[ds, eax + 0x7]);          /* mov ebx, [eax+0x7] */
            ii(0x100a_7f72, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_7f75, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_7f78, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x100a_7f7a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_7f7d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_7f80, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100a_7f83, 5); call(0x1007_388b, -0x3_46fd);           /* call 0x1007388b */
            ii(0x100a_7f88, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
            ii(0x100a_7f8b, 4); cmp(memd[ss, ebp - 0x48], 0);           /* cmp dword [ebp-0x48], 0x0 */
            ii(0x100a_7f8f, 6); if(jz(0x100a_801e, 0x89)) goto l_0x100a_801e; /* jz 0x100a801e */
            ii(0x100a_7f95, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x100a_7f98, 3); mov(al, memb[ds, eax + 0x50]);          /* mov al, [eax+0x50] */
            ii(0x100a_7f9b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_7fa0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_7fa2, 2); if(jle(0x100a_7fbf, 0x1b)) goto l_0x100a_7fbf; /* jle 0x100a7fbf */
            ii(0x100a_7fa4, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_7fa7, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x100a_7faa, 5); call(0x1007_5e64, -0x3_214b);           /* call 0x10075e64 */
            ii(0x100a_7faf, 3); mov(ebx, memd[ss, ebp - 0x48]);         /* mov ebx, [ebp-0x48] */
            ii(0x100a_7fb2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_7fb4, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_7fb6, 5); call(0x100a_b5f3, 0x3638);              /* call 0x100ab5f3 */
            ii(0x100a_7fbb, 2); test(al, al);                           /* test al, al */
            ii(0x100a_7fbd, 2); if(jnz(0x100a_7fc1, 0x2)) goto l_0x100a_7fc1; /* jnz 0x100a7fc1 */
        l_0x100a_7fbf:
            ii(0x100a_7fbf, 2); jmp(0x100a_7fd1, 0x10); goto l_0x100a_7fd1; /* jmp 0x100a7fd1 */
        l_0x100a_7fc1:
            ii(0x100a_7fc1, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_7fc4, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_7fc7, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x100a_7fca, 5); call(0x100a_aa64, 0x2a95);              /* call 0x100aaa64 */
            ii(0x100a_7fcf, 2); jmp(0x100a_8019, 0x48); goto l_0x100a_8019; /* jmp 0x100a8019 */
        l_0x100a_7fd1:
            ii(0x100a_7fd1, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x100a_7fd4, 4); cmp(memb[ds, eax + 0x3d], 0);           /* cmp byte [eax+0x3d], 0x0 */
            ii(0x100a_7fd8, 2); if(jz(0x100a_7fe3, 0x9)) goto l_0x100a_7fe3; /* jz 0x100a7fe3 */
            ii(0x100a_7fda, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x100a_7fdd, 4); cmp(memb[ds, eax + 0x3d], 0xc);         /* cmp byte [eax+0x3d], 0xc */
            ii(0x100a_7fe1, 2); if(jnz(0x100a_800b, 0x28)) goto l_0x100a_800b; /* jnz 0x100a800b */
        l_0x100a_7fe3:
            ii(0x100a_7fe3, 3); mov(ecx, memd[ss, ebp - 0x48]);         /* mov ecx, [ebp-0x48] */
            ii(0x100a_7fe6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_7fe9, 2); mov(ebx, memd[ds, eax]);                /* mov ebx, [eax] */
            ii(0x100a_7feb, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_7fee, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_7ff1, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x100a_7ff4, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x100a_7ff7, 5); call(0x100a_738b, -0xc71);              /* call 0x100a738b */
            ii(0x100a_7ffc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_7ffe, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_8001, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100a_8004, 5); call(0x100a_a73c, 0x2733);              /* call 0x100aa73c */
            ii(0x100a_8009, 2); jmp(0x100a_8019, 0xe); goto l_0x100a_8019; /* jmp 0x100a8019 */
        l_0x100a_800b:
            ii(0x100a_800b, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_800e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_8011, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x100a_8014, 5); call(0x100a_aa64, 0x2a4b);              /* call 0x100aaa64 */
        l_0x100a_8019:
            ii(0x100a_8019, 5); jmp(0x100a_83e3, 0x3c5); goto l_0x100a_83e3; /* jmp 0x100a83e3 */
        l_0x100a_801e:
            ii(0x100a_801e, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100a_8023, 1); push(eax);                              /* push eax */
            ii(0x100a_8024, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_8027, 2); mov(ecx, memd[ds, eax]);                /* mov ecx, [eax] */
            ii(0x100a_8029, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100a_802c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_802f, 3); movsx(ebx, memw[ds, eax]);              /* movsx ebx, word [eax] */
            ii(0x100a_8032, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_8035, 3); mov(edx, memd[ds, eax + 0x7]);          /* mov edx, [eax+0x7] */
            ii(0x100a_8038, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_803b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_803e, 3); mov(eax, memd[ds, eax + 0x4]);          /* mov eax, [eax+0x4] */
            ii(0x100a_8041, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100a_8044, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_8047, 5); call(0x1007_02b9, -0x3_7d93);           /* call 0x100702b9 */
            ii(0x100a_804c, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x100a_804f, 6); if(jz(0x100a_83e3, 0x38e)) goto l_0x100a_83e3; /* jz 0x100a83e3 */
            ii(0x100a_8055, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x100a_8059, 7); mov(memd[ss, ebp - 0x1c], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100a_8060, 2); jmp(0x100a_8068, 0x6); goto l_0x100a_8068; /* jmp 0x100a8068 */
        l_0x100a_8062:
            ii(0x100a_8062, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100a_8065, 3); inc(memd[ss, ebp - 0x1c]);              /* inc dword [ebp-0x1c] */
        l_0x100a_8068:
            ii(0x100a_8068, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_806b, 3); add(eax, 0x2e);                         /* add eax, 0x2e */
            ii(0x100a_806e, 5); call(Definitions.my_3_get_count, -0x1_cbf3); /* call 0x1008b480 */
            ii(0x100a_8073, 4); cmp(ax, memw[ss, ebp - 0x1c]);          /* cmp ax, [ebp-0x1c] */
            ii(0x100a_8077, 2); if(jle(0x100a_80ad, 0x34)) goto l_0x100a_80ad; /* jle 0x100a80ad */
            ii(0x100a_8079, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x100a_807c, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x100a_8080, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_8083, 3); add(eax, 0x2e);                         /* add eax, 0x2e */
            ii(0x100a_8086, 5); call(0x100a_aa28, 0x299d);              /* call 0x100aaa28 */
            ii(0x100a_808b, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100a_808d, 5); call(0x100a_b434, 0x33a2);              /* call 0x100ab434 */
            ii(0x100a_8092, 2); test(al, al);                           /* test al, al */
            ii(0x100a_8094, 2); if(jz(0x100a_80ab, 0x15)) goto l_0x100a_80ab; /* jz 0x100a80ab */
            ii(0x100a_8096, 4); mov(memb[ss, ebp - 0x14], 0x1);         /* mov byte [ebp-0x14], 0x1 */
            ii(0x100a_809a, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x100a_809e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_80a1, 3); add(eax, 0x2e);                         /* add eax, 0x2e */
            ii(0x100a_80a4, 5); call(0x100c_db14, 0x2_5a6b);            /* call 0x100cdb14 */
            ii(0x100a_80a9, 2); jmp(0x100a_80ad, 0x2); goto l_0x100a_80ad; /* jmp 0x100a80ad */
        l_0x100a_80ab:
            ii(0x100a_80ab, 2); jmp(0x100a_8062, -0x4b); goto l_0x100a_8062; /* jmp 0x100a8062 */
        l_0x100a_80ad:
            ii(0x100a_80ad, 4); cmp(memb[ss, ebp - 0x14], 0);           /* cmp byte [ebp-0x14], 0x0 */
            ii(0x100a_80b1, 2); if(jz(0x100a_80e1, 0x2e)) goto l_0x100a_80e1; /* jz 0x100a80e1 */
            ii(0x100a_80b3, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_80b6, 3); mov(ecx, memd[ds, eax + 0x4]);          /* mov ecx, [eax+0x4] */
            ii(0x100a_80b9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_80bc, 2); mov(ebx, memd[ds, eax]);                /* mov ebx, [eax] */
            ii(0x100a_80be, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_80c1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_80c4, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x100a_80c7, 3); lea(eax, ebp - 0x60);                   /* lea eax, [ebp-0x60] */
            ii(0x100a_80ca, 5); call(0x100a_738b, -0xd44);              /* call 0x100a738b */
            ii(0x100a_80cf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_80d1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_80d4, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100a_80d7, 5); call(0x100a_a73c, 0x2660);              /* call 0x100aa73c */
            ii(0x100a_80dc, 5); jmp(0x100a_83e3, 0x302); goto l_0x100a_83e3; /* jmp 0x100a83e3 */
        l_0x100a_80e1:
            ii(0x100a_80e1, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_80e4, 3); mov(edx, memd[ds, eax + 0x4]);          /* mov edx, [eax+0x4] */
            ii(0x100a_80e7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_80e9, 3); mov(al, memb[ds, edx + 0x4d]);          /* mov al, [edx+0x4d] */
            ii(0x100a_80ec, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100a_80ef, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_80f2, 3); mov(eax, memd[ds, eax + 0x4]);          /* mov eax, [eax+0x4] */
            ii(0x100a_80f5, 5); call(0x100a_9d1a, 0x1c20);              /* call 0x100a9d1a */
            ii(0x100a_80fa, 3); mov(memb[ss, ebp - 0x10], al);          /* mov [ebp-0x10], al */
            ii(0x100a_80fd, 4); cmp(memb[ss, ebp - 0x10], 0x3);         /* cmp byte [ebp-0x10], 0x3 */
            ii(0x100a_8101, 2); if(jnz(0x100a_810a, 0x7)) goto l_0x100a_810a; /* jnz 0x100a810a */
            ii(0x100a_8103, 7); mov(memd[ss, ebp - 0x18], 0x1);         /* mov dword [ebp-0x18], 0x1 */
        l_0x100a_810a:
            ii(0x100a_810a, 4); cmp(memb[ss, ebp - 0x10], 0);           /* cmp byte [ebp-0x10], 0x0 */
            ii(0x100a_810e, 2); if(jle(0x100a_814e, 0x3e)) goto l_0x100a_814e; /* jle 0x100a814e */
            ii(0x100a_8110, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100a_8115, 1); push(eax);                              /* push eax */
            ii(0x100a_8116, 4); movsx(ecx, memb[ss, ebp - 0x10]);       /* movsx ecx, byte [ebp-0x10] */
            ii(0x100a_811a, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_811d, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100a_8120, 5); call(0x1007_5e64, -0x3_22c1);           /* call 0x10075e64 */
            ii(0x100a_8125, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100a_8127, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_812a, 3); mov(edx, memd[ds, eax + 0x4]);          /* mov edx, [eax+0x4] */
            ii(0x100a_812d, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_8130, 3); mov(eax, memd[ds, eax + 0x7]);          /* mov eax, [eax+0x7] */
            ii(0x100a_8133, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_8136, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x100a_813c, 5); mov(esi, 0x101c_31c4);                  /* mov esi, 0x101c31c4 */
            ii(0x100a_8141, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x100a_8143, 5); call(0x100c_20df, 0x1_9f97);            /* call 0x100c20df */
            ii(0x100a_8148, 4); cmp(ax, memw[ss, ebp - 0x18]);          /* cmp ax, [ebp-0x18] */
            ii(0x100a_814c, 2); if(jge(0x100a_8150, 0x2)) goto l_0x100a_8150; /* jge 0x100a8150 */
        l_0x100a_814e:
            ii(0x100a_814e, 2); jmp(0x100a_8155, 0x5); goto l_0x100a_8155; /* jmp 0x100a8155 */
        l_0x100a_8150:
            ii(0x100a_8150, 5); jmp(0x100a_83e3, 0x28e); goto l_0x100a_83e3; /* jmp 0x100a83e3 */
        l_0x100a_8155:
            ii(0x100a_8155, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_8158, 3); mov(edx, memd[ds, edx + 0x4]);          /* mov edx, [edx+0x4] */
            ii(0x100a_815b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_815e, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_8161, 5); call(0x1007_6630, -0x3_1b36);           /* call 0x10076630 */
            ii(0x100a_8166, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_8169, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_816c, 5); call(0x1007_6574, -0x3_1bfd);           /* call 0x10076574 */
            ii(0x100a_8171, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_8174, 3); mov(dx, memw[ds, edx]);                 /* mov dx, [edx] */
            ii(0x100a_8177, 4); mov(memw[ds, eax + 0x41], dx);          /* mov [eax+0x41], dx */
            ii(0x100a_817b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_817e, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_8181, 5); call(0x1007_6574, -0x3_1c12);           /* call 0x10076574 */
            ii(0x100a_8186, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_8189, 4); mov(dx, memw[ds, edx + 0x2]);           /* mov dx, [edx+0x2] */
            ii(0x100a_818d, 4); mov(memw[ds, eax + 0x43], dx);          /* mov [eax+0x43], dx */
            ii(0x100a_8191, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100a_8194, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_8197, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_819a, 5); call(0x1007_6574, -0x3_1c2b);           /* call 0x10076574 */
            ii(0x100a_819f, 5); call(0x1015_27ed, 0xa_a649);            /* call 0x101527ed */
            ii(0x100a_81a4, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_81a7, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_81aa, 5); call(0x1007_6574, -0x3_1c3b);           /* call 0x10076574 */
            ii(0x100a_81af, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_81b2, 4); mov(dx, memw[ds, edx + 0x2]);           /* mov dx, [edx+0x2] */
            ii(0x100a_81b6, 4); sub(dx, memw[ds, eax + 0x1c]);          /* sub dx, [eax+0x1c] */
            ii(0x100a_81ba, 3); movsx(ebx, dx);                         /* movsx ebx, dx */
            ii(0x100a_81bd, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_81c0, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_81c3, 5); call(0x1007_6574, -0x3_1c54);           /* call 0x10076574 */
            ii(0x100a_81c8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_81ca, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_81cd, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100a_81d0, 4); sub(ax, memw[ds, edx + 0x1a]);          /* sub ax, [edx+0x1a] */
            ii(0x100a_81d4, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_81d7, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x100a_81da, 5); call(0x1007_6aac, -0x3_1733);           /* call 0x10076aac */
            ii(0x100a_81df, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x100a_81e3, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x100a_81e6, 2); if(jl(0x100a_81f1, 0x9)) goto l_0x100a_81f1; /* jl 0x100a81f1 */
            ii(0x100a_81e8, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x100a_81ec, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100a_81ef, 2); if(jle(0x100a_81f3, 0x2)) goto l_0x100a_81f3; /* jle 0x100a81f3 */
        l_0x100a_81f1:
            ii(0x100a_81f1, 2); jmp(0x100a_81fc, 0x9); goto l_0x100a_81fc; /* jmp 0x100a81fc */
        l_0x100a_81f3:
            ii(0x100a_81f3, 4); movsx(eax, memw[ss, ebp - 0x32]);       /* movsx eax, word [ebp-0x32] */
            ii(0x100a_81f7, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x100a_81fa, 2); if(jge(0x100a_81fe, 0x2)) goto l_0x100a_81fe; /* jge 0x100a81fe */
        l_0x100a_81fc:
            ii(0x100a_81fc, 2); jmp(0x100a_8207, 0x9); goto l_0x100a_8207; /* jmp 0x100a8207 */
        l_0x100a_81fe:
            ii(0x100a_81fe, 4); movsx(eax, memw[ss, ebp - 0x32]);       /* movsx eax, word [ebp-0x32] */
            ii(0x100a_8202, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100a_8205, 2); if(jle(0x100a_820c, 0x5)) goto l_0x100a_820c; /* jle 0x100a820c */
        l_0x100a_8207:
            ii(0x100a_8207, 5); jmp(0x100a_830f, 0x103); goto l_0x100a_830f; /* jmp 0x100a830f */
        l_0x100a_820c:
            ii(0x100a_820c, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_820f, 4); mov(memb[ds, eax + 0x13], 0x4);         /* mov byte [eax+0x13], 0x4 */
            ii(0x100a_8213, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_8216, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_8219, 5); call(0x1007_6574, -0x3_1caa);           /* call 0x10076574 */
            ii(0x100a_821e, 4); test(memb[ds, eax + 0x12], 0x40);       /* test byte [eax+0x12], 0x40 */
            ii(0x100a_8222, 2); if(jz(0x100a_8240, 0x1c)) goto l_0x100a_8240; /* jz 0x100a8240 */
            ii(0x100a_8224, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_8226, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x100a_822b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_822e, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_8231, 5); call(0x1007_65d0, -0x3_1c66);           /* call 0x100765d0 */
            ii(0x100a_8236, 5); call(0x1016_3053, 0xb_ae18);            /* call 0x10163053 */
            ii(0x100a_823b, 5); jmp(0x100a_830a, 0xca); goto l_0x100a_830a; /* jmp 0x100a830a */
        l_0x100a_8240:
            ii(0x100a_8240, 5); mov(eax, 0x1c);                         /* mov eax, 0x1c */
            ii(0x100a_8245, 5); call(Definitions.sys_new, 0xb_dbb6);    /* call 0x10165e00 */
            ii(0x100a_824a, 3); mov(memd[ss, ebp - 0x64], eax);         /* mov [ebp-0x64], eax */
            ii(0x100a_824d, 3); mov(eax, memd[ss, ebp - 0x64]);         /* mov eax, [ebp-0x64] */
            ii(0x100a_8250, 3); mov(memd[ss, ebp - 0x68], eax);         /* mov [ebp-0x68], eax */
            ii(0x100a_8253, 4); cmp(memd[ss, ebp - 0x68], 0);           /* cmp dword [ebp-0x68], 0x0 */
            ii(0x100a_8257, 2); if(jz(0x100a_827a, 0x21)) goto l_0x100a_827a; /* jz 0x100a827a */
            ii(0x100a_8259, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_825c, 2); mov(ebx, memd[ds, eax]);                /* mov ebx, [eax] */
            ii(0x100a_825e, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_8261, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_8264, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x100a_8267, 3); mov(eax, memd[ss, ebp - 0x64]);         /* mov eax, [ebp-0x64] */
            ii(0x100a_826a, 5); call(Definitions.my_ctor_c20, 0x7_1ce7); /* call 0x10119f56 */
            ii(0x100a_826f, 3); mov(memd[ss, ebp - 0x6c], eax);         /* mov [ebp-0x6c], eax */
            ii(0x100a_8272, 3); mov(eax, memd[ss, ebp - 0x6c]);         /* mov eax, [ebp-0x6c] */
            ii(0x100a_8275, 3); mov(memd[ss, ebp - 0x70], eax);         /* mov [ebp-0x70], eax */
            ii(0x100a_8278, 2); jmp(0x100a_8280, 0x6); goto l_0x100a_8280; /* jmp 0x100a8280 */
        l_0x100a_827a:
            ii(0x100a_827a, 3); mov(eax, memd[ss, ebp - 0x68]);         /* mov eax, [ebp-0x68] */
            ii(0x100a_827d, 3); mov(memd[ss, ebp - 0x70], eax);         /* mov [ebp-0x70], eax */
        l_0x100a_8280:
            ii(0x100a_8280, 3); mov(edx, memd[ss, ebp - 0x70]);         /* mov edx, [ebp-0x70] */
            ii(0x100a_8283, 3); lea(eax, ebp - 0x74);                   /* lea eax, [ebp-0x74] */
            ii(0x100a_8286, 5); call(0x100a_b3b0, 0x3125);              /* call 0x100ab3b0 */
            ii(0x100a_828b, 4); movsx(ebx, memw[ss, ebp - 0x32]);       /* movsx ebx, word [ebp-0x32] */
            ii(0x100a_828f, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x100a_8293, 3); lea(eax, ebp - 0x74);                   /* lea eax, [ebp-0x74] */
            ii(0x100a_8296, 5); call(0x100a_b2e0, 0x3045);              /* call 0x100ab2e0 */
            ii(0x100a_829b, 5); call(0x1011_aca3, 0x7_2a03);            /* call 0x1011aca3 */
            ii(0x100a_82a0, 3); lea(eax, ebp - 0x74);                   /* lea eax, [ebp-0x74] */
            ii(0x100a_82a3, 5); call(0x100a_b33c, 0x3094);              /* call 0x100ab33c */
            ii(0x100a_82a8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_82aa, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_82ad, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_82b0, 5); call(0x1007_6574, -0x3_1d41);           /* call 0x10076574 */
            ii(0x100a_82b5, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x100a_82b8, 5); call(0x1007_6a34, -0x3_1889);           /* call 0x10076a34 */
            ii(0x100a_82bd, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_82c0, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_82c3, 5); call(0x1007_6574, -0x3_1d54);           /* call 0x10076574 */
            ii(0x100a_82c8, 5); call(0x1015_48ba, 0xa_c5ed);            /* call 0x101548ba */
            ii(0x100a_82cd, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x100a_82d2, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x100a_82d7, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_82da, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_82dd, 5); call(0x1007_65d0, -0x3_1d12);           /* call 0x100765d0 */
            ii(0x100a_82e2, 5); call(0x1016_3053, 0xb_ad6c);            /* call 0x10163053 */
            ii(0x100a_82e7, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x100a_82ee, 2); if(jz(0x100a_8300, 0x10)) goto l_0x100a_8300; /* jz 0x100a8300 */
            ii(0x100a_82f0, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_82f3, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_82f6, 5); call(0x1007_65d0, -0x3_1d2b);           /* call 0x100765d0 */
            ii(0x100a_82fb, 5); call(0x1012_ae8d, 0x8_2b8d);            /* call 0x1012ae8d */
        l_0x100a_8300:
            ii(0x100a_8300, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_8302, 3); lea(eax, ebp - 0x74);                   /* lea eax, [ebp-0x74] */
            ii(0x100a_8305, 5); call(0x100a_9f38, 0x1c2e);              /* call 0x100a9f38 */
        l_0x100a_830a:
            ii(0x100a_830a, 5); jmp(0x100a_83e3, 0xd4); goto l_0x100a_83e3; /* jmp 0x100a83e3 */
        l_0x100a_830f:
            ii(0x100a_830f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_8312, 4); mov(memb[ds, eax + 0x13], 0x3);         /* mov byte [eax+0x13], 0x3 */
            ii(0x100a_8316, 5); mov(eax, 0x20);                         /* mov eax, 0x20 */
            ii(0x100a_831b, 5); call(Definitions.sys_new, 0xb_dae0);    /* call 0x10165e00 */
            ii(0x100a_8320, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x100a_8323, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x100a_8326, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100a_8329, 4); cmp(memd[ss, ebp - 0x24], 0);           /* cmp dword [ebp-0x24], 0x0 */
            ii(0x100a_832d, 2); if(jz(0x100a_8361, 0x32)) goto l_0x100a_8361; /* jz 0x100a8361 */
            ii(0x100a_832f, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_8332, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100a_8335, 5); call(0x1007_5e64, -0x3_24d6);           /* call 0x10075e64 */
            ii(0x100a_833a, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100a_833c, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100a_8341, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_8344, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x100a_8347, 5); call(0x1007_65d0, -0x3_1d7c);           /* call 0x100765d0 */
            ii(0x100a_834c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_834e, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x100a_8351, 5); call(0x100a_beeb, 0x3b95);              /* call 0x100abeeb */
            ii(0x100a_8356, 3); mov(memd[ss, ebp - 0x4c], eax);         /* mov [ebp-0x4c], eax */
            ii(0x100a_8359, 3); mov(eax, memd[ss, ebp - 0x4c]);         /* mov eax, [ebp-0x4c] */
            ii(0x100a_835c, 3); mov(memd[ss, ebp - 0x78], eax);         /* mov [ebp-0x78], eax */
            ii(0x100a_835f, 2); jmp(0x100a_8367, 0x6); goto l_0x100a_8367; /* jmp 0x100a8367 */
        l_0x100a_8361:
            ii(0x100a_8361, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x100a_8364, 3); mov(memd[ss, ebp - 0x78], eax);         /* mov [ebp-0x78], eax */
        l_0x100a_8367:
            ii(0x100a_8367, 3); mov(eax, memd[ss, ebp - 0x78]);         /* mov eax, [ebp-0x78] */
            ii(0x100a_836a, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x100a_836d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_836f, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100a_8372, 5); call(0x1011_d88c, 0x7_5515);            /* call 0x1011d88c */
            ii(0x100a_8377, 5); mov(eax, 0x1f);                         /* mov eax, 0x1f */
            ii(0x100a_837c, 5); call(Definitions.sys_new, 0xb_da7f);    /* call 0x10165e00 */
            ii(0x100a_8381, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100a_8384, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100a_8387, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x100a_838a, 4); cmp(memd[ss, ebp - 0x28], 0);           /* cmp dword [ebp-0x28], 0x0 */
            ii(0x100a_838e, 2); if(jz(0x100a_83b4, 0x24)) goto l_0x100a_83b4; /* jz 0x100a83b4 */
            ii(0x100a_8390, 5); mov(eax, 0x100a_85b8);                  /* mov eax, 0x100a85b8 */
            ii(0x100a_8395, 1); push(eax);                              /* push eax */
            ii(0x100a_8396, 5); mov(ecx, 0x100a_83ea);                  /* mov ecx, 0x100a83ea */
            ii(0x100a_839b, 3); mov(ebx, memd[ss, ebp - 0x30]);         /* mov ebx, [ebp-0x30] */
            ii(0x100a_839e, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100a_83a1, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100a_83a4, 5); call(0x100a_ba72, 0x36c9);              /* call 0x100aba72 */
            ii(0x100a_83a9, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x100a_83ac, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x100a_83af, 3); mov(memd[ss, ebp - 0x7c], eax);         /* mov [ebp-0x7c], eax */
            ii(0x100a_83b2, 2); jmp(0x100a_83ba, 0x6); goto l_0x100a_83ba; /* jmp 0x100a83ba */
        l_0x100a_83b4:
            ii(0x100a_83b4, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x100a_83b7, 3); mov(memd[ss, ebp - 0x7c], eax);         /* mov [ebp-0x7c], eax */
        l_0x100a_83ba:
            ii(0x100a_83ba, 3); mov(edx, memd[ss, ebp - 0x7c]);         /* mov edx, [ebp-0x7c] */
            ii(0x100a_83bd, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100a_83c0, 5); call(0x1008_b060, -0x1_d365);           /* call 0x1008b060 */
            ii(0x100a_83c5, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100a_83c8, 5); call(0x1008_af84, -0x1_d449);           /* call 0x1008af84 */
            ii(0x100a_83cd, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_83cf, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_83d4, 5); call(0x100a_4d50, -0x3689);             /* call 0x100a4d50 */
            ii(0x100a_83d9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_83db, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100a_83de, 5); call(0x1008_8b7c, -0x1_f867);           /* call 0x10088b7c */
        l_0x100a_83e3:
            ii(0x100a_83e3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_83e5, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_83e6, 1); pop(edi);                               /* pop edi */
            ii(0x100a_83e7, 1); pop(esi);                               /* pop esi */
            ii(0x100a_83e8, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_83e9, 1); ret();                                  /* ret */
        }
    }
}
