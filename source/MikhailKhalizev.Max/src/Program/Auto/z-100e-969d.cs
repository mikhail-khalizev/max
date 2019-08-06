using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("23a41124-33ae-467a-ab9f-49ddfa746a13")]
        public void Method_100e_969d()
        {
            ii(0x100e_969d, 5); pushd(0x5c);                            /* push 0x5c */
            ii(0x100e_96a2, 5); calld(Definitions.sys_check_available_stack_size, 0x7c6ab); /* call 0x10165d52 */
            ii(0x100e_96a7, 1); pushd(esi);                             /* push esi */
            ii(0x100e_96a8, 1); pushd(edi);                             /* push edi */
            ii(0x100e_96a9, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_96aa, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_96ac, 6); sub(esp, 0x4c);                         /* sub esp, 0x4c */
            ii(0x100e_96b2, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_96b5, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_96b8, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100e_96bb, 3); mov(memd_a32[ss, ebp - 0xc], ecx);      /* mov [ebp-0xc], ecx */
            ii(0x100e_96be, 4); or(memb_a32[ss, ebp - 0x18], 0x1);      /* or byte [ebp-0x18], 0x1 */
            ii(0x100e_96c2, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100e_96c5, 5); calld(Definitions.my_string_ctor, 0x5841e); /* call 0x10141ae8 */
            ii(0x100e_96ca, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100e_96cd, 4); and(memb_a32[ss, ebp - 0x18], -0x2 /* 0xfe */); /* and byte [ebp-0x18], 0xfe */
            ii(0x100e_96d1, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_96d5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_96d7, 2); if(jzd(0x100e_96df, 0x6)) goto l_0x100e_96df; /* jz 0x100e96df */
            ii(0x100e_96d9, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100e_96dd, 2); if(jnzd(0x100e_96f5, 0x16)) goto l_0x100e_96f5; /* jnz 0x100e96f5 */
        l_0x100e_96df:
            ii(0x100e_96df, 7); mov(memd_a32[ss, ebp - 0x24], 0);       /* mov dword [ebp-0x24], 0x0 */
            ii(0x100e_96e6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_96e8, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100e_96eb, 5); calld(Definitions.my_string_dtor, 0x5843a); /* call 0x10141b2a */
            ii(0x100e_96f0, 5); jmpd(0x100e_9adc, 0x3e7); goto l_0x100e_9adc; /* jmp 0x100e9adc */
        l_0x100e_96f5:
            ii(0x100e_96f5, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x100e_96fc, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_96ff, 5); mov(memw_a32[ds, eax], 0);              /* mov word [eax], 0x0 */
            ii(0x100e_9704, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
        l_0x100e_9708:
            ii(0x100e_9708, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_970b, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100e_970e, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100e_9711, 5); calld(Definitions.my_string_clear, 0x587ff); /* call 0x10141f15 */
        l_0x100e_9716:
            ii(0x100e_9716, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_9719, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100e_971b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_9720, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_9722, 2); if(jzd(0x100e_972c, 0x8)) goto l_0x100e_972c; /* jz 0x100e972c */
            ii(0x100e_9724, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_9727, 3); cmp(memb_a32[ds, eax], 0x20);           /* cmp byte [eax], 0x20 */
            ii(0x100e_972a, 2); if(jnzd(0x100e_972e, 0x2)) goto l_0x100e_972e; /* jnz 0x100e972e */
        l_0x100e_972c:
            ii(0x100e_972c, 2); jmpd(0x100e_9736, 0x8); goto l_0x100e_9736; /* jmp 0x100e9736 */
        l_0x100e_972e:
            ii(0x100e_972e, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_9731, 3); cmp(memb_a32[ds, eax], 0xa);            /* cmp byte [eax], 0xa */
            ii(0x100e_9734, 2); if(jnzd(0x100e_9738, 0x2)) goto l_0x100e_9738; /* jnz 0x100e9738 */
        l_0x100e_9736:
            ii(0x100e_9736, 2); jmpd(0x100e_9763, 0x2b); goto l_0x100e_9763; /* jmp 0x100e9763 */
        l_0x100e_9738:
            ii(0x100e_9738, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_973b, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100e_973d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_9742, 3); cmp(eax, 0xd);                          /* cmp eax, 0xd */
            ii(0x100e_9745, 2); if(jnzd(0x100e_974f, 0x8)) goto l_0x100e_974f; /* jnz 0x100e974f */
            ii(0x100e_9747, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_974a, 3); inc(memd_a32[ss, ebp - 0x2c]);          /* inc dword [ebp-0x2c] */
            ii(0x100e_974d, 2); jmpd(0x100e_9761, 0x12); goto l_0x100e_9761; /* jmp 0x100e9761 */
        l_0x100e_974f:
            ii(0x100e_974f, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_9752, 3); inc(memd_a32[ss, ebp - 0x2c]);          /* inc dword [ebp-0x2c] */
            ii(0x100e_9755, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_9757, 2); mov(dl, memb_a32[ds, eax]);             /* mov dl, [eax] */
            ii(0x100e_9759, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100e_975c, 5); calld(Definitions.my_string_append_char, 0x58689); /* call 0x10141dea */
        l_0x100e_9761:
            ii(0x100e_9761, 2); jmpd(0x100e_9716, -0x4d); goto l_0x100e_9716; /* jmp 0x100e9716 */
        l_0x100e_9763:
            ii(0x100e_9763, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100e_9766, 5); calld(0x100e_aef0, 0x1785);             /* call 0x100eaef0 */
            ii(0x100e_976b, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100e_976e, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100e_9771, 5); calld(Definitions.my_strobj_c_str_v2, -0x5ffae); /* call 0x100897c8 */
            ii(0x100e_9776, 6); calld_abs(memd_a32[ds, 0x101b_ddf4]);   /* call dword [0x101bddf4] */
            ii(0x100e_977c, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100e_9780, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100e_9782, 2); if(jled(0x100e_978d, 0x9)) goto l_0x100e_978d; /* jle 0x100e978d */
            ii(0x100e_9784, 4); movsx(eax, memw_a32[ss, ebp - 0x30]);   /* movsx eax, word [ebp-0x30] */
            ii(0x100e_9788, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100e_978b, 2); if(jged(0x100e_978f, 0x2)) goto l_0x100e_978f; /* jge 0x100e978f */
        l_0x100e_978d:
            ii(0x100e_978d, 2); jmpd(0x100e_979e, 0xf); goto l_0x100e_979e; /* jmp 0x100e979e */
        l_0x100e_978f:
            ii(0x100e_978f, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100e_9793, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_9796, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100e_9799, 1); dec(edx);                               /* dec edx */
            ii(0x100e_979a, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100e_979c, 2); if(jld(0x100e_97a3, 0x5)) goto l_0x100e_97a3; /* jl 0x100e97a3 */
        l_0x100e_979e:
            ii(0x100e_979e, 5); jmpd(0x100e_990b, 0x168); goto l_0x100e_990b; /* jmp 0x100e990b */
        l_0x100e_97a3:
            ii(0x100e_97a3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_97a6, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100e_97a9, 4); cmp(memb_a32[ss, ebp - 0x14], 0);       /* cmp byte [ebp-0x14], 0x0 */
            ii(0x100e_97ad, 6); if(jnzd(0x100e_9842, 0x8f)) goto l_0x100e_9842; /* jnz 0x100e9842 */
            ii(0x100e_97b3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_97b6, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100e_97b9, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_97bc, 3); sub(eax, 0x4);                          /* sub eax, 0x4 */
            ii(0x100e_97bf, 3); add(eax, memd_a32[ss, ebp - 0x28]);     /* add eax, [ebp-0x28] */
            ii(0x100e_97c2, 5); calld(Definitions.my_strobj_c_str_v2, -0x5ffff); /* call 0x100897c8 */
            ii(0x100e_97c7, 6); calld_abs(memd_a32[ds, 0x101b_ddf4]);   /* call dword [0x101bddf4] */
            ii(0x100e_97cd, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_97cf, 5); mov(eax, 0x20);                         /* mov eax, 0x20 */
            ii(0x100e_97d4, 6); calld_abs(memd_a32[ds, 0x101b_ddf8]);   /* call dword [0x101bddf8] */
            ii(0x100e_97da, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_97dc, 3); sub(memd_a32[ss, ebp - 0x34], eax);     /* sub [ebp-0x34], eax */
            ii(0x100e_97df, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100e_97e3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_97e6, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100e_97e9, 1); dec(edx);                               /* dec edx */
            ii(0x100e_97ea, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100e_97ec, 2); if(jged(0x100e_9842, 0x54)) goto l_0x100e_9842; /* jge 0x100e9842 */
            ii(0x100e_97ee, 5); mov(eax, 0x2d);                         /* mov eax, 0x2d */
            ii(0x100e_97f3, 6); calld_abs(memd_a32[ds, 0x101b_ddf8]);   /* call dword [0x101bddf8] */
            ii(0x100e_97f9, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100e_97fb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_97fd, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100e_9800, 5); calld(Definitions.my_string_get, 0x58a8d); /* call 0x10142292 */
            ii(0x100e_9805, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100e_9807, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_980c, 6); calld_abs(memd_a32[ds, 0x101b_ddf8]);   /* call dword [0x101bddf8] */
            ii(0x100e_9812, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x100e_9814, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100e_9819, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100e_981c, 5); calld(Definitions.my_string_get, 0x58a71); /* call 0x10142292 */
            ii(0x100e_9821, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100e_9823, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_9828, 6); calld_abs(memd_a32[ds, 0x101b_ddf8]);   /* call dword [0x101bddf8] */
            ii(0x100e_982e, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x100e_9830, 3); mov(memd_a32[ss, ebp - 0x38], ebx);     /* mov [ebp-0x38], ebx */
            ii(0x100e_9833, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100e_9836, 4); cmp(ax, memw_a32[ss, ebp - 0x38]);      /* cmp ax, [ebp-0x38] */
            ii(0x100e_983a, 2); if(jged(0x100e_9842, 0x6)) goto l_0x100e_9842; /* jge 0x100e9842 */
            ii(0x100e_983c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_983f, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
        l_0x100e_9842:
            ii(0x100e_9842, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100e_9845, 5); calld(Definitions.my_strobj_c_str_v2, -0x60082); /* call 0x100897c8 */
            ii(0x100e_984a, 6); calld_abs(memd_a32[ds, 0x101b_ddf4]);   /* call dword [0x101bddf4] */
            ii(0x100e_9850, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_9852, 5); mov(eax, 0x2d);                         /* mov eax, 0x2d */
            ii(0x100e_9857, 6); calld_abs(memd_a32[ds, 0x101b_ddf8]);   /* call dword [0x101bddf8] */
            ii(0x100e_985d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_985f, 3); sub(memd_a32[ss, ebp - 0x34], eax);     /* sub [ebp-0x34], eax */
            ii(0x100e_9862, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100e_9865, 3); sub(eax, 0x2);                          /* sub eax, 0x2 */
            ii(0x100e_9868, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100e_986b, 2); jmpd(0x100e_9873, 0x6); goto l_0x100e_9873; /* jmp 0x100e9873 */
        l_0x100e_986d:
            ii(0x100e_986d, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x100e_9870, 3); inc(memd_a32[ss, ebp - 0x3c]);          /* inc dword [ebp-0x3c] */
        l_0x100e_9873:
            ii(0x100e_9873, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x100e_9876, 4); cmp(ax, memw_a32[ss, ebp - 0x30]);      /* cmp ax, [ebp-0x30] */
            ii(0x100e_987a, 2); if(jged(0x100e_989a, 0x1e)) goto l_0x100e_989a; /* jge 0x100e989a */
            ii(0x100e_987c, 4); movsx(edx, memw_a32[ss, ebp - 0x3c]);   /* movsx edx, word [ebp-0x3c] */
            ii(0x100e_9880, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100e_9883, 5); calld(Definitions.my_string_get, 0x58a0a); /* call 0x10142292 */
            ii(0x100e_9888, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100e_988a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_988f, 6); calld_abs(memd_a32[ds, 0x101b_ddf8]);   /* call dword [0x101bddf8] */
            ii(0x100e_9895, 3); add(memd_a32[ss, ebp - 0x34], eax);     /* add [ebp-0x34], eax */
            ii(0x100e_9898, 2); jmpd(0x100e_986d, -0x2d); goto l_0x100e_986d; /* jmp 0x100e986d */
        l_0x100e_989a:
            ii(0x100e_989a, 4); add(memd_a32[ss, ebp - 0x30], -0x2 /* 0xfe */); /* add dword [ebp-0x30], 0xfffffffe */
        l_0x100e_989e:
            ii(0x100e_989e, 4); movsx(eax, memw_a32[ss, ebp - 0x30]);   /* movsx eax, word [ebp-0x30] */
            ii(0x100e_98a2, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100e_98a5, 2); if(jled(0x100e_98af, 0x8)) goto l_0x100e_98af; /* jle 0x100e98af */
            ii(0x100e_98a7, 4); movsx(eax, memw_a32[ss, ebp - 0x34]);   /* movsx eax, word [ebp-0x34] */
            ii(0x100e_98ab, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_98ad, 2); if(jld(0x100e_98b1, 0x2)) goto l_0x100e_98b1; /* jl 0x100e98b1 */
        l_0x100e_98af:
            ii(0x100e_98af, 2); jmpd(0x100e_98d5, 0x24); goto l_0x100e_98d5; /* jmp 0x100e98d5 */
        l_0x100e_98b1:
            ii(0x100e_98b1, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100e_98b4, 3); dec(memd_a32[ss, ebp - 0x30]);          /* dec dword [ebp-0x30] */
            ii(0x100e_98b7, 4); movsx(edx, memw_a32[ss, ebp - 0x30]);   /* movsx edx, word [ebp-0x30] */
            ii(0x100e_98bb, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100e_98be, 5); calld(Definitions.my_string_get, 0x589cf); /* call 0x10142292 */
            ii(0x100e_98c3, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100e_98c5, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_98ca, 6); calld_abs(memd_a32[ds, 0x101b_ddf8]);   /* call dword [0x101bddf8] */
            ii(0x100e_98d0, 3); add(memd_a32[ss, ebp - 0x34], eax);     /* add [ebp-0x34], eax */
            ii(0x100e_98d3, 2); jmpd(0x100e_989e, -0x37); goto l_0x100e_989e; /* jmp 0x100e989e */
        l_0x100e_98d5:
            ii(0x100e_98d5, 4); movsx(eax, memw_a32[ss, ebp - 0x30]);   /* movsx eax, word [ebp-0x30] */
            ii(0x100e_98d9, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100e_98dc, 2); if(jled(0x100e_990b, 0x2d)) goto l_0x100e_990b; /* jle 0x100e990b */
            ii(0x100e_98de, 4); movsx(eax, memw_a32[ss, ebp - 0x30]);   /* movsx eax, word [ebp-0x30] */
            ii(0x100e_98e2, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100e_98e5, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_98e7, 3); mov(memd_a32[ss, ebp - 0x2c], edx);     /* mov [ebp-0x2c], edx */
            ii(0x100e_98ea, 4); movsx(edx, memw_a32[ss, ebp - 0x30]);   /* movsx edx, word [ebp-0x30] */
            ii(0x100e_98ee, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100e_98f1, 5); calld(Definitions.my_string_get, 0x5899c); /* call 0x10142292 */
            ii(0x100e_98f6, 3); mov(memb_a32[ds, eax], 0x2d);           /* mov byte [eax], 0x2d */
            ii(0x100e_98f9, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100e_98fc, 1); inc(eax);                               /* inc eax */
            ii(0x100e_98fd, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_9900, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100e_9903, 5); calld(Definitions.my_string_get, 0x5898a); /* call 0x10142292 */
            ii(0x100e_9908, 3); mov(memb_a32[ds, eax], 0);              /* mov byte [eax], 0x0 */
        l_0x100e_990b:
            ii(0x100e_990b, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_990e, 3); cmp(memb_a32[ds, eax], 0x20);           /* cmp byte [eax], 0x20 */
            ii(0x100e_9911, 2); if(jnzd(0x100e_9946, 0x33)) goto l_0x100e_9946; /* jnz 0x100e9946 */
        l_0x100e_9913:
            ii(0x100e_9913, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_9916, 3); cmp(memb_a32[ds, eax], 0x20);           /* cmp byte [eax], 0x20 */
            ii(0x100e_9919, 2); if(jnzd(0x100e_9923, 0x8)) goto l_0x100e_9923; /* jnz 0x100e9923 */
            ii(0x100e_991b, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_991e, 3); inc(memd_a32[ss, ebp - 0x2c]);          /* inc dword [ebp-0x2c] */
            ii(0x100e_9921, 2); jmpd(0x100e_9913, -0x10); goto l_0x100e_9913; /* jmp 0x100e9913 */
        l_0x100e_9923:
            ii(0x100e_9923, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_9926, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100e_9928, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_992d, 3); cmp(eax, 0xd);                          /* cmp eax, 0xd */
            ii(0x100e_9930, 2); if(jnzd(0x100e_9938, 0x6)) goto l_0x100e_9938; /* jnz 0x100e9938 */
            ii(0x100e_9932, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_9935, 3); inc(memd_a32[ss, ebp - 0x2c]);          /* inc dword [ebp-0x2c] */
        l_0x100e_9938:
            ii(0x100e_9938, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_993b, 3); cmp(memb_a32[ds, eax], 0xa);            /* cmp byte [eax], 0xa */
            ii(0x100e_993e, 2); if(jnzd(0x100e_9946, 0x6)) goto l_0x100e_9946; /* jnz 0x100e9946 */
            ii(0x100e_9940, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_9943, 3); inc(memd_a32[ss, ebp - 0x2c]);          /* inc dword [ebp-0x2c] */
        l_0x100e_9946:
            ii(0x100e_9946, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_9949, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100e_994b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_9950, 3); cmp(eax, 0xd);                          /* cmp eax, 0xd */
            ii(0x100e_9953, 2); if(jnzd(0x100e_995b, 0x6)) goto l_0x100e_995b; /* jnz 0x100e995b */
            ii(0x100e_9955, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_9958, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x100e_995b:
            ii(0x100e_995b, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_995e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_9961, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_9964, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100e_9966, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_996b, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x100e_996e, 2); if(jnzd(0x100e_9976, 0x6)) goto l_0x100e_9976; /* jnz 0x100e9976 */
            ii(0x100e_9970, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_9973, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x100e_9976:
            ii(0x100e_9976, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_9979, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100e_997c, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x100e_9980, 2); if(jged(0x100e_99cb, 0x49)) goto l_0x100e_99cb; /* jge 0x100e99cb */
            ii(0x100e_9982, 4); cmp(memb_a32[ss, ebp - 0x14], 0);       /* cmp byte [ebp-0x14], 0x0 */
            ii(0x100e_9986, 2); if(jnzd(0x100e_99c9, 0x41)) goto l_0x100e_99c9; /* jnz 0x100e99c9 */
            ii(0x100e_9988, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_998b, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100e_998e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_9991, 3); sub(eax, 0x4);                          /* sub eax, 0x4 */
            ii(0x100e_9994, 3); add(eax, memd_a32[ss, ebp - 0x28]);     /* add eax, [ebp-0x28] */
            ii(0x100e_9997, 5); calld(Definitions.my_strobj_c_str_v2, -0x601d4); /* call 0x100897c8 */
            ii(0x100e_999c, 6); calld_abs(memd_a32[ds, 0x101b_ddf4]);   /* call dword [0x101bddf4] */
            ii(0x100e_99a2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_99a4, 5); mov(eax, 0x20);                         /* mov eax, 0x20 */
            ii(0x100e_99a9, 6); calld_abs(memd_a32[ds, 0x101b_ddf8]);   /* call dword [0x101bddf8] */
            ii(0x100e_99af, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_99b1, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100e_99b4, 5); calld(Definitions.my_strobj_c_str_v2, -0x601f1); /* call 0x100897c8 */
            ii(0x100e_99b9, 6); calld_abs(memd_a32[ds, 0x101b_ddf4]);   /* call dword [0x101bddf4] */
            ii(0x100e_99bf, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_99c1, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_99c5, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_99c7, 2); if(jled(0x100e_99cb, 0x2)) goto l_0x100e_99cb; /* jle 0x100e99cb */
        l_0x100e_99c9:
            ii(0x100e_99c9, 2); jmpd(0x100e_99d0, 0x5); goto l_0x100e_99d0; /* jmp 0x100e99d0 */
        l_0x100e_99cb:
            ii(0x100e_99cb, 5); jmpd(0x100e_9a6c, 0x9c); goto l_0x100e_9a6c; /* jmp 0x100e9a6c */
        l_0x100e_99d0:
            ii(0x100e_99d0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_99d3, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100e_99d6, 1); inc(eax);                               /* inc eax */
            ii(0x100e_99d7, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x100e_99da, 5); mov(ebx, 0x101b_5c10);                  /* mov ebx, 0x101b5c10 */
            ii(0x100e_99df, 3); mov(edx, memd_a32[ss, ebp - 0x40]);     /* mov edx, [ebp-0x40] */
            ii(0x100e_99e2, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x100e_99e5, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_99e8, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100e_99eb, 5); calld(Definitions.sys_new_arr, 0x7c620); /* call 0x10166010 */
            ii(0x100e_99f0, 5); calld(Definitions.sys_call_ctor_arr, 0x8840a); /* call 0x10171dff */
            ii(0x100e_99f5, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x100e_99f8, 7); mov(memd_a32[ss, ebp - 0x48], 0);       /* mov dword [ebp-0x48], 0x0 */
            ii(0x100e_99ff, 2); jmpd(0x100e_9a07, 0x6); goto l_0x100e_9a07; /* jmp 0x100e9a07 */
        l_0x100e_9a01:
            ii(0x100e_9a01, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100e_9a04, 3); inc(memd_a32[ss, ebp - 0x48]);          /* inc dword [ebp-0x48] */
        l_0x100e_9a07:
            ii(0x100e_9a07, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100e_9a0a, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100e_9a0d, 3); cmp(ax, memw_a32[ds, edx]);             /* cmp ax, [edx] */
            ii(0x100e_9a10, 2); if(jged(0x100e_9a2f, 0x1d)) goto l_0x100e_9a2f; /* jge 0x100e9a2f */
            ii(0x100e_9a12, 4); movsx(eax, memw_a32[ss, ebp - 0x48]);   /* movsx eax, word [ebp-0x48] */
            ii(0x100e_9a16, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_9a19, 3); mov(edx, memd_a32[ss, ebp - 0x28]);     /* mov edx, [ebp-0x28] */
            ii(0x100e_9a1c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_9a1e, 4); movsx(eax, memw_a32[ss, ebp - 0x48]);   /* movsx eax, word [ebp-0x48] */
            ii(0x100e_9a22, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_9a25, 3); add(eax, memd_a32[ss, ebp - 0x44]);     /* add eax, [ebp-0x44] */
            ii(0x100e_9a28, 5); calld(0x1014_2246, 0x58819);            /* call 0x10142246 */
            ii(0x100e_9a2d, 2); jmpd(0x100e_9a01, -0x2e); goto l_0x100e_9a01; /* jmp 0x100e9a01 */
        l_0x100e_9a2f:
            ii(0x100e_9a2f, 4); cmp(memd_a32[ss, ebp - 0x28], 0);       /* cmp dword [ebp-0x28], 0x0 */
            ii(0x100e_9a33, 2); if(jzd(0x100e_9a47, 0x12)) goto l_0x100e_9a47; /* jz 0x100e9a47 */
            ii(0x100e_9a35, 5); mov(edx, 0x101b_5c10);                  /* mov edx, 0x101b5c10 */
            ii(0x100e_9a3a, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100e_9a3d, 5); calld(Definitions.sys_call_dtor_arr, 0x7c576); /* call 0x10165fb8 */
            ii(0x100e_9a42, 5); calld(Definitions.sys_delete_arr, 0x7c591); /* call 0x10165fd8 */
        l_0x100e_9a47:
            ii(0x100e_9a47, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x100e_9a4a, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100e_9a4d, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x100e_9a50, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_9a53, 3); mov(bx, memw_a32[ds, eax]);             /* mov bx, [eax] */
            ii(0x100e_9a56, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_9a59, 3); inc(memw_a32[ds, eax]);                 /* inc word [eax] */
            ii(0x100e_9a5c, 3); movsx(eax, bx);                         /* movsx eax, bx */
            ii(0x100e_9a5f, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_9a62, 3); add(eax, memd_a32[ss, ebp - 0x28]);     /* add eax, [ebp-0x28] */
            ii(0x100e_9a65, 5); calld(0x1014_2246, 0x587dc);            /* call 0x10142246 */
            ii(0x100e_9a6a, 2); jmpd(0x100e_9a9c, 0x30); goto l_0x100e_9a9c; /* jmp 0x100e9a9c */
        l_0x100e_9a6c:
            ii(0x100e_9a6c, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x100e_9a71, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_9a74, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100e_9a77, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_9a7a, 3); sub(eax, 0x4);                          /* sub eax, 0x4 */
            ii(0x100e_9a7d, 3); add(eax, memd_a32[ss, ebp - 0x28]);     /* add eax, [ebp-0x28] */
            ii(0x100e_9a80, 5); calld(Definitions.my_string_append_char, 0x58365); /* call 0x10141dea */
            ii(0x100e_9a85, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x100e_9a88, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_9a8b, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100e_9a8e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_9a91, 3); sub(eax, 0x4);                          /* sub eax, 0x4 */
            ii(0x100e_9a94, 3); add(eax, memd_a32[ss, ebp - 0x28]);     /* add eax, [ebp-0x28] */
            ii(0x100e_9a97, 5); calld(Definitions.my_string_append_string, 0x581ed); /* call 0x10141c89 */
        l_0x100e_9a9c:
            ii(0x100e_9a9c, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_9a9f, 3); cmp(memb_a32[ds, eax], 0xa);            /* cmp byte [eax], 0xa */
            ii(0x100e_9aa2, 2); if(jnzd(0x100e_9aaa, 0x6)) goto l_0x100e_9aaa; /* jnz 0x100e9aaa */
            ii(0x100e_9aa4, 4); mov(memb_a32[ss, ebp - 0x4c], 0x1);     /* mov byte [ebp-0x4c], 0x1 */
            ii(0x100e_9aa8, 2); jmpd(0x100e_9aae, 0x4); goto l_0x100e_9aae; /* jmp 0x100e9aae */
        l_0x100e_9aaa:
            ii(0x100e_9aaa, 4); mov(memb_a32[ss, ebp - 0x4c], 0);       /* mov byte [ebp-0x4c], 0x0 */
        l_0x100e_9aae:
            ii(0x100e_9aae, 3); mov(al, memb_a32[ss, ebp - 0x4c]);      /* mov al, [ebp-0x4c] */
            ii(0x100e_9ab1, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x100e_9ab4, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_9ab7, 3); cmp(memb_a32[ds, eax], 0);              /* cmp byte [eax], 0x0 */
            ii(0x100e_9aba, 6); if(jnzd(0x100e_9708, -0x3b8)) goto l_0x100e_9708; /* jnz 0x100e9708 */
            ii(0x100e_9ac0, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100e_9ac3, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100e_9ac6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_9ac8, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100e_9acb, 5); calld(Definitions.my_string_dtor, 0x5805a); /* call 0x10141b2a */
            ii(0x100e_9ad0, 2); jmpd(0x100e_9adc, 0xa); goto l_0x100e_9adc; /* jmp 0x100e9adc */
        //  ii(0x100e_9ad2, 10); Недостижимый код.
        l_0x100e_9adc:
            ii(0x100e_9adc, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_9adf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_9ae1, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_9ae2, 1); popd(edi);                              /* pop edi */
            ii(0x100e_9ae3, 1); popd(esi);                              /* pop esi */
            ii(0x100e_9ae4, 1); retd(); return;                         /* ret */
        }
    }
}
