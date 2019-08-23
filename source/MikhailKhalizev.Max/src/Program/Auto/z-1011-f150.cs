using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_f150-f955e27b")]
        public void Method_1011_f150()
        {
            ii(0x1011_f150, 5); push(0x74);                             /* push 0x74 */
            ii(0x1011_f155, 5); call(Definitions.sys_check_available_stack_size, 0x4_6bf8); /* call 0x10165d52 */
            ii(0x1011_f15a, 1); push(ebx);                              /* push ebx */
            ii(0x1011_f15b, 1); push(ecx);                              /* push ecx */
            ii(0x1011_f15c, 1); push(esi);                              /* push esi */
            ii(0x1011_f15d, 1); push(edi);                              /* push edi */
            ii(0x1011_f15e, 1); push(ebp);                              /* push ebp */
            ii(0x1011_f15f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_f161, 6); sub(esp, 0x5c);                         /* sub esp, 0x5c */
            ii(0x1011_f167, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_f16a, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_f16d, 7); cmp(memd[ds, 0x101c_5368], 0);          /* cmp dword [0x101c5368], 0x0 */
            ii(0x1011_f174, 2); if(jnz(0x1011_f1c8, 0x52)) goto l_0x1011_f1c8; /* jnz 0x1011f1c8 */
            ii(0x1011_f176, 5); mov(eax, memd[ds, 0x101c_8170]);        /* mov eax, [0x101c8170] */
            ii(0x1011_f17b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_f17e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_f181, 5); call(Definitions.sys_new_arr, 0x4_6e8a); /* call 0x10166010 */
            ii(0x1011_f186, 5); mov(memd[ds, 0x101c_5368], eax);        /* mov [0x101c5368], eax */
            ii(0x1011_f18b, 7); mov(memd[ss, ebp - 0x34], 0);           /* mov dword [ebp-0x34], 0x0 */
            ii(0x1011_f192, 2); jmp(0x1011_f19a, 0x6); goto l_0x1011_f19a; /* jmp 0x1011f19a */
        l_0x1011_f194:
            ii(0x1011_f194, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1011_f197, 3); inc(memd[ss, ebp - 0x34]);              /* inc dword [ebp-0x34] */
        l_0x1011_f19a:
            ii(0x1011_f19a, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1011_f19d, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x1011_f1a4, 2); if(jge(0x1011_f1c8, 0x22)) goto l_0x1011_f1c8; /* jge 0x1011f1c8 */
            ii(0x1011_f1a6, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x1011_f1ab, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_f1ae, 5); call(Definitions.sys_new_arr, 0x4_6e5d); /* call 0x10166010 */
            ii(0x1011_f1b3, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x1011_f1b7, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1011_f1ba, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1011_f1bc, 6); mov(edx, memd[ds, 0x101c_5368]);        /* mov edx, [0x101c5368] */
            ii(0x1011_f1c2, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x1011_f1c4, 2); mov(memd[ds, edx], eax);                /* mov [edx], eax */
            ii(0x1011_f1c6, 2); jmp(0x1011_f194, -0x34); goto l_0x1011_f194; /* jmp 0x1011f194 */
        l_0x1011_f1c8:
            ii(0x1011_f1c8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_f1cb, 5); call(0x100b_7f18, -0x6_72b8);           /* call 0x100b7f18 */
            ii(0x1011_f1d0, 5); call(0x100b_80c4, -0x6_7111);           /* call 0x100b80c4 */
            ii(0x1011_f1d5, 3); movsx(ecx, al);                         /* movsx ecx, al */
            ii(0x1011_f1d8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_f1db, 5); call(0x100b_7f18, -0x6_72c8);           /* call 0x100b7f18 */
            ii(0x1011_f1e0, 5); call(0x1012_0a2c, 0x1847);              /* call 0x10120a2c */
            ii(0x1011_f1e5, 3); movsx(ebx, al);                         /* movsx ebx, al */
            ii(0x1011_f1e8, 6); mov(edx, memd[ds, 0x101c_5368]);        /* mov edx, [0x101c5368] */
            ii(0x1011_f1ee, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_f1f1, 5); call(0x1011_ef28, -0x2ce);              /* call 0x1011ef28 */
            ii(0x1011_f1f6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_f1f9, 5); call(0x100b_7f18, -0x6_72e6);           /* call 0x100b7f18 */
            ii(0x1011_f1fe, 5); call(0x100b_8054, -0x6_71af);           /* call 0x100b8054 */
            ii(0x1011_f203, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_f205, 6); if(jz(0x1011_f330, 0x125)) goto l_0x1011_f330; /* jz 0x1011f330 */
            ii(0x1011_f20b, 4); or(memb[ss, ebp - 0x14], 0x1);          /* or byte [ebp-0x14], 0x1 */
            ii(0x1011_f20f, 3); lea(eax, memd[ss, ebp - 0x4c]);         /* lea eax, [ebp-0x4c] */
            ii(0x1011_f212, 5); call(0x1008_bbed, -0x9_362a);           /* call 0x1008bbed */
            ii(0x1011_f217, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
            ii(0x1011_f21a, 4); and(memb[ss, ebp - 0x14], -0x2 /* 0xfe */); /* and byte [ebp-0x14], 0xfe */
            ii(0x1011_f21e, 5); mov(ecx, 0x3);                          /* mov ecx, 0x3 */
            ii(0x1011_f223, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_f226, 5); call(0x100b_7f18, -0x6_7313);           /* call 0x100b7f18 */
            ii(0x1011_f22b, 5); call(0x1012_0a2c, 0x17fc);              /* call 0x10120a2c */
            ii(0x1011_f230, 3); movsx(ebx, al);                         /* movsx ebx, al */
            ii(0x1011_f233, 3); lea(eax, memd[ss, ebp - 0x4c]);         /* lea eax, [ebp-0x4c] */
            ii(0x1011_f236, 5); call(0x1008_a6f8, -0x9_4b43);           /* call 0x1008a6f8 */
            ii(0x1011_f23b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_f23d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_f240, 5); call(0x100b_7f18, -0x6_732d);           /* call 0x100b7f18 */
            ii(0x1011_f245, 5); call(0x100b_8054, -0x6_71f6);           /* call 0x100b8054 */
            ii(0x1011_f24a, 5); call(0x1011_ef28, -0x327);              /* call 0x1011ef28 */
            ii(0x1011_f24f, 7); mov(memd[ss, ebp - 0x34], 0);           /* mov dword [ebp-0x34], 0x0 */
            ii(0x1011_f256, 2); jmp(0x1011_f25e, 0x6); goto l_0x1011_f25e; /* jmp 0x1011f25e */
        l_0x1011_f258:
            ii(0x1011_f258, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1011_f25b, 3); inc(memd[ss, ebp - 0x34]);              /* inc dword [ebp-0x34] */
        l_0x1011_f25e:
            ii(0x1011_f25e, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1011_f261, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x1011_f268, 6); if(jge(0x1011_f326, 0xb8)) goto l_0x1011_f326; /* jge 0x1011f326 */
            ii(0x1011_f26e, 7); mov(memd[ss, ebp - 0x38], 0);           /* mov dword [ebp-0x38], 0x0 */
            ii(0x1011_f275, 2); jmp(0x1011_f27d, 0x6); goto l_0x1011_f27d; /* jmp 0x1011f27d */
        l_0x1011_f277:
            ii(0x1011_f277, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x1011_f27a, 3); inc(memd[ss, ebp - 0x38]);              /* inc dword [ebp-0x38] */
        l_0x1011_f27d:
            ii(0x1011_f27d, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x1011_f280, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x1011_f287, 6); if(jge(0x1011_f321, 0x94)) goto l_0x1011_f321; /* jge 0x1011f321 */
            ii(0x1011_f28d, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x1011_f291, 3); lea(eax, memd[ss, ebp - 0x4c]);         /* lea eax, [ebp-0x4c] */
            ii(0x1011_f294, 5); call(0x1008_a728, -0x9_4b71);           /* call 0x1008a728 */
            ii(0x1011_f299, 4); movsx(edx, memw[ss, ebp - 0x38]);       /* movsx edx, word [ebp-0x38] */
            ii(0x1011_f29d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_f29f, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1011_f2a1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_f2a6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_f2a8, 2); if(jnz(0x1011_f2c5, 0x1b)) goto l_0x1011_f2c5; /* jnz 0x1011f2c5 */
            ii(0x1011_f2aa, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x1011_f2ae, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1011_f2b1, 5); mov(eax, memd[ds, 0x101c_5368]);        /* mov eax, [0x101c5368] */
            ii(0x1011_f2b6, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_f2b8, 4); movsx(edx, memw[ss, ebp - 0x38]);       /* movsx edx, word [ebp-0x38] */
            ii(0x1011_f2bc, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1011_f2be, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_f2c0, 3); or(memb[ds, eax], 0x40);                /* or byte [eax], 0x40 */
            ii(0x1011_f2c3, 2); jmp(0x1011_f31c, 0x57); goto l_0x1011_f31c; /* jmp 0x1011f31c */
        l_0x1011_f2c5:
            ii(0x1011_f2c5, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1011_f2c9, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_f2cc, 6); mov(edx, memd[ds, 0x101c_5368]);        /* mov edx, [0x101c5368] */
            ii(0x1011_f2d2, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_f2d4, 4); movsx(edx, memw[ss, ebp - 0x38]);       /* movsx edx, word [ebp-0x38] */
            ii(0x1011_f2d8, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1011_f2da, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_f2dc, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1011_f2de, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_f2e3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_f2e5, 2); if(jnz(0x1011_f31c, 0x35)) goto l_0x1011_f31c; /* jnz 0x1011f31c */
            ii(0x1011_f2e7, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x1011_f2eb, 3); lea(eax, memd[ss, ebp - 0x4c]);         /* lea eax, [ebp-0x4c] */
            ii(0x1011_f2ee, 5); call(0x1008_a728, -0x9_4bcb);           /* call 0x1008a728 */
            ii(0x1011_f2f3, 4); movsx(edx, memw[ss, ebp - 0x38]);       /* movsx edx, word [ebp-0x38] */
            ii(0x1011_f2f7, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_f2f9, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1011_f2fb, 2); mov(ah, 0x3);                           /* mov ah, 0x3 */
            ii(0x1011_f2fd, 2); mul(ah);                                /* mul ah */
            ii(0x1011_f2ff, 2); or(al, 0x80);                           /* or al, 0x80 */
            ii(0x1011_f301, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1011_f303, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1011_f307, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_f30a, 6); mov(edx, memd[ds, 0x101c_5368]);        /* mov edx, [0x101c5368] */
            ii(0x1011_f310, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_f312, 4); movsx(edx, memw[ss, ebp - 0x38]);       /* movsx edx, word [ebp-0x38] */
            ii(0x1011_f316, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1011_f318, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_f31a, 2); mov(memb[ds, eax], bl);                 /* mov [eax], bl */
        l_0x1011_f31c:
            ii(0x1011_f31c, 5); jmp(0x1011_f277, -0xaa); goto l_0x1011_f277; /* jmp 0x1011f277 */
        l_0x1011_f321:
            ii(0x1011_f321, 5); jmp(0x1011_f258, -0xce); goto l_0x1011_f258; /* jmp 0x1011f258 */
        l_0x1011_f326:
            ii(0x1011_f326, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_f328, 3); lea(eax, memd[ss, ebp - 0x4c]);         /* lea eax, [ebp-0x4c] */
            ii(0x1011_f32b, 5); call(0x1008_bc9f, -0x9_3691);           /* call 0x1008bc9f */
        l_0x1011_f330:
            ii(0x1011_f330, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_f333, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x1011_f336, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_f339, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_f33c, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x1011_f33f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_f342, 3); lea(eax, memd[ss, ebp - 0x40]);         /* lea eax, [ebp-0x40] */
            ii(0x1011_f345, 5); call(0x1007_6aac, -0xa_889e);           /* call 0x10076aac */
            ii(0x1011_f34a, 3); lea(edx, memd[ss, ebp - 0x44]);         /* lea edx, [ebp-0x44] */
            ii(0x1011_f34d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_f350, 5); call(0x100b_7f18, -0x6_743d);           /* call 0x100b7f18 */
            ii(0x1011_f355, 5); call(0x100b_808c, -0x6_72ce);           /* call 0x100b808c */
            ii(0x1011_f35a, 4); movsx(eax, memw[ss, ebp - 0x40]);       /* movsx eax, word [ebp-0x40] */
            ii(0x1011_f35e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_f361, 6); mov(edx, memd[ds, 0x101c_5368]);        /* mov edx, [0x101c5368] */
            ii(0x1011_f367, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_f369, 4); movsx(edx, memw[ss, ebp - 0x3e]);       /* movsx edx, word [ebp-0x3e] */
            ii(0x1011_f36d, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1011_f36f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_f371, 3); mov(memb[ds, eax], 0x2);                /* mov byte [eax], 0x2 */
            ii(0x1011_f374, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_f377, 5); call(0x100b_7f18, -0x6_7464);           /* call 0x100b7f18 */
            ii(0x1011_f37c, 5); call(0x1012_09fc, 0x167b);              /* call 0x101209fc */
            ii(0x1011_f381, 2); test(al, al);                           /* test al, al */
            ii(0x1011_f383, 6); if(jz(0x1011_f469, 0xe0)) goto l_0x1011_f469; /* jz 0x1011f469 */
            ii(0x1011_f389, 4); or(memb[ss, ebp - 0x14], 0x1);          /* or byte [ebp-0x14], 0x1 */
            ii(0x1011_f38d, 3); lea(eax, memd[ss, ebp - 0x54]);         /* lea eax, [ebp-0x54] */
            ii(0x1011_f390, 5); call(Definitions.my_ctor_0x101b_38f8, -0xa_8ca5); /* call 0x100766f0 */
            ii(0x1011_f395, 3); mov(memd[ss, ebp - 0x58], eax);         /* mov [ebp-0x58], eax */
            ii(0x1011_f398, 4); and(memb[ss, ebp - 0x14], -0x2 /* 0xfe */); /* and byte [ebp-0x14], 0xfe */
            ii(0x1011_f39c, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1011_f39e, 4); movsx(ebx, memw[ss, ebp - 0x42]);       /* movsx ebx, word [ebp-0x42] */
            ii(0x1011_f3a2, 4); movsx(edx, memw[ss, ebp - 0x44]);       /* movsx edx, word [ebp-0x44] */
            ii(0x1011_f3a6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_f3a9, 5); call(0x1007_510b, -0xa_a2a3);           /* call 0x1007510b */
            ii(0x1011_f3ae, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_f3b0, 3); lea(eax, memd[ss, ebp - 0x54]);         /* lea eax, [ebp-0x54] */
            ii(0x1011_f3b3, 5); call(0x1007_6630, -0xa_8d88);           /* call 0x10076630 */
            ii(0x1011_f3b8, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1011_f3ba, 5); call(0x1013_ad71, 0x1_b9b2);            /* call 0x1013ad71 */
            ii(0x1011_f3bf, 2); test(al, al);                           /* test al, al */
            ii(0x1011_f3c1, 6); if(jz(0x1011_f45f, 0x98)) goto l_0x1011_f45f; /* jz 0x1011f45f */
            ii(0x1011_f3c7, 3); lea(eax, memd[ss, ebp - 0x54]);         /* lea eax, [ebp-0x54] */
            ii(0x1011_f3ca, 5); call(0x1007_6574, -0xa_8e5b);           /* call 0x10076574 */
            ii(0x1011_f3cf, 4); mov(ax, memw[ds, eax + 0x1a]);          /* mov ax, [eax+0x1a] */
            ii(0x1011_f3d3, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x1011_f3d6, 3); lea(eax, memd[ss, ebp - 0x54]);         /* lea eax, [ebp-0x54] */
            ii(0x1011_f3d9, 5); call(0x1007_6574, -0xa_8e6a);           /* call 0x10076574 */
            ii(0x1011_f3de, 4); mov(ax, memw[ds, eax + 0x1c]);          /* mov ax, [eax+0x1c] */
            ii(0x1011_f3e2, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x1011_f3e5, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1011_f3e9, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_f3ec, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_f3ee, 5); mov(eax, memd[ds, 0x101c_5368]);        /* mov eax, [0x101c5368] */
            ii(0x1011_f3f3, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_f3f5, 4); movsx(edx, memw[ss, ebp - 0x38]);       /* movsx edx, word [ebp-0x38] */
            ii(0x1011_f3f9, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1011_f3fb, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_f3fd, 3); mov(memb[ds, eax], 0x2);                /* mov byte [eax], 0x2 */
            ii(0x1011_f400, 3); lea(eax, memd[ss, ebp - 0x54]);         /* lea eax, [ebp-0x54] */
            ii(0x1011_f403, 5); call(0x1007_6574, -0xa_8e94);           /* call 0x10076574 */
            ii(0x1011_f408, 4); test(memb[ds, eax + 0x12], 0x10);       /* test byte [eax+0x12], 0x10 */
            ii(0x1011_f40c, 2); if(jz(0x1011_f45f, 0x51)) goto l_0x1011_f45f; /* jz 0x1011f45f */
            ii(0x1011_f40e, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x1011_f412, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1011_f415, 5); mov(eax, memd[ds, 0x101c_5368]);        /* mov eax, [0x101c5368] */
            ii(0x1011_f41a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_f41c, 4); movsx(edx, memw[ss, ebp - 0x38]);       /* movsx edx, word [ebp-0x38] */
            ii(0x1011_f420, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1011_f422, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_f424, 4); mov(memb[ds, eax + 0x1], 0x2);          /* mov byte [eax+0x1], 0x2 */
            ii(0x1011_f428, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1011_f42c, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_f42f, 6); mov(edx, memd[ds, 0x101c_5368]);        /* mov edx, [0x101c5368] */
            ii(0x1011_f435, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_f437, 4); movsx(edx, memw[ss, ebp - 0x38]);       /* movsx edx, word [ebp-0x38] */
            ii(0x1011_f43b, 3); mov(eax, memd[ds, eax + 0x4]);          /* mov eax, [eax+0x4] */
            ii(0x1011_f43e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_f440, 3); mov(memb[ds, eax], 0x2);                /* mov byte [eax], 0x2 */
            ii(0x1011_f443, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1011_f447, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_f44a, 6); mov(edx, memd[ds, 0x101c_5368]);        /* mov edx, [0x101c5368] */
            ii(0x1011_f450, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_f452, 4); movsx(edx, memw[ss, ebp - 0x38]);       /* movsx edx, word [ebp-0x38] */
            ii(0x1011_f456, 3); mov(eax, memd[ds, eax + 0x4]);          /* mov eax, [eax+0x4] */
            ii(0x1011_f459, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_f45b, 4); mov(memb[ds, eax + 0x1], 0x2);          /* mov byte [eax+0x1], 0x2 */
        l_0x1011_f45f:
            ii(0x1011_f45f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_f461, 3); lea(eax, memd[ss, ebp - 0x54]);         /* lea eax, [ebp-0x54] */
            ii(0x1011_f464, 5); call(0x1007_5f2c, -0xa_953d);           /* call 0x10075f2c */
        l_0x1011_f469:
            ii(0x1011_f469, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_f46c, 5); call(0x100b_7f18, -0x6_7559);           /* call 0x100b7f18 */
            ii(0x1011_f471, 5); call(0x100c_b490, -0x5_3fe6);           /* call 0x100cb490 */
            ii(0x1011_f476, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1011_f479, 3); fild(memw[ss, ebp - 0x2c]);             /* fild word [ebp-0x2c] */
            ii(0x1011_f47c, 5); call(Definitions.sys_sqrt, 0x4_6bc5);   /* call 0x10166046 */
            ii(0x1011_f481, 5); call(Definitions.sys_round, 0x4_6bf8);  /* call 0x1016607e */
            ii(0x1011_f486, 3); fistp(memd[ss, ebp - 0x5c]);            /* fistp dword [ebp-0x5c] */
            ii(0x1011_f489, 3); mov(eax, memd[ss, ebp - 0x5c]);         /* mov eax, [ebp-0x5c] */
            ii(0x1011_f48c, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1011_f48f, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x1011_f493, 4); movsx(eax, memw[ss, ebp - 0x3c]);       /* movsx eax, word [ebp-0x3c] */
            ii(0x1011_f497, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_f499, 2); if(jnz(0x1011_f4cf, 0x34)) goto l_0x1011_f4cf; /* jnz 0x1011f4cf */
            ii(0x1011_f49b, 4); movsx(eax, memw[ss, ebp - 0x44]);       /* movsx eax, word [ebp-0x44] */
            ii(0x1011_f49f, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_f4a2, 6); mov(edx, memd[ds, 0x101c_5368]);        /* mov edx, [0x101c5368] */
            ii(0x1011_f4a8, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_f4aa, 4); movsx(edx, memw[ss, ebp - 0x42]);       /* movsx edx, word [ebp-0x42] */
            ii(0x1011_f4ae, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1011_f4b0, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_f4b2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_f4b4, 2); mov(al, memb[ds, edx]);                 /* mov al, [edx] */
            ii(0x1011_f4b6, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1011_f4b9, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1011_f4bd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_f4bf, 2); if(jz(0x1011_f4c9, 0x8)) goto l_0x1011_f4c9; /* jz 0x1011f4c9 */
            ii(0x1011_f4c1, 6); test(memw[ss, ebp - 0x20], 0x80);       /* test word [ebp-0x20], 0x80 */
            ii(0x1011_f4c7, 2); if(jz(0x1011_f4cb, 0x2)) goto l_0x1011_f4cb; /* jz 0x1011f4cb */
        l_0x1011_f4c9:
            ii(0x1011_f4c9, 2); jmp(0x1011_f4cf, 0x4); goto l_0x1011_f4cf; /* jmp 0x1011f4cf */
        l_0x1011_f4cb:
            ii(0x1011_f4cb, 4); mov(memb[ss, ebp - 0x10], 0x1);         /* mov byte [ebp-0x10], 0x1 */
        l_0x1011_f4cf:
            ii(0x1011_f4cf, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x1011_f4d2, 3); sub(eax, memd[ss, ebp - 0x3c]);         /* sub eax, [ebp-0x3c] */
            ii(0x1011_f4d5, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x1011_f4d8, 2); jmp(0x1011_f4e0, 0x6); goto l_0x1011_f4e0; /* jmp 0x1011f4e0 */
        l_0x1011_f4da:
            ii(0x1011_f4da, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1011_f4dd, 3); inc(memd[ss, ebp - 0x34]);              /* inc dword [ebp-0x34] */
        l_0x1011_f4e0:
            ii(0x1011_f4e0, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1011_f4e3, 4); cmp(ax, memw[ss, ebp - 0x44]);          /* cmp ax, [ebp-0x44] */
            ii(0x1011_f4e7, 6); if(jge(0x1011_f668, 0x17b)) goto l_0x1011_f668; /* jge 0x1011f668 */
            ii(0x1011_f4ed, 3); mov(eax, memd[ss, ebp - 0x42]);         /* mov eax, [ebp-0x42] */
            ii(0x1011_f4f0, 3); sub(eax, memd[ss, ebp - 0x3c]);         /* sub eax, [ebp-0x3c] */
            ii(0x1011_f4f3, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x1011_f4f6, 3); mov(edx, memd[ss, ebp - 0x34]);         /* mov edx, [ebp-0x34] */
            ii(0x1011_f4f9, 3); sub(edx, memd[ss, ebp - 0x44]);         /* sub edx, [ebp-0x44] */
            ii(0x1011_f4fc, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1011_f4ff, 3); sub(eax, memd[ss, ebp - 0x44]);         /* sub eax, [ebp-0x44] */
            ii(0x1011_f502, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1011_f505, 3); mov(memd[ss, ebp - 0x28], edx);         /* mov [ebp-0x28], edx */
        l_0x1011_f508:
            ii(0x1011_f508, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x1011_f50b, 4); cmp(ax, memw[ss, ebp - 0x42]);          /* cmp ax, [ebp-0x42] */
            ii(0x1011_f50f, 2); if(jg(0x1011_f538, 0x27)) goto l_0x1011_f538; /* jg 0x1011f538 */
            ii(0x1011_f511, 4); movsx(eax, memw[ss, ebp - 0x42]);       /* movsx eax, word [ebp-0x42] */
            ii(0x1011_f515, 4); movsx(edx, memw[ss, ebp - 0x38]);       /* movsx edx, word [ebp-0x38] */
            ii(0x1011_f519, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1011_f51b, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1011_f51d, 4); movsx(eax, memw[ss, ebp - 0x42]);       /* movsx eax, word [ebp-0x42] */
            ii(0x1011_f521, 4); movsx(edx, memw[ss, ebp - 0x38]);       /* movsx edx, word [ebp-0x38] */
            ii(0x1011_f525, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1011_f527, 3); imul(edx, ebx);                         /* imul edx, ebx */
            ii(0x1011_f52a, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1011_f52e, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_f530, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1011_f534, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_f536, 2); if(jg(0x1011_f53a, 0x2)) goto l_0x1011_f53a; /* jg 0x1011f53a */
        l_0x1011_f538:
            ii(0x1011_f538, 2); jmp(0x1011_f542, 0x8); goto l_0x1011_f542; /* jmp 0x1011f542 */
        l_0x1011_f53a:
            ii(0x1011_f53a, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x1011_f53d, 3); inc(memd[ss, ebp - 0x38]);              /* inc dword [ebp-0x38] */
            ii(0x1011_f540, 2); jmp(0x1011_f508, -0x3a); goto l_0x1011_f508; /* jmp 0x1011f508 */
        l_0x1011_f542:
            ii(0x1011_f542, 4); cmp(memb[ss, ebp - 0x10], 0);           /* cmp byte [ebp-0x10], 0x0 */
            ii(0x1011_f546, 2); if(jnz(0x1011_f551, 0x9)) goto l_0x1011_f551; /* jnz 0x1011f551 */
            ii(0x1011_f548, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x1011_f54b, 4); cmp(ax, memw[ss, ebp - 0x42]);          /* cmp ax, [ebp-0x42] */
            ii(0x1011_f54f, 2); if(jle(0x1011_f553, 0x2)) goto l_0x1011_f553; /* jle 0x1011f553 */
        l_0x1011_f551:
            ii(0x1011_f551, 2); jmp(0x1011_f5bd, 0x6a); goto l_0x1011_f5bd; /* jmp 0x1011f5bd */
        l_0x1011_f553:
            ii(0x1011_f553, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x1011_f556, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_f558, 3); sub(eax, memd[ss, ebp - 0x34]);         /* sub eax, [ebp-0x34] */
            ii(0x1011_f55b, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_f55e, 3); mov(eax, memd[ss, ebp - 0x42]);         /* mov eax, [ebp-0x42] */
            ii(0x1011_f561, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_f563, 3); sub(eax, memd[ss, ebp - 0x38]);         /* sub eax, [ebp-0x38] */
            ii(0x1011_f566, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_f569, 4); movsx(edx, memw[ss, ebp - 0x38]);       /* movsx edx, word [ebp-0x38] */
            ii(0x1011_f56d, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1011_f571, 5); call(0x1011_f0b6, -0x4c0);              /* call 0x1011f0b6 */
            ii(0x1011_f576, 2); test(al, al);                           /* test al, al */
            ii(0x1011_f578, 2); if(jz(0x1011_f57e, 0x4)) goto l_0x1011_f57e; /* jz 0x1011f57e */
            ii(0x1011_f57a, 4); mov(memb[ss, ebp - 0x10], 0x1);         /* mov byte [ebp-0x10], 0x1 */
        l_0x1011_f57e:
            ii(0x1011_f57e, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1011_f582, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1011_f586, 5); call(0x1011_f0b6, -0x4d5);              /* call 0x1011f0b6 */
            ii(0x1011_f58b, 2); test(al, al);                           /* test al, al */
            ii(0x1011_f58d, 2); if(jz(0x1011_f593, 0x4)) goto l_0x1011_f593; /* jz 0x1011f593 */
            ii(0x1011_f58f, 4); mov(memb[ss, ebp - 0x10], 0x1);         /* mov byte [ebp-0x10], 0x1 */
        l_0x1011_f593:
            ii(0x1011_f593, 4); movsx(edx, memw[ss, ebp - 0x38]);       /* movsx edx, word [ebp-0x38] */
            ii(0x1011_f597, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1011_f59b, 5); call(0x1011_f0b6, -0x4ea);              /* call 0x1011f0b6 */
            ii(0x1011_f5a0, 2); test(al, al);                           /* test al, al */
            ii(0x1011_f5a2, 2); if(jz(0x1011_f5a8, 0x4)) goto l_0x1011_f5a8; /* jz 0x1011f5a8 */
            ii(0x1011_f5a4, 4); mov(memb[ss, ebp - 0x10], 0x1);         /* mov byte [ebp-0x10], 0x1 */
        l_0x1011_f5a8:
            ii(0x1011_f5a8, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1011_f5ac, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1011_f5b0, 5); call(0x1011_f0b6, -0x4ff);              /* call 0x1011f0b6 */
            ii(0x1011_f5b5, 2); test(al, al);                           /* test al, al */
            ii(0x1011_f5b7, 2); if(jz(0x1011_f5bd, 0x4)) goto l_0x1011_f5bd; /* jz 0x1011f5bd */
            ii(0x1011_f5b9, 4); mov(memb[ss, ebp - 0x10], 0x1);         /* mov byte [ebp-0x10], 0x1 */
        l_0x1011_f5bd:
            ii(0x1011_f5bd, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x1011_f5c0, 3); inc(memd[ss, ebp - 0x38]);              /* inc dword [ebp-0x38] */
            ii(0x1011_f5c3, 3); mov(eax, memd[ss, ebp - 0x42]);         /* mov eax, [ebp-0x42] */
            ii(0x1011_f5c6, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_f5c8, 3); sub(eax, memd[ss, ebp - 0x38]);         /* sub eax, [ebp-0x38] */
            ii(0x1011_f5cb, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1011_f5ce, 4); movsx(eax, memw[ss, ebp - 0x38]);       /* movsx eax, word [ebp-0x38] */
            ii(0x1011_f5d2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_f5d4, 2); if(jge(0x1011_f5dd, 0x7)) goto l_0x1011_f5dd; /* jge 0x1011f5dd */
            ii(0x1011_f5d6, 7); mov(memd[ss, ebp - 0x38], 0);           /* mov dword [ebp-0x38], 0x0 */
        l_0x1011_f5dd:
            ii(0x1011_f5dd, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x1011_f5e2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_f5e5, 4); movsx(edx, memw[ss, ebp - 0x24]);       /* movsx edx, word [ebp-0x24] */
            ii(0x1011_f5e9, 1); dec(eax);                               /* dec eax */
            ii(0x1011_f5ea, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_f5ec, 2); if(jle(0x1011_f5f8, 0xa)) goto l_0x1011_f5f8; /* jle 0x1011f5f8 */
            ii(0x1011_f5ee, 6); mov(ax, memw[ds, 0x101c_8174]);         /* mov ax, [0x101c8174] */
            ii(0x1011_f5f4, 1); dec(eax);                               /* dec eax */
            ii(0x1011_f5f5, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
        l_0x1011_f5f8:
            ii(0x1011_f5f8, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1011_f5fb, 1); inc(eax);                               /* inc eax */
            ii(0x1011_f5fc, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x1011_f5ff, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x1011_f602, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_f604, 3); sub(eax, memd[ss, ebp - 0x30]);         /* sub eax, [ebp-0x30] */
            ii(0x1011_f607, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_f60a, 2); jmp(0x1011_f612, 0x6); goto l_0x1011_f612; /* jmp 0x1011f612 */
        l_0x1011_f60c:
            ii(0x1011_f60c, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x1011_f60f, 3); inc(memd[ss, ebp - 0x38]);              /* inc dword [ebp-0x38] */
        l_0x1011_f612:
            ii(0x1011_f612, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x1011_f615, 4); cmp(ax, memw[ss, ebp - 0x24]);          /* cmp ax, [ebp-0x24] */
            ii(0x1011_f619, 2); if(jg(0x1011_f663, 0x48)) goto l_0x1011_f663; /* jg 0x1011f663 */
            ii(0x1011_f61b, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1011_f61f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_f621, 2); if(jl(0x1011_f63c, 0x19)) goto l_0x1011_f63c; /* jl 0x1011f63c */
            ii(0x1011_f623, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x1011_f627, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1011_f62a, 5); mov(eax, memd[ds, 0x101c_5368]);        /* mov eax, [0x101c5368] */
            ii(0x1011_f62f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_f631, 4); movsx(edx, memw[ss, ebp - 0x38]);       /* movsx edx, word [ebp-0x38] */
            ii(0x1011_f635, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1011_f637, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_f639, 3); mov(memb[ds, eax], 0x42);               /* mov byte [eax], 0x42 */
        l_0x1011_f63c:
            ii(0x1011_f63c, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_f63f, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x1011_f646, 2); if(jge(0x1011_f661, 0x19)) goto l_0x1011_f661; /* jge 0x1011f661 */
            ii(0x1011_f648, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x1011_f64c, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1011_f64f, 5); mov(eax, memd[ds, 0x101c_5368]);        /* mov eax, [0x101c5368] */
            ii(0x1011_f654, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_f656, 4); movsx(edx, memw[ss, ebp - 0x38]);       /* movsx edx, word [ebp-0x38] */
            ii(0x1011_f65a, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1011_f65c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_f65e, 3); mov(memb[ds, eax], 0x42);               /* mov byte [eax], 0x42 */
        l_0x1011_f661:
            ii(0x1011_f661, 2); jmp(0x1011_f60c, -0x57); goto l_0x1011_f60c; /* jmp 0x1011f60c */
        l_0x1011_f663:
            ii(0x1011_f663, 5); jmp(0x1011_f4da, -0x18e); goto l_0x1011_f4da; /* jmp 0x1011f4da */
        l_0x1011_f668:
            ii(0x1011_f668, 3); mov(al, memb[ss, ebp - 0x10]);          /* mov al, [ebp-0x10] */
            ii(0x1011_f66b, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
            ii(0x1011_f66e, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1011_f671, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_f673, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_f674, 1); pop(edi);                               /* pop edi */
            ii(0x1011_f675, 1); pop(esi);                               /* pop esi */
            ii(0x1011_f676, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_f677, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_f678, 1); ret();                                  /* ret */
        }
    }
}
