using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a4a621a3-5b03-4f96-b4fd-5c4dbf2dc203")]
        public void Method_100c_7f78()
        {
            ii(0x100c_7f78, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100c_7f7d, 5); calld(Definitions.sys_check_available_stack_size, 0x9_ddd0); /* call 0x10165d52 */
            ii(0x100c_7f82, 1); pushd(esi);                             /* push esi */
            ii(0x100c_7f83, 1); pushd(edi);                             /* push edi */
            ii(0x100c_7f84, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_7f85, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_7f87, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100c_7f8d, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_7f90, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x100c_7f93, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100c_7f96, 3); mov(memd_a32[ss, ebp - 0xc], ecx);      /* mov [ebp-0xc], ecx */
            ii(0x100c_7f99, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_7f9c, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x100c_7f9f, 3); shl(ebx, 0x2);                          /* shl ebx, 0x2 */
            ii(0x100c_7fa2, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_7fa5, 3); mov(edx, memd_a32[ds, eax + 0x1f]);     /* mov edx, [eax+0x1f] */
            ii(0x100c_7fa8, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x100c_7faa, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_7fad, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_7faf, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_7fb2, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x100c_7fb4, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_7fb6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_7fb8, 2); mov(dl, memb_a32[ds, eax]);             /* mov dl, [eax] */
            ii(0x100c_7fba, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_7fbd, 3); mov(eax, memd_a32[ds, eax + 0x5]);      /* mov eax, [eax+0x5] */
            ii(0x100c_7fc0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_7fc3, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_7fc5, 2); if(jzd(0x100c_7fd0, 0x9)) goto l_0x100c_7fd0; /* jz 0x100c7fd0 */
            ii(0x100c_7fc7, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x100c_7fcb, 5); jmpd(0x100c_808d, 0xbd); goto l_0x100c_808d; /* jmp 0x100c808d */
        l_0x100c_7fd0:
            ii(0x100c_7fd0, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100c_7fd4, 2); if(jzd(0x100c_8003, 0x2d)) goto l_0x100c_8003; /* jz 0x100c8003 */
            ii(0x100c_7fd6, 5); mov(eax, 0x7);                          /* mov eax, 0x7 */
            ii(0x100c_7fdb, 5); calld(0x1007_5fdc, -0x5_2004);          /* call 0x10075fdc */
            ii(0x100c_7fe0, 5); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100c_7fe5, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100c_7fe8, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x100c_7fec, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_7fef, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x100c_7ff1, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_7ff4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_7ff7, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_7ffa, 5); calld(0x100c_7eaa, -0x155);             /* call 0x100c7eaa */
            ii(0x100c_7fff, 2); test(al, al);                           /* test al, al */
            ii(0x100c_8001, 2); if(jnzd(0x100c_8005, 0x2)) goto l_0x100c_8005; /* jnz 0x100c8005 */
        l_0x100c_8003:
            ii(0x100c_8003, 2); jmpd(0x100c_800e, 0x9); goto l_0x100c_800e; /* jmp 0x100c800e */
        l_0x100c_8005:
            ii(0x100c_8005, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x100c_8009, 5); jmpd(0x100c_808d, 0x7f); goto l_0x100c_808d; /* jmp 0x100c808d */
        l_0x100c_800e:
            ii(0x100c_800e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_8011, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100c_8014, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100c_8017, 2); jmpd(0x100c_801f, 0x6); goto l_0x100c_801f; /* jmp 0x100c801f */
        l_0x100c_8019:
            ii(0x100c_8019, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100c_801c, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
        l_0x100c_801f:
            ii(0x100c_801f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_8022, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_8025, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100c_8029, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100c_802c, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_802e, 2); if(jged(0x100c_8089, 0x59)) goto l_0x100c_8089; /* jge 0x100c8089 */
            ii(0x100c_8030, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_8033, 4); mov(ax, memw_a32[ds, eax + 0x2]);       /* mov ax, [eax+0x2] */
            ii(0x100c_8037, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100c_803a, 2); jmpd(0x100c_8042, 0x6); goto l_0x100c_8042; /* jmp 0x100c8042 */
        l_0x100c_803c:
            ii(0x100c_803c, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100c_803f, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
        l_0x100c_8042:
            ii(0x100c_8042, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_8045, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_8047, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_804a, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x100c_804e, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100c_8051, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_8053, 2); if(jged(0x100c_8087, 0x32)) goto l_0x100c_8087; /* jge 0x100c8087 */
            ii(0x100c_8055, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100c_8059, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_805c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_805e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_8061, 3); mov(eax, memd_a32[ds, eax + 0x1f]);     /* mov eax, [eax+0x1f] */
            ii(0x100c_8064, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_8066, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x100c_806a, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_806c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_806e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_8070, 2); mov(dl, memb_a32[ds, eax]);             /* mov dl, [eax] */
            ii(0x100c_8072, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_8075, 3); mov(eax, memd_a32[ds, eax + 0x5]);      /* mov eax, [eax+0x5] */
            ii(0x100c_8078, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_807b, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_807d, 2); if(jzd(0x100c_8085, 0x6)) goto l_0x100c_8085; /* jz 0x100c8085 */
            ii(0x100c_807f, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x100c_8083, 2); jmpd(0x100c_808d, 0x8); goto l_0x100c_808d; /* jmp 0x100c808d */
        l_0x100c_8085:
            ii(0x100c_8085, 2); jmpd(0x100c_803c, -0x4b); goto l_0x100c_803c; /* jmp 0x100c803c */
        l_0x100c_8087:
            ii(0x100c_8087, 2); jmpd(0x100c_8019, -0x70); goto l_0x100c_8019; /* jmp 0x100c8019 */
        l_0x100c_8089:
            ii(0x100c_8089, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
        l_0x100c_808d:
            ii(0x100c_808d, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x100c_8090, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_8092, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_8093, 1); popd(edi);                              /* pop edi */
            ii(0x100c_8094, 1); popd(esi);                              /* pop esi */
            ii(0x100c_8095, 1); retd(); return;                         /* ret */
        }
    }
}
