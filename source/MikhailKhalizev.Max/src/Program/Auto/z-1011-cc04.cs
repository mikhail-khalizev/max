using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_cc04-20e7eabd")]
        public void Method_1011_cc04()
        {
            ii(0x1011_cc04, 5); push(0x5c);                             /* push 0x5c */
            ii(0x1011_cc09, 5); call(Definitions.sys_check_available_stack_size, 0x4_9144); /* call 0x10165d52 */
            ii(0x1011_cc0e, 1); push(ebx);                              /* push ebx */
            ii(0x1011_cc0f, 1); push(ecx);                              /* push ecx */
            ii(0x1011_cc10, 1); push(esi);                              /* push esi */
            ii(0x1011_cc11, 1); push(edi);                              /* push edi */
            ii(0x1011_cc12, 1); push(ebp);                              /* push ebp */
            ii(0x1011_cc13, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_cc15, 6); sub(esp, 0x40);                         /* sub esp, 0x40 */
            ii(0x1011_cc1b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_cc1e, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_cc21, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1011_cc24, 5); call(Definitions.my_ctor_0x101b_4184, -0xa_6139); /* call 0x10076af0 */
            ii(0x1011_cc29, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1011_cc2c, 5); call(Definitions.my_ctor_0x101b_4184, -0xa_6141); /* call 0x10076af0 */
            ii(0x1011_cc31, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_cc34, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1011_cc37, 5); call(Definitions.my_3_get_count, -0x9_17bc); /* call 0x1008b480 */
            ii(0x1011_cc3c, 1); cwde();                                 /* cwde */
            ii(0x1011_cc3d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_cc3f, 2); if(jnz(0x1011_cc4a, 0x9)) goto l_0x1011_cc4a; /* jnz 0x1011cc4a */
            ii(0x1011_cc41, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1011_cc45, 5); jmp(0x1011_ce1b, 0x1d1); goto l_0x1011_ce1b; /* jmp 0x1011ce1b */
        l_0x1011_cc4a:
            ii(0x1011_cc4a, 6); inc(memd[ds, 0x101c_52e8]);             /* inc dword [0x101c52e8] */
            ii(0x1011_cc50, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_cc53, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1011_cc56, 5); call(Definitions.my_3_get_count, -0x9_17db); /* call 0x1008b480 */
            ii(0x1011_cc5b, 1); dec(eax);                               /* dec eax */
            ii(0x1011_cc5c, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_cc5f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_cc62, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1011_cc65, 5); call(0x1012_0548, 0x38de);              /* call 0x10120548 */
            ii(0x1011_cc6a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_cc6c, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1011_cc6f, 5); call(0x1008_8b44, -0x9_4130);           /* call 0x10088b44 */
            ii(0x1011_cc74, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_cc77, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1011_cc7a, 5); call(Definitions.my_3_get_count, -0x9_17ff); /* call 0x1008b480 */
            ii(0x1011_cc7f, 1); dec(eax);                               /* dec eax */
            ii(0x1011_cc80, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_cc83, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_cc86, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1011_cc89, 5); call(0x100c_db14, -0x4_f17a);           /* call 0x100cdb14 */
            ii(0x1011_cc8e, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x1011_cc92, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1011_cc95, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_cc98, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1011_cc9a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_cc9c, 4); movsx(edx, memw[ss, ebp - 0x2e]);       /* movsx edx, word [ebp-0x2e] */
            ii(0x1011_cca0, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1011_cca2, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1011_cca4, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_cca6, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1011_cca9, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_ccac, 4); movsx(ecx, memw[ss, ebp - 0x10]);       /* movsx ecx, word [ebp-0x10] */
            ii(0x1011_ccb0, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_ccb3, 3); add(edx, 0x1e);                         /* add edx, 0x1e */
            ii(0x1011_ccb6, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1011_ccb9, 5); call(0x1007_5e64, -0xa_6e5a);           /* call 0x10075e64 */
            ii(0x1011_ccbe, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1011_ccc0, 3); lea(edx, ebp - 0x30);                   /* lea edx, [ebp-0x30] */
            ii(0x1011_ccc3, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1011_ccc6, 5); call(0x1007_5e64, -0xa_6e67);           /* call 0x10075e64 */
            ii(0x1011_cccb, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_cccd, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ccd0, 5); call(0x1011_c936, -0x39f);              /* call 0x1011c936 */
            ii(0x1011_ccd5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ccd8, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_ccda, 3); mov(bl, memb[ds, eax + 0x22]);          /* mov bl, [eax+0x22] */
            ii(0x1011_ccdd, 3); lea(edx, ebp - 0x30);                   /* lea edx, [ebp-0x30] */
            ii(0x1011_cce0, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1011_cce3, 5); call(0x1007_5e64, -0xa_6e84);           /* call 0x10075e64 */
            ii(0x1011_cce8, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1011_ccea, 3); lea(edx, ebp - 0x30);                   /* lea edx, [ebp-0x30] */
            ii(0x1011_cced, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1011_ccf0, 5); call(0x1007_5e64, -0xa_6e91);           /* call 0x10075e64 */
            ii(0x1011_ccf5, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1011_ccf7, 5); call(0x1011_bf10, -0xdec);              /* call 0x1011bf10 */
            ii(0x1011_ccfc, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_ccff, 9); mov(memw[ds, 0x101b_afd0], 0x3);        /* mov word [0x101bafd0], 0x3 */
            ii(0x1011_cd08, 7); mov(memd[ss, ebp - 0x1c], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1011_cd0f, 2); jmp(0x1011_cd17, 0x6); goto l_0x1011_cd17; /* jmp 0x1011cd17 */
        l_0x1011_cd11:
            ii(0x1011_cd11, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1011_cd14, 3); inc(memd[ss, ebp - 0x1c]);              /* inc dword [ebp-0x1c] */
        l_0x1011_cd17:
            ii(0x1011_cd17, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1011_cd1b, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1011_cd1e, 6); if(jge(0x1011_ce17, 0xf3)) goto l_0x1011_ce17; /* jge 0x1011ce17 */
            ii(0x1011_cd24, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1011_cd28, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1011_cd2b, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1011_cd2e, 7); add(ax, memw[ds, edx + 0x101c_5348]);   /* add ax, [edx+0x101c5348] */
            ii(0x1011_cd35, 4); mov(memw[ss, ebp - 0x34], ax);          /* mov [ebp-0x34], ax */
            ii(0x1011_cd39, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1011_cd3d, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1011_cd40, 3); mov(eax, memd[ss, ebp - 0x2e]);         /* mov eax, [ebp-0x2e] */
            ii(0x1011_cd43, 7); add(ax, memw[ds, edx + 0x101c_534a]);   /* add ax, [edx+0x101c534a] */
            ii(0x1011_cd4a, 4); mov(memw[ss, ebp - 0x32], ax);          /* mov [ebp-0x32], ax */
            ii(0x1011_cd4e, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x1011_cd52, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1011_cd54, 2); if(jl(0x1011_cd62, 0xc)) goto l_0x1011_cd62; /* jl 0x1011cd62 */
            ii(0x1011_cd56, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1011_cd59, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x1011_cd60, 2); if(jl(0x1011_cd64, 0x2)) goto l_0x1011_cd64; /* jl 0x1011cd64 */
        l_0x1011_cd62:
            ii(0x1011_cd62, 2); jmp(0x1011_cd6c, 0x8); goto l_0x1011_cd6c; /* jmp 0x1011cd6c */
        l_0x1011_cd64:
            ii(0x1011_cd64, 4); movsx(eax, memw[ss, ebp - 0x32]);       /* movsx eax, word [ebp-0x32] */
            ii(0x1011_cd68, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_cd6a, 2); if(jge(0x1011_cd6e, 0x2)) goto l_0x1011_cd6e; /* jge 0x1011cd6e */
        l_0x1011_cd6c:
            ii(0x1011_cd6c, 2); jmp(0x1011_cd7a, 0xc); goto l_0x1011_cd7a; /* jmp 0x1011cd7a */
        l_0x1011_cd6e:
            ii(0x1011_cd6e, 3); mov(eax, memd[ss, ebp - 0x32]);         /* mov eax, [ebp-0x32] */
            ii(0x1011_cd71, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x1011_cd78, 2); if(jl(0x1011_cd7c, 0x2)) goto l_0x1011_cd7c; /* jl 0x1011cd7c */
        l_0x1011_cd7a:
            ii(0x1011_cd7a, 2); jmp(0x1011_cd9c, 0x20); goto l_0x1011_cd9c; /* jmp 0x1011cd9c */
        l_0x1011_cd7c:
            ii(0x1011_cd7c, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x1011_cd80, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1011_cd83, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_cd86, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1011_cd88, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_cd8a, 4); movsx(edx, memw[ss, ebp - 0x32]);       /* movsx edx, word [ebp-0x32] */
            ii(0x1011_cd8e, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1011_cd90, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1011_cd92, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_cd94, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_cd97, 3); cmp(ax, memw[ds, edx]);                 /* cmp ax, [edx] */
            ii(0x1011_cd9a, 2); if(jl(0x1011_cd9e, 0x2)) goto l_0x1011_cd9e; /* jl 0x1011cd9e */
        l_0x1011_cd9c:
            ii(0x1011_cd9c, 2); jmp(0x1011_ce12, 0x74); goto l_0x1011_ce12; /* jmp 0x1011ce12 */
        l_0x1011_cd9e:
            ii(0x1011_cd9e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_cda1, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_cda3, 3); mov(bl, memb[ds, eax + 0x22]);          /* mov bl, [eax+0x22] */
            ii(0x1011_cda6, 3); lea(edx, ebp - 0x34);                   /* lea edx, [ebp-0x34] */
            ii(0x1011_cda9, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1011_cdac, 5); call(0x1007_5e64, -0xa_6f4d);           /* call 0x10075e64 */
            ii(0x1011_cdb1, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1011_cdb3, 3); lea(edx, ebp - 0x30);                   /* lea edx, [ebp-0x30] */
            ii(0x1011_cdb6, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1011_cdb9, 5); call(0x1007_5e64, -0xa_6f5a);           /* call 0x10075e64 */
            ii(0x1011_cdbe, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1011_cdc0, 5); call(0x1011_bf10, -0xeb5);              /* call 0x1011bf10 */
            ii(0x1011_cdc5, 1); cwde();                                 /* cwde */
            ii(0x1011_cdc6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_cdc8, 2); if(jle(0x1011_ce12, 0x48)) goto l_0x1011_ce12; /* jle 0x1011ce12 */
            ii(0x1011_cdca, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1011_cdcd, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_cdd0, 6); test(memw[ss, ebp - 0x1c], 0x1);        /* test word [ebp-0x1c], 0x1 */
            ii(0x1011_cdd6, 2); if(jz(0x1011_cdeb, 0x13)) goto l_0x1011_cdeb; /* jz 0x1011cdeb */
            ii(0x1011_cdd8, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x1011_cddc, 3); lea(edx, edx + edx * 2);                /* lea edx, [edx+edx*2] */
            ii(0x1011_cddf, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_cde1, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_cde4, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1011_cde6, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1011_cde8, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
        l_0x1011_cdeb:
            ii(0x1011_cdeb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_cdee, 1); push(eax);                              /* push eax */
            ii(0x1011_cdef, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1011_cdf1, 3); mov(cl, memb[ss, ebp - 0x1c]);          /* mov cl, [ebp-0x1c] */
            ii(0x1011_cdf4, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_cdf7, 3); add(eax, memd[ss, ebp - 0x10]);         /* add eax, [ebp-0x10] */
            ii(0x1011_cdfa, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1011_cdfd, 3); lea(edx, ebp - 0x34);                   /* lea edx, [ebp-0x34] */
            ii(0x1011_ce00, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1011_ce03, 5); call(0x1007_5e64, -0xa_6fa4);           /* call 0x10075e64 */
            ii(0x1011_ce08, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_ce0a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ce0d, 5); call(0x1011_c2ed, -0xb25);              /* call 0x1011c2ed */
        l_0x1011_ce12:
            ii(0x1011_ce12, 5); jmp(0x1011_cd11, -0x106); goto l_0x1011_cd11; /* jmp 0x1011cd11 */
        l_0x1011_ce17:
            ii(0x1011_ce17, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
        l_0x1011_ce1b:
            ii(0x1011_ce1b, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1011_ce1e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_ce20, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_ce21, 1); pop(edi);                               /* pop edi */
            ii(0x1011_ce22, 1); pop(esi);                               /* pop esi */
            ii(0x1011_ce23, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_ce24, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_ce25, 1); ret();                                  /* ret */
        }
    }
}
