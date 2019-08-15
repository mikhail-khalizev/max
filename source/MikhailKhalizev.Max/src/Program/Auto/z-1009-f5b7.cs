using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1117db34-e3d7-45ed-bb44-7f345c34dd47")]
        public void Method_1009_f5b7()
        {
            ii(0x1009_f5b7, 5); pushd(0x88);                            /* push 0x88 */
            ii(0x1009_f5bc, 5); calld(Definitions.sys_check_available_stack_size, 0xc_6791); /* call 0x10165d52 */
            ii(0x1009_f5c1, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_f5c2, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_f5c3, 1); pushd(esi);                             /* push esi */
            ii(0x1009_f5c4, 1); pushd(edi);                             /* push edi */
            ii(0x1009_f5c5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_f5c6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_f5c8, 6); sub(esp, 0x6c);                         /* sub esp, 0x6c */
            ii(0x1009_f5ce, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_f5d1, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_f5d4, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_f5d7, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x1009_f5da, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_f5dd, 5); calld(0x1008_b4b4, -0x1_412e);          /* call 0x1008b4b4 */
            ii(0x1009_f5e2, 2); test(al, al);                           /* test al, al */
            ii(0x1009_f5e4, 2); if(jzd(0x1009_f5ef, 0x9)) goto l_0x1009_f5ef; /* jz 0x1009f5ef */
            ii(0x1009_f5e6, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1009_f5ea, 5); jmpd(0x1009_fd5f, 0x770); goto l_0x1009_fd5f; /* jmp 0x1009fd5f */
        l_0x1009_f5ef:
            ii(0x1009_f5ef, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_f5f2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f5f5, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_f5f8, 5); calld(0x1007_6574, -0x2_9089);          /* call 0x10076574 */
            ii(0x1009_f5fd, 5); calld(0x1015_2a52, 0xb_3450);           /* call 0x10152a52 */
            ii(0x1009_f602, 2); test(al, al);                           /* test al, al */
            ii(0x1009_f604, 2); if(jnzd(0x1009_f60f, 0x9)) goto l_0x1009_f60f; /* jnz 0x1009f60f */
            ii(0x1009_f606, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1009_f60a, 5); jmpd(0x1009_fd5f, 0x750); goto l_0x1009_fd5f; /* jmp 0x1009fd5f */
        l_0x1009_f60f:
            ii(0x1009_f60f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1009_f611, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x1009_f616, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_f618, 2); if(jnzd(0x1009_f62f, 0x15)) goto l_0x1009_f62f; /* jnz 0x1009f62f */
            ii(0x1009_f61a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f61d, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_f620, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_f623, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_f625, 6); mov(dl, memb_a32[ds, 0x101c_37c8]);     /* mov dl, [0x101c37c8] */
            ii(0x1009_f62b, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_f62d, 2); if(jnzd(0x1009_f631, 0x2)) goto l_0x1009_f631; /* jnz 0x1009f631 */
        l_0x1009_f62f:
            ii(0x1009_f62f, 2); jmpd(0x1009_f63a, 0x9); goto l_0x1009_f63a; /* jmp 0x1009f63a */
        l_0x1009_f631:
            ii(0x1009_f631, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1009_f635, 5); jmpd(0x1009_fd5f, 0x725); goto l_0x1009_fd5f; /* jmp 0x1009fd5f */
        l_0x1009_f63a:
            ii(0x1009_f63a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f63d, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_f640, 5); calld(0x1007_6574, -0x2_90d1);          /* call 0x10076574 */
            ii(0x1009_f645, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x1009_f648, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_f64d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_f64f, 2); if(jnzd(0x1009_f65a, 0x9)) goto l_0x1009_f65a; /* jnz 0x1009f65a */
            ii(0x1009_f651, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1009_f655, 5); jmpd(0x1009_fd5f, 0x705); goto l_0x1009_fd5f; /* jmp 0x1009fd5f */
        l_0x1009_f65a:
            ii(0x1009_f65a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f65d, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_f660, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_f663, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1009_f669, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x1009_f66f, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1009_f672, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_f675, 4); or(memb_a32[ss, ebp - 0x10], 0x1);      /* or byte [ebp-0x10], 0x1 */
            ii(0x1009_f679, 5); calld(0x1008_a6d4, -0x1_4faa);          /* call 0x1008a6d4 */
            ii(0x1009_f67e, 1); cwde();                                 /* cwde */
            ii(0x1009_f67f, 1); pushd(eax);                             /* push eax */
            ii(0x1009_f680, 5); mov(ecx, 0x3);                          /* mov ecx, 0x3 */
            ii(0x1009_f685, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1009_f68a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f68d, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_f690, 5); calld(0x1007_65d0, -0x2_90c5);          /* call 0x100765d0 */
            ii(0x1009_f695, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_f697, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_f69a, 5); calld(0x1011_fec1, 0x8_0822);           /* call 0x1011fec1 */
            ii(0x1009_f69f, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1009_f6a2, 4); and(memb_a32[ss, ebp - 0x10], -0x2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x1009_f6a6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f6a9, 3); mov(eax, memd_a32[ds, eax + 0x19]);     /* mov eax, [eax+0x19] */
            ii(0x1009_f6ac, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_f6af, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_f6b1, 6); if(jnzd(0x1009_f9c3, 0x30c)) goto l_0x1009_f9c3; /* jnz 0x1009f9c3 */
            ii(0x1009_f6b7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f6ba, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_f6bd, 5); calld(0x1007_6574, -0x2_914e);          /* call 0x10076574 */
            ii(0x1009_f6c2, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1009_f6c5, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_f6c8, 3); sub(edx, 0x5);                          /* sub edx, 0x5 */
            ii(0x1009_f6cb, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1009_f6d0, 5); calld(0x1007_6e7c, -0x2_8859);          /* call 0x10076e7c */
            ii(0x1009_f6d5, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1009_f6d8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f6db, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_f6de, 5); calld(0x1007_6574, -0x2_916f);          /* call 0x10076574 */
            ii(0x1009_f6e3, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1009_f6e6, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_f6e9, 3); add(edx, 0x6);                          /* add edx, 0x6 */
            ii(0x1009_f6ec, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x1009_f6f1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_f6f4, 1); dec(eax);                               /* dec eax */
            ii(0x1009_f6f5, 5); calld(Definitions.my_min, -0x1_5f76);   /* call 0x10089784 */
            ii(0x1009_f6fa, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1009_f6fd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f700, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_f703, 5); calld(0x1007_6574, -0x2_9194);          /* call 0x10076574 */
            ii(0x1009_f708, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x1009_f70b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_f70e, 3); lea(edx, eax - 0x5);                    /* lea edx, [eax-0x5] */
            ii(0x1009_f711, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1009_f716, 5); calld(0x1007_6e7c, -0x2_889f);          /* call 0x10076e7c */
            ii(0x1009_f71b, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1009_f71e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f721, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_f724, 5); calld(0x1007_6574, -0x2_91b5);          /* call 0x10076574 */
            ii(0x1009_f729, 3); mov(edx, memd_a32[ds, eax + 0x1a]);     /* mov edx, [eax+0x1a] */
            ii(0x1009_f72c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_f72f, 3); add(edx, 0x6);                          /* add edx, 0x6 */
            ii(0x1009_f732, 5); mov(eax, memd_a32[ds, 0x101c_8172]);    /* mov eax, [0x101c8172] */
            ii(0x1009_f737, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_f73a, 1); dec(eax);                               /* dec eax */
            ii(0x1009_f73b, 5); calld(Definitions.my_min, -0x1_5fbc);   /* call 0x10089784 */
            ii(0x1009_f740, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1009_f743, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f746, 4); mov(memb_a32[ds, eax + 0x2a], 0);       /* mov byte [eax+0x2a], 0x0 */
            ii(0x1009_f74a, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1009_f74d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_f750, 4); mov(memw_a32[ds, edx + 0x1f], ax);      /* mov [edx+0x1f], ax */
            ii(0x1009_f754, 2); jmpd(0x1009_f75d, 0x7); goto l_0x1009_f75d; /* jmp 0x1009f75d */
        l_0x1009_f756:
            ii(0x1009_f756, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f759, 4); inc(memw_a32[ds, eax + 0x1f]);          /* inc word [eax+0x1f] */
        l_0x1009_f75d:
            ii(0x1009_f75d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f760, 3); mov(eax, memd_a32[ds, eax + 0x1d]);     /* mov eax, [eax+0x1d] */
            ii(0x1009_f763, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_f766, 3); cmp(eax, memd_a32[ss, ebp - 0x3c]);     /* cmp eax, [ebp-0x3c] */
            ii(0x1009_f769, 6); if(jged(0x1009_f901, 0x192)) goto l_0x1009_f901; /* jge 0x1009f901 */
            ii(0x1009_f76f, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1009_f772, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_f775, 4); mov(memw_a32[ds, edx + 0x21], ax);      /* mov [edx+0x21], ax */
            ii(0x1009_f779, 2); jmpd(0x1009_f782, 0x7); goto l_0x1009_f782; /* jmp 0x1009f782 */
        l_0x1009_f77b:
            ii(0x1009_f77b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f77e, 4); inc(memw_a32[ds, eax + 0x21]);          /* inc word [eax+0x21] */
        l_0x1009_f782:
            ii(0x1009_f782, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f785, 3); mov(eax, memd_a32[ds, eax + 0x1f]);     /* mov eax, [eax+0x1f] */
            ii(0x1009_f788, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_f78b, 3); cmp(eax, memd_a32[ss, ebp - 0x38]);     /* cmp eax, [ebp-0x38] */
            ii(0x1009_f78e, 6); if(jged(0x1009_f8fc, 0x168)) goto l_0x1009_f8fc; /* jge 0x1009f8fc */
            ii(0x1009_f794, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f797, 3); mov(edx, memd_a32[ds, eax + 0x1f]);     /* mov edx, [eax+0x1f] */
            ii(0x1009_f79a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_f79d, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x1009_f7a2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_f7a5, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1009_f7a8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f7ab, 3); mov(eax, memd_a32[ds, eax + 0x1d]);     /* mov eax, [eax+0x1d] */
            ii(0x1009_f7ae, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_f7b1, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_f7b3, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_f7b5, 6); mov(edx, memd_a32[ds, 0x101c_811c]);    /* mov edx, [0x101c811c] */
            ii(0x1009_f7bb, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_f7bd, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1009_f7c0, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1009_f7c3, 4); movsx(edx, memw_a32[ss, ebp - 0x48]);   /* movsx edx, word [ebp-0x48] */
            ii(0x1009_f7c7, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1009_f7cb, 2); test(edx, eax);                         /* test edx, eax */
            ii(0x1009_f7cd, 2); if(jzd(0x1009_f7d7, 0x8)) goto l_0x1009_f7d7; /* jz 0x1009f7d7 */
            ii(0x1009_f7cf, 6); test(memw_a32[ss, ebp - 0x48], 0x1f);   /* test word [ebp-0x48], 0x1f */
            ii(0x1009_f7d5, 2); if(jnzd(0x1009_f7dc, 0x5)) goto l_0x1009_f7dc; /* jnz 0x1009f7dc */
        l_0x1009_f7d7:
            ii(0x1009_f7d7, 5); jmpd(0x1009_f8f7, 0x11b); goto l_0x1009_f8f7; /* jmp 0x1009f8f7 */
        l_0x1009_f7dc:
            ii(0x1009_f7dc, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_f7df, 3); add(edx, 0x1f);                         /* add edx, 0x1f */
            ii(0x1009_f7e2, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1009_f7e5, 5); calld(0x1007_5e64, -0x2_9986);          /* call 0x10075e64 */
            ii(0x1009_f7ea, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_f7ec, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f7ef, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_f7f2, 5); calld(0x1007_65d0, -0x2_9227);          /* call 0x100765d0 */
            ii(0x1009_f7f7, 5); calld(0x1007_0ca1, -0x2_eb5b);          /* call 0x10070ca1 */
            ii(0x1009_f7fc, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x1009_f7ff, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f802, 4); cmp(memb_a32[ds, eax + 0x2a], 0);       /* cmp byte [eax+0x2a], 0x0 */
            ii(0x1009_f806, 2); if(jzd(0x1009_f815, 0xd)) goto l_0x1009_f815; /* jz 0x1009f815 */
            ii(0x1009_f808, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x1009_f80b, 4); cmp(ax, memw_a32[ss, ebp - 0x50]);      /* cmp ax, [ebp-0x50] */
            ii(0x1009_f80f, 6); if(jled(0x1009_f8f7, 0xe2)) goto l_0x1009_f8f7; /* jle 0x1009f8f7 */
        l_0x1009_f815:
            ii(0x1009_f815, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f818, 4); mov(ax, memw_a32[ds, eax + 0x1f]);      /* mov ax, [eax+0x1f] */
            ii(0x1009_f81c, 1); dec(eax);                               /* dec eax */
            ii(0x1009_f81d, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
            ii(0x1009_f820, 2); jmpd(0x1009_f828, 0x6); goto l_0x1009_f828; /* jmp 0x1009f828 */
        l_0x1009_f822:
            ii(0x1009_f822, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x1009_f825, 3); inc(memd_a32[ss, ebp - 0x58]);          /* inc dword [ebp-0x58] */
        l_0x1009_f828:
            ii(0x1009_f828, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f82b, 3); mov(eax, memd_a32[ds, eax + 0x1d]);     /* mov eax, [eax+0x1d] */
            ii(0x1009_f82e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_f831, 4); movsx(edx, memw_a32[ss, ebp - 0x58]);   /* movsx edx, word [ebp-0x58] */
            ii(0x1009_f835, 1); inc(eax);                               /* inc eax */
            ii(0x1009_f836, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_f838, 6); if(jgd(0x1009_f8f7, 0xb9)) goto l_0x1009_f8f7; /* jg 0x1009f8f7 */
            ii(0x1009_f83e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f841, 4); mov(ax, memw_a32[ds, eax + 0x21]);      /* mov ax, [eax+0x21] */
            ii(0x1009_f845, 1); dec(eax);                               /* dec eax */
            ii(0x1009_f846, 3); mov(memd_a32[ss, ebp - 0x5c], eax);     /* mov [ebp-0x5c], eax */
            ii(0x1009_f849, 2); jmpd(0x1009_f851, 0x6); goto l_0x1009_f851; /* jmp 0x1009f851 */
        l_0x1009_f84b:
            ii(0x1009_f84b, 3); mov(eax, memd_a32[ss, ebp - 0x5c]);     /* mov eax, [ebp-0x5c] */
            ii(0x1009_f84e, 3); inc(memd_a32[ss, ebp - 0x5c]);          /* inc dword [ebp-0x5c] */
        l_0x1009_f851:
            ii(0x1009_f851, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f854, 3); mov(eax, memd_a32[ds, eax + 0x1f]);     /* mov eax, [eax+0x1f] */
            ii(0x1009_f857, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_f85a, 4); movsx(edx, memw_a32[ss, ebp - 0x5c]);   /* movsx edx, word [ebp-0x5c] */
            ii(0x1009_f85e, 1); inc(eax);                               /* inc eax */
            ii(0x1009_f85f, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_f861, 6); if(jgd(0x1009_f8f2, 0x8b)) goto l_0x1009_f8f2; /* jg 0x1009f8f2 */
            ii(0x1009_f867, 4); movsx(edx, memw_a32[ss, ebp - 0x5c]);   /* movsx edx, word [ebp-0x5c] */
            ii(0x1009_f86b, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x1009_f870, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_f873, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1009_f876, 4); movsx(eax, memw_a32[ss, ebp - 0x58]);   /* movsx eax, word [ebp-0x58] */
            ii(0x1009_f87a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_f87c, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_f87e, 6); mov(edx, memd_a32[ds, 0x101c_811c]);    /* mov edx, [0x101c811c] */
            ii(0x1009_f884, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_f886, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1009_f889, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1009_f88c, 4); movsx(edx, memw_a32[ss, ebp - 0x48]);   /* movsx edx, word [ebp-0x48] */
            ii(0x1009_f890, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1009_f894, 2); test(edx, eax);                         /* test edx, eax */
            ii(0x1009_f896, 2); if(jnzd(0x1009_f8af, 0x17)) goto l_0x1009_f8af; /* jnz 0x1009f8af */
            ii(0x1009_f898, 4); movsx(edx, memw_a32[ss, ebp - 0x5c]);   /* movsx edx, word [ebp-0x5c] */
            ii(0x1009_f89c, 4); movsx(eax, memw_a32[ss, ebp - 0x58]);   /* movsx eax, word [ebp-0x58] */
            ii(0x1009_f8a0, 5); calld(0x1007_3cfd, -0x2_bba8);          /* call 0x10073cfd */
            ii(0x1009_f8a5, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1009_f8aa, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1009_f8ad, 2); if(jnzd(0x1009_f8b1, 0x2)) goto l_0x1009_f8b1; /* jnz 0x1009f8b1 */
        l_0x1009_f8af:
            ii(0x1009_f8af, 2); jmpd(0x1009_f8cd, 0x1c); goto l_0x1009_f8cd; /* jmp 0x1009f8cd */
        l_0x1009_f8b1:
            ii(0x1009_f8b1, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_f8b4, 3); add(edx, 0x1f);                         /* add edx, 0x1f */
            ii(0x1009_f8b7, 3); lea(eax, ebp - 0x60);                   /* lea eax, [ebp-0x60] */
            ii(0x1009_f8ba, 5); calld(0x1007_5e64, -0x2_9a5b);          /* call 0x10075e64 */
            ii(0x1009_f8bf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_f8c1, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_f8c4, 5); calld(0x1011_ff4c, 0x8_0683);           /* call 0x1011ff4c */
            ii(0x1009_f8c9, 2); test(al, al);                           /* test al, al */
            ii(0x1009_f8cb, 2); if(jnzd(0x1009_f8cf, 0x2)) goto l_0x1009_f8cf; /* jnz 0x1009f8cf */
        l_0x1009_f8cd:
            ii(0x1009_f8cd, 2); jmpd(0x1009_f8ed, 0x1e); goto l_0x1009_f8ed; /* jmp 0x1009f8ed */
        l_0x1009_f8cf:
            ii(0x1009_f8cf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f8d2, 4); mov(memb_a32[ds, eax + 0x2a], 0x1);     /* mov byte [eax+0x2a], 0x1 */
            ii(0x1009_f8d6, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_f8d9, 3); add(edx, 0x1f);                         /* add edx, 0x1f */
            ii(0x1009_f8dc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f8df, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x1009_f8e2, 5); calld(0x1008_8b44, -0x1_6da3);          /* call 0x10088b44 */
            ii(0x1009_f8e7, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1009_f8ea, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
        l_0x1009_f8ed:
            ii(0x1009_f8ed, 5); jmpd(0x1009_f84b, -0xa7); goto l_0x1009_f84b; /* jmp 0x1009f84b */
        l_0x1009_f8f2:
            ii(0x1009_f8f2, 5); jmpd(0x1009_f822, -0xd5); goto l_0x1009_f822; /* jmp 0x1009f822 */
        l_0x1009_f8f7:
            ii(0x1009_f8f7, 5); jmpd(0x1009_f77b, -0x181); goto l_0x1009_f77b; /* jmp 0x1009f77b */
        l_0x1009_f8fc:
            ii(0x1009_f8fc, 5); jmpd(0x1009_f756, -0x1ab); goto l_0x1009_f756; /* jmp 0x1009f756 */
        l_0x1009_f901:
            ii(0x1009_f901, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f904, 4); cmp(memb_a32[ds, eax + 0x2a], 0);       /* cmp byte [eax+0x2a], 0x0 */
            ii(0x1009_f908, 2); if(jzd(0x1009_f960, 0x56)) goto l_0x1009_f960; /* jz 0x1009f960 */
            ii(0x1009_f90a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f90d, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_f910, 5); calld(0x1007_6574, -0x2_93a1);          /* call 0x10076574 */
            ii(0x1009_f915, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_f918, 4); mov(dx, memw_a32[ds, edx + 0x23]);      /* mov dx, [edx+0x23] */
            ii(0x1009_f91c, 4); mov(memw_a32[ds, eax + 0x41], dx);      /* mov [eax+0x41], dx */
            ii(0x1009_f920, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f923, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_f926, 5); calld(0x1007_6574, -0x2_93b7);          /* call 0x10076574 */
            ii(0x1009_f92b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_f92e, 4); mov(dx, memw_a32[ds, edx + 0x25]);      /* mov dx, [edx+0x25] */
            ii(0x1009_f932, 4); mov(memw_a32[ds, eax + 0x43], dx);      /* mov [eax+0x43], dx */
            ii(0x1009_f936, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_f938, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1009_f93d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f940, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_f943, 5); calld(0x1007_65d0, -0x2_9378);          /* call 0x100765d0 */
            ii(0x1009_f948, 5); calld(0x1016_3053, 0xc_3706);           /* call 0x10163053 */
            ii(0x1009_f94d, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1009_f951, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_f953, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_f956, 5); calld(Definitions.my_dtor_d1, -0x1_6c5f); /* call 0x10088cfc */
            ii(0x1009_f95b, 5); jmpd(0x1009_fd5f, 0x3ff); goto l_0x1009_fd5f; /* jmp 0x1009fd5f */
        l_0x1009_f960:
            ii(0x1009_f960, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f963, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_f966, 5); calld(0x1007_6574, -0x2_93f7);          /* call 0x10076574 */
            ii(0x1009_f96b, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1009_f96f, 1); dec(eax);                               /* dec eax */
            ii(0x1009_f970, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_f973, 4); mov(memw_a32[ds, edx + 0x1f], ax);      /* mov [edx+0x1f], ax */
            ii(0x1009_f977, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f97a, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_f97d, 5); calld(0x1007_6574, -0x2_940e);          /* call 0x10076574 */
            ii(0x1009_f982, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1009_f986, 1); inc(eax);                               /* inc eax */
            ii(0x1009_f987, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_f98a, 4); mov(memw_a32[ds, edx + 0x21], ax);      /* mov [edx+0x21], ax */
            ii(0x1009_f98e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f991, 6); mov(memw_a32[ds, eax + 0x1b], 0x1);     /* mov word [eax+0x1b], 0x1 */
            ii(0x1009_f997, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f99a, 6); mov(memw_a32[ds, eax + 0x1d], 0);       /* mov word [eax+0x1d], 0x0 */
            ii(0x1009_f9a0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f9a3, 6); mov(memw_a32[ds, eax + 0x2b], 0);       /* mov word [eax+0x2b], 0x0 */
            ii(0x1009_f9a9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f9ac, 4); mov(memb_a32[ds, eax + 0x29], 0);       /* mov byte [eax+0x29], 0x0 */
            ii(0x1009_f9b0, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1009_f9b4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_f9b6, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_f9b9, 5); calld(Definitions.my_dtor_d1, -0x1_6cc2); /* call 0x10088cfc */
            ii(0x1009_f9be, 5); jmpd(0x1009_fd5f, 0x39c); goto l_0x1009_fd5f; /* jmp 0x1009fd5f */
        l_0x1009_f9c3:
            ii(0x1009_f9c3, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x1009_f9ca, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_f9cd, 5); calld(Definitions.my_ctor_0x101b4184, -0x2_8ee2); /* call 0x10076af0 */
            ii(0x1009_f9d2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f9d5, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_f9d8, 5); calld(0x1007_6574, -0x2_9469);          /* call 0x10076574 */
            ii(0x1009_f9dd, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1009_f9e1, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_f9e4, 4); sub(ax, memw_a32[ds, edx + 0x15]);      /* sub ax, [edx+0x15] */
            ii(0x1009_f9e8, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_f9eb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f9ee, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_f9f1, 5); calld(0x1007_6574, -0x2_9482);          /* call 0x10076574 */
            ii(0x1009_f9f6, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1009_f9fa, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1009_f9fd, 4); sub(ax, memw_a32[ds, ebx + 0x13]);      /* sub ax, [ebx+0x13] */
            ii(0x1009_fa01, 1); cwde();                                 /* cwde */
            ii(0x1009_fa02, 5); calld(0x1015_c339, 0xb_c932);           /* call 0x1015c339 */
            ii(0x1009_fa07, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
        l_0x1009_fa0a:
            ii(0x1009_fa0a, 5); calld(0x1014_82f4, 0xa_88e5);           /* call 0x101482f4 */
            ii(0x1009_fa0f, 6); sub(eax, memd_a32[ds, 0x101c_3974]);    /* sub eax, [0x101c3974] */
            ii(0x1009_fa15, 6); cmp(eax, memd_a32[ds, 0x101b_dd84]);    /* cmp eax, [0x101bdd84] */
            ii(0x1009_fa1b, 2); if(jbd(0x1009_fa2a, 0xd)) goto l_0x1009_fa2a; /* jb 0x1009fa2a */
            ii(0x1009_fa1d, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1009_fa21, 3); cmp(eax, 0x14);                         /* cmp eax, 0x14 */
            ii(0x1009_fa24, 6); if(jged(0x1009_fd45, 0x31b)) goto l_0x1009_fd45; /* jge 0x1009fd45 */
        l_0x1009_fa2a:
            ii(0x1009_fa2a, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_fa2d, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
            ii(0x1009_fa30, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fa33, 3); mov(eax, memd_a32[ds, eax + 0x1b]);     /* mov eax, [eax+0x1b] */
            ii(0x1009_fa36, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_fa39, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_fa3c, 5); mov(edx, 0x101c_5348);                  /* mov edx, 0x101c5348 */
            ii(0x1009_fa41, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_fa43, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fa46, 3); add(eax, 0x1f);                         /* add eax, 0x1f */
            ii(0x1009_fa49, 5); calld(0x1008_b1a4, -0x1_48aa);          /* call 0x1008b1a4 */
            ii(0x1009_fa4e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fa51, 4); inc(memw_a32[ds, eax + 0x2b]);          /* inc word [eax+0x2b] */
            ii(0x1009_fa55, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fa58, 3); mov(edx, memd_a32[ds, eax + 0x29]);     /* mov edx, [eax+0x29] */
            ii(0x1009_fa5b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_fa5e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fa61, 3); mov(eax, memd_a32[ds, eax + 0x19]);     /* mov eax, [eax+0x19] */
            ii(0x1009_fa64, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_fa67, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_fa69, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_fa6b, 6); if(jld(0x1009_fb5c, 0xeb)) goto l_0x1009_fb5c; /* jl 0x1009fb5c */
            ii(0x1009_fa71, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fa74, 6); mov(memw_a32[ds, eax + 0x2b], 0);       /* mov word [eax+0x2b], 0x0 */
            ii(0x1009_fa7a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fa7d, 5); add(memw_a32[ds, eax + 0x1d], 0x2);     /* add word [eax+0x1d], 0x2 */
            ii(0x1009_fa82, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fa85, 3); mov(eax, memd_a32[ds, eax + 0x1b]);     /* mov eax, [eax+0x1b] */
            ii(0x1009_fa88, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_fa8b, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1009_fa8e, 6); if(jld(0x1009_fb5c, 0xc8)) goto l_0x1009_fb5c; /* jl 0x1009fb5c */
            ii(0x1009_fa94, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fa97, 4); cmp(memb_a32[ds, eax + 0x2a], 0);       /* cmp byte [eax+0x2a], 0x0 */
            ii(0x1009_fa9b, 2); if(jzd(0x1009_fafc, 0x5f)) goto l_0x1009_fafc; /* jz 0x1009fafc */
            ii(0x1009_fa9d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_faa0, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_faa3, 5); calld(0x1007_6574, -0x2_9534);          /* call 0x10076574 */
            ii(0x1009_faa8, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_faab, 4); mov(dx, memw_a32[ds, edx + 0x23]);      /* mov dx, [edx+0x23] */
            ii(0x1009_faaf, 4); mov(memw_a32[ds, eax + 0x41], dx);      /* mov [eax+0x41], dx */
            ii(0x1009_fab3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fab6, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_fab9, 5); calld(0x1007_6574, -0x2_954a);          /* call 0x10076574 */
            ii(0x1009_fabe, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_fac1, 4); mov(dx, memw_a32[ds, edx + 0x25]);      /* mov dx, [edx+0x25] */
            ii(0x1009_fac5, 4); mov(memw_a32[ds, eax + 0x43], dx);      /* mov [eax+0x43], dx */
            ii(0x1009_fac9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_facc, 6); mov(memw_a32[ds, eax + 0x1b], 0);       /* mov word [eax+0x1b], 0x0 */
            ii(0x1009_fad2, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_fad4, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1009_fad9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fadc, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_fadf, 5); calld(0x1007_65d0, -0x2_9514);          /* call 0x100765d0 */
            ii(0x1009_fae4, 5); calld(0x1016_3053, 0xc_356a);           /* call 0x10163053 */
            ii(0x1009_fae9, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1009_faed, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_faef, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_faf2, 5); calld(Definitions.my_dtor_d1, -0x1_6dfb); /* call 0x10088cfc */
            ii(0x1009_faf7, 5); jmpd(0x1009_fd5f, 0x263); goto l_0x1009_fd5f; /* jmp 0x1009fd5f */
        l_0x1009_fafc:
            ii(0x1009_fafc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_faff, 4); cmp(memb_a32[ds, eax + 0x29], 0);       /* cmp byte [eax+0x29], 0x0 */
            ii(0x1009_fb03, 2); if(jnzd(0x1009_fb37, 0x32)) goto l_0x1009_fb37; /* jnz 0x1009fb37 */
            ii(0x1009_fb05, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fb08, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_fb0b, 5); calld(0x1007_6574, -0x2_959c);          /* call 0x10076574 */
            ii(0x1009_fb10, 4); mov(memb_a32[ds, eax + 0x5c], 0);       /* mov byte [eax+0x5c], 0x0 */
            ii(0x1009_fb14, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fb17, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_fb1a, 5); calld(0x1007_6574, -0x2_95ab);          /* call 0x10076574 */
            ii(0x1009_fb1f, 5); calld(0x1015_287d, 0xb_2d59);           /* call 0x1015287d */
            ii(0x1009_fb24, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1009_fb28, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_fb2a, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_fb2d, 5); calld(Definitions.my_dtor_d1, -0x1_6e36); /* call 0x10088cfc */
            ii(0x1009_fb32, 5); jmpd(0x1009_fd5f, 0x228); goto l_0x1009_fd5f; /* jmp 0x1009fd5f */
        l_0x1009_fb37:
            ii(0x1009_fb37, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fb3a, 6); mov(memw_a32[ds, eax + 0x1d], 0);       /* mov word [eax+0x1d], 0x0 */
            ii(0x1009_fb40, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fb43, 4); mov(memb_a32[ds, eax + 0x29], 0);       /* mov byte [eax+0x29], 0x0 */
            ii(0x1009_fb47, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fb4a, 4); inc(memw_a32[ds, eax + 0x1b]);          /* inc word [eax+0x1b] */
            ii(0x1009_fb4e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fb51, 4); dec(memw_a32[ds, eax + 0x1f]);          /* dec word [eax+0x1f] */
            ii(0x1009_fb55, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fb58, 4); inc(memw_a32[ds, eax + 0x21]);          /* inc word [eax+0x21] */
        l_0x1009_fb5c:
            ii(0x1009_fb5c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fb5f, 3); mov(eax, memd_a32[ds, eax + 0x1d]);     /* mov eax, [eax+0x1d] */
            ii(0x1009_fb62, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_fb65, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_fb67, 2); if(jld(0x1009_fb79, 0x10)) goto l_0x1009_fb79; /* jl 0x1009fb79 */
            ii(0x1009_fb69, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fb6c, 4); mov(ax, memw_a32[ds, eax + 0x1f]);      /* mov ax, [eax+0x1f] */
            ii(0x1009_fb70, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x1009_fb77, 2); if(jld(0x1009_fb7b, 0x2)) goto l_0x1009_fb7b; /* jl 0x1009fb7b */
        l_0x1009_fb79:
            ii(0x1009_fb79, 2); jmpd(0x1009_fb88, 0xd); goto l_0x1009_fb88; /* jmp 0x1009fb88 */
        l_0x1009_fb7b:
            ii(0x1009_fb7b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fb7e, 3); mov(eax, memd_a32[ds, eax + 0x1f]);     /* mov eax, [eax+0x1f] */
            ii(0x1009_fb81, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_fb84, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_fb86, 2); if(jged(0x1009_fb8a, 0x2)) goto l_0x1009_fb8a; /* jge 0x1009fb8a */
        l_0x1009_fb88:
            ii(0x1009_fb88, 2); jmpd(0x1009_fb9a, 0x10); goto l_0x1009_fb9a; /* jmp 0x1009fb9a */
        l_0x1009_fb8a:
            ii(0x1009_fb8a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fb8d, 4); mov(ax, memw_a32[ds, eax + 0x21]);      /* mov ax, [eax+0x21] */
            ii(0x1009_fb91, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x1009_fb98, 2); if(jld(0x1009_fb9f, 0x5)) goto l_0x1009_fb9f; /* jl 0x1009fb9f */
        l_0x1009_fb9a:
            ii(0x1009_fb9a, 5); jmpd(0x1009_fd40, 0x1a1); goto l_0x1009_fd40; /* jmp 0x1009fd40 */
        l_0x1009_fb9f:
            ii(0x1009_fb9f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fba2, 4); mov(memb_a32[ds, eax + 0x29], 0x1);     /* mov byte [eax+0x29], 0x1 */
            ii(0x1009_fba6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fba9, 3); mov(edx, memd_a32[ds, eax + 0x1f]);     /* mov edx, [eax+0x1f] */
            ii(0x1009_fbac, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_fbaf, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x1009_fbb4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_fbb7, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1009_fbba, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fbbd, 3); mov(eax, memd_a32[ds, eax + 0x1d]);     /* mov eax, [eax+0x1d] */
            ii(0x1009_fbc0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_fbc3, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_fbc5, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_fbc7, 6); mov(edx, memd_a32[ds, 0x101c_811c]);    /* mov edx, [0x101c811c] */
            ii(0x1009_fbcd, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_fbcf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_fbd1, 3); mov(dx, memw_a32[ds, eax]);             /* mov dx, [eax] */
            ii(0x1009_fbd4, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1009_fbd8, 2); test(edx, eax);                         /* test edx, eax */
            ii(0x1009_fbda, 6); if(jnzd(0x1009_fd40, 0x160)) goto l_0x1009_fd40; /* jnz 0x1009fd40 */
            ii(0x1009_fbe0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fbe3, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_fbe6, 5); calld(0x1007_6574, -0x2_9677);          /* call 0x10076574 */
            ii(0x1009_fbeb, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_fbee, 4); mov(dx, memw_a32[ds, edx + 0x21]);      /* mov dx, [edx+0x21] */
            ii(0x1009_fbf2, 4); sub(dx, memw_a32[ds, eax + 0x1c]);      /* sub dx, [eax+0x1c] */
            ii(0x1009_fbf6, 3); movsx(ebx, dx);                         /* movsx ebx, dx */
            ii(0x1009_fbf9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fbfc, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_fbff, 5); calld(0x1007_6574, -0x2_9690);          /* call 0x10076574 */
            ii(0x1009_fc04, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_fc07, 4); mov(dx, memw_a32[ds, edx + 0x1f]);      /* mov dx, [edx+0x1f] */
            ii(0x1009_fc0b, 4); sub(dx, memw_a32[ds, eax + 0x1a]);      /* sub dx, [eax+0x1a] */
            ii(0x1009_fc0f, 3); movsx(eax, dx);                         /* movsx eax, dx */
            ii(0x1009_fc12, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1009_fc14, 5); calld(0x1015_c339, 0xb_c720);           /* call 0x1015c339 */
            ii(0x1009_fc19, 3); sub(eax, memd_a32[ss, ebp - 0x20]);     /* sub eax, [ebp-0x20] */
            ii(0x1009_fc1c, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1009_fc1f, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_fc22, 5); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x1009_fc27, 5); and(eax, 0x7);                          /* and eax, 0x7 */
            ii(0x1009_fc2c, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1009_fc2f, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1009_fc33, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1009_fc36, 2); if(jled(0x1009_fc43, 0xb)) goto l_0x1009_fc43; /* jle 0x1009fc43 */
            ii(0x1009_fc38, 5); mov(eax, 0x8);                          /* mov eax, 0x8 */
            ii(0x1009_fc3d, 3); sub(eax, memd_a32[ss, ebp - 0x1c]);     /* sub eax, [ebp-0x1c] */
            ii(0x1009_fc40, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x1009_fc43:
            ii(0x1009_fc43, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fc46, 4); cmp(memb_a32[ds, eax + 0x2a], 0);       /* cmp byte [eax+0x2a], 0x0 */
            ii(0x1009_fc4a, 2); if(jzd(0x1009_fc58, 0xc)) goto l_0x1009_fc58; /* jz 0x1009fc58 */
            ii(0x1009_fc4c, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_fc4f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_fc52, 4); cmp(ax, memw_a32[ds, edx + 0x27]);      /* cmp ax, [edx+0x27] */
            ii(0x1009_fc56, 2); if(jled(0x1009_fc74, 0x1c)) goto l_0x1009_fc74; /* jle 0x1009fc74 */
        l_0x1009_fc58:
            ii(0x1009_fc58, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_fc5b, 3); add(edx, 0x1f);                         /* add edx, 0x1f */
            ii(0x1009_fc5e, 3); lea(eax, ebp - 0x68);                   /* lea eax, [ebp-0x68] */
            ii(0x1009_fc61, 5); calld(0x1007_5e64, -0x2_9e02);          /* call 0x10075e64 */
            ii(0x1009_fc66, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_fc68, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_fc6b, 5); calld(0x1011_ff4c, 0x8_02dc);           /* call 0x1011ff4c */
            ii(0x1009_fc70, 2); test(al, al);                           /* test al, al */
            ii(0x1009_fc72, 2); if(jnzd(0x1009_fc79, 0x5)) goto l_0x1009_fc79; /* jnz 0x1009fc79 */
        l_0x1009_fc74:
            ii(0x1009_fc74, 5); jmpd(0x1009_fd40, 0xc7); goto l_0x1009_fd40; /* jmp 0x1009fd40 */
        l_0x1009_fc79:
            ii(0x1009_fc79, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fc7c, 4); mov(memb_a32[ds, eax + 0x2a], 0x1);     /* mov byte [eax+0x2a], 0x1 */
            ii(0x1009_fc80, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_fc83, 3); add(edx, 0x1f);                         /* add edx, 0x1f */
            ii(0x1009_fc86, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fc89, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x1009_fc8c, 5); calld(0x1008_8b44, -0x1_714d);          /* call 0x10088b44 */
            ii(0x1009_fc91, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_fc94, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_fc97, 4); mov(memw_a32[ds, edx + 0x27], ax);      /* mov [edx+0x27], ax */
            ii(0x1009_fc9b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_fc9e, 3); add(edx, 0x1f);                         /* add edx, 0x1f */
            ii(0x1009_fca1, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_fca4, 5); calld(0x1008_8b44, -0x1_7165);          /* call 0x10088b44 */
            ii(0x1009_fca9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fcac, 4); mov(ax, memw_a32[ds, eax + 0x21]);      /* mov ax, [eax+0x21] */
            ii(0x1009_fcb0, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_fcb3, 4); sub(ax, memw_a32[ds, edx + 0x15]);      /* sub ax, [edx+0x15] */
            ii(0x1009_fcb7, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1009_fcba, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fcbd, 4); mov(ax, memw_a32[ds, eax + 0x1f]);      /* mov ax, [eax+0x1f] */
            ii(0x1009_fcc1, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_fcc4, 4); sub(ax, memw_a32[ds, edx + 0x13]);      /* sub ax, [edx+0x13] */
            ii(0x1009_fcc8, 1); cwde();                                 /* cwde */
            ii(0x1009_fcc9, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1009_fccb, 5); calld(0x1015_c339, 0xb_c669);           /* call 0x1015c339 */
            ii(0x1009_fcd0, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1009_fcd3, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1009_fcd7, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_fcda, 5); mov(edx, 0x101c_5348);                  /* mov edx, 0x101c5348 */
            ii(0x1009_fcdf, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_fce1, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_fce4, 5); calld(0x1008_b1a4, -0x1_4b45);          /* call 0x1008b1a4 */
            ii(0x1009_fce9, 4); movsx(eax, memw_a32[ss, ebp - 0x64]);   /* movsx eax, word [ebp-0x64] */
            ii(0x1009_fced, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_fcef, 2); if(jld(0x1009_fcfd, 0xc)) goto l_0x1009_fcfd; /* jl 0x1009fcfd */
            ii(0x1009_fcf1, 3); mov(eax, memd_a32[ss, ebp - 0x64]);     /* mov eax, [ebp-0x64] */
            ii(0x1009_fcf4, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x1009_fcfb, 2); if(jld(0x1009_fcff, 0x2)) goto l_0x1009_fcff; /* jl 0x1009fcff */
        l_0x1009_fcfd:
            ii(0x1009_fcfd, 2); jmpd(0x1009_fd07, 0x8); goto l_0x1009_fd07; /* jmp 0x1009fd07 */
        l_0x1009_fcff:
            ii(0x1009_fcff, 4); movsx(eax, memw_a32[ss, ebp - 0x62]);   /* movsx eax, word [ebp-0x62] */
            ii(0x1009_fd03, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_fd05, 2); if(jged(0x1009_fd09, 0x2)) goto l_0x1009_fd09; /* jge 0x1009fd09 */
        l_0x1009_fd07:
            ii(0x1009_fd07, 2); jmpd(0x1009_fd15, 0xc); goto l_0x1009_fd15; /* jmp 0x1009fd15 */
        l_0x1009_fd09:
            ii(0x1009_fd09, 3); mov(eax, memd_a32[ss, ebp - 0x62]);     /* mov eax, [ebp-0x62] */
            ii(0x1009_fd0c, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x1009_fd13, 2); if(jld(0x1009_fd17, 0x2)) goto l_0x1009_fd17; /* jl 0x1009fd17 */
        l_0x1009_fd15:
            ii(0x1009_fd15, 2); jmpd(0x1009_fd30, 0x19); goto l_0x1009_fd30; /* jmp 0x1009fd30 */
        l_0x1009_fd17:
            ii(0x1009_fd17, 3); lea(edx, ebp - 0x64);                   /* lea edx, [ebp-0x64] */
            ii(0x1009_fd1a, 3); lea(eax, ebp - 0x6c);                   /* lea eax, [ebp-0x6c] */
            ii(0x1009_fd1d, 5); calld(0x1007_5e64, -0x2_9ebe);          /* call 0x10075e64 */
            ii(0x1009_fd22, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_fd24, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_fd27, 5); calld(0x1011_ff4c, 0x8_0220);           /* call 0x1011ff4c */
            ii(0x1009_fd2c, 2); test(al, al);                           /* test al, al */
            ii(0x1009_fd2e, 2); if(jnzd(0x1009_fd32, 0x2)) goto l_0x1009_fd32; /* jnz 0x1009fd32 */
        l_0x1009_fd30:
            ii(0x1009_fd30, 2); jmpd(0x1009_fd40, 0xe); goto l_0x1009_fd40; /* jmp 0x1009fd40 */
        l_0x1009_fd32:
            ii(0x1009_fd32, 3); lea(edx, ebp - 0x64);                   /* lea edx, [ebp-0x64] */
            ii(0x1009_fd35, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_fd38, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x1009_fd3b, 5); calld(0x1008_8b44, -0x1_71fc);          /* call 0x10088b44 */
        l_0x1009_fd40:
            ii(0x1009_fd40, 5); jmpd(0x1009_fa0a, -0x33b); goto l_0x1009_fa0a; /* jmp 0x1009fa0a */
        l_0x1009_fd45:
            ii(0x1009_fd45, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1009_fd49, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_fd4b, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_fd4e, 5); calld(Definitions.my_dtor_d1, -0x1_7057); /* call 0x10088cfc */
            ii(0x1009_fd53, 2); jmpd(0x1009_fd5f, 0xa); goto l_0x1009_fd5f; /* jmp 0x1009fd5f */
        //    ii(0x1009_fd55, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1009_fd57, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
        //    ii(0x1009_fd5a, 5); calld(Definitions.my_dtor_d1, -0x1_7063); /* call 0x10088cfc */
        l_0x1009_fd5f:
            ii(0x1009_fd5f, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1009_fd62, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_fd64, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_fd65, 1); popd(edi);                              /* pop edi */
            ii(0x1009_fd66, 1); popd(esi);                              /* pop esi */
            ii(0x1009_fd67, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_fd68, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_fd69, 1); retd(); return;                         /* ret */
        }
    }
}
