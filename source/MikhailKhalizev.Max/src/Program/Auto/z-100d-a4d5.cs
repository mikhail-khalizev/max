using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_a4d5-4d16c911")]
        public void Method_100d_a4d5()
        {
            ii(0x100d_a4d5, 5); push(0x68);                             /* push 0x68 */
            ii(0x100d_a4da, 5); call(Definitions.sys_check_available_stack_size, 0x8_b873); /* call 0x10165d52 */
            ii(0x100d_a4df, 1); push(ebx);                              /* push ebx */
            ii(0x100d_a4e0, 1); push(ecx);                              /* push ecx */
            ii(0x100d_a4e1, 1); push(esi);                              /* push esi */
            ii(0x100d_a4e2, 1); push(edi);                              /* push edi */
            ii(0x100d_a4e3, 1); push(ebp);                              /* push ebp */
            ii(0x100d_a4e4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_a4e6, 6); sub(esp, 0x40);                         /* sub esp, 0x40 */
            ii(0x100d_a4ec, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_a4ef, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_a4f2, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_a4f5, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100d_a4f8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a4fb, 6); mov(eax, memd[ds, eax + 0x39f]);        /* mov eax, [eax+0x39f] */
            ii(0x100d_a501, 5); call(0x100d_7f6c, -0x259a);             /* call 0x100d7f6c */
            ii(0x100d_a506, 5); cmp(memw[ss, ebp - 0x4], -0x1 /* 0xff */); /* cmp word [ebp-0x4], 0xffff */
            ii(0x100d_a50b, 6); if(jz(0x100d_a5a1, 0x90)) goto l_0x100d_a5a1; /* jz 0x100da5a1 */
            ii(0x100d_a511, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a514, 3); mov(eax, memd[ds, eax + 0x55]);         /* mov eax, [eax+0x55] */
            ii(0x100d_a517, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_a51a, 1); push(eax);                              /* push eax */
            ii(0x100d_a51b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a51e, 3); mov(eax, memd[ds, eax + 0x53]);         /* mov eax, [eax+0x53] */
            ii(0x100d_a521, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_a524, 1); push(eax);                              /* push eax */
            ii(0x100d_a525, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a528, 6); mov(eax, memd[ds, eax + 0x39f]);        /* mov eax, [eax+0x39f] */
            ii(0x100d_a52e, 5); call(0x100d_4f58, -0x55db);             /* call 0x100d4f58 */
            ii(0x100d_a533, 1); cwde();                                 /* cwde */
            ii(0x100d_a534, 1); push(eax);                              /* push eax */
            ii(0x100d_a535, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100d_a539, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_a53c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_a53e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a541, 5); add(eax, 0x1cf);                        /* add eax, 0x1cf */
            ii(0x100d_a546, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_a548, 5); call(0x100c_b6f0, -0xee5d);             /* call 0x100cb6f0 */
            ii(0x100d_a54d, 1); push(eax);                              /* push eax */
            ii(0x100d_a54e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a551, 3); mov(ecx, memd[ds, eax + 0x49]);         /* mov ecx, [eax+0x49] */
            ii(0x100d_a554, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100d_a557, 4); movsx(ebx, memw[ss, ebp - 0x4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x100d_a55b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a55e, 3); mov(edx, memd[ds, eax + 0x25]);         /* mov edx, [eax+0x25] */
            ii(0x100d_a561, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_a564, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a567, 3); mov(esi, memd[ds, eax + 0x25]);         /* mov esi, [eax+0x25] */
            ii(0x100d_a56a, 3); sar(esi, 0x10);                         /* sar esi, 0x10 */
            ii(0x100d_a56d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a570, 6); mov(eax, memd[ds, eax + 0x39f]);        /* mov eax, [eax+0x39f] */
            ii(0x100d_a576, 5); call(0x100d_4ebc, -0x56bf);             /* call 0x100d4ebc */
            ii(0x100d_a57b, 1); cwde();                                 /* cwde */
            ii(0x100d_a57c, 3); imul(eax, esi);                         /* imul eax, esi */
            ii(0x100d_a57f, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100d_a582, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a585, 6); mov(eax, memd[ds, eax + 0x39f]);        /* mov eax, [eax+0x39f] */
            ii(0x100d_a58b, 5); call(0x100d_4ef0, -0x56a0);             /* call 0x100d4ef0 */
            ii(0x100d_a590, 1); cwde();                                 /* cwde */
            ii(0x100d_a591, 3); mov(esi, memd[ss, ebp - 0x8]);          /* mov esi, [ebp-0x8] */
            ii(0x100d_a594, 3); mov(esi, memd[ds, esi + 0x2d]);         /* mov esi, [esi+0x2d] */
            ii(0x100d_a597, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x100d_a599, 3); add(eax, memd[ss, ebp - 0xc]);          /* add eax, [ebp-0xc] */
            ii(0x100d_a59c, 5); call(0x1014_018f, 0x6_5bee);            /* call 0x1014018f */
        l_0x100d_a5a1:
            ii(0x100d_a5a1, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x100d_a5a6, 5); call(/* sys */ 0x1016_a24c, 0x8_fca1);  /* call 0x1016a24c */
            ii(0x100d_a5ab, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_a5ae, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100d_a5b1, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a5b4, 6); mov(eax, memd[ds, eax + 0x3a3]);        /* mov eax, [eax+0x3a3] */
            ii(0x100d_a5ba, 5); call(0x100d_7f6c, -0x2653);             /* call 0x100d7f6c */
            ii(0x100d_a5bf, 5); mov(eax, 0x272);                        /* mov eax, 0x272 */
            ii(0x100d_a5c4, 5); call(Definitions.my_get_res_data_by_id, 0x5_9a0f); /* call 0x10133fd8 */
            ii(0x100d_a5c9, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_a5cc, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a5cf, 6); mov(eax, memd[ds, eax + 0x3a3]);        /* mov eax, [eax+0x3a3] */
            ii(0x100d_a5d5, 5); call(0x100d_4ef0, -0x56ea);             /* call 0x100d4ef0 */
            ii(0x100d_a5da, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_a5dd, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a5e0, 3); mov(eax, memd[ds, eax + 0x2d]);         /* mov eax, [eax+0x2d] */
            ii(0x100d_a5e3, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_a5e5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a5e8, 3); mov(eax, memd[ds, eax + 0x25]);         /* mov eax, [eax+0x25] */
            ii(0x100d_a5eb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_a5ee, 3); lea(eax, eax + eax * 4);                /* lea eax, [eax+eax*4] */
            ii(0x100d_a5f1, 3); add(edx, 0x18);                         /* add edx, 0x18 */
            ii(0x100d_a5f4, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_a5f6, 3); mov(memd[ss, ebp - 0x14], edx);         /* mov [ebp-0x14], edx */
            ii(0x100d_a5f9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a5fc, 6); mov(eax, memd[ds, eax + 0x3a3]);        /* mov eax, [eax+0x3a3] */
            ii(0x100d_a602, 5); call(0x100d_4ef0, -0x5717);             /* call 0x100d4ef0 */
            ii(0x100d_a607, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_a60a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a60d, 3); mov(eax, memd[ds, eax + 0x2d]);         /* mov eax, [eax+0x2d] */
            ii(0x100d_a610, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_a612, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a615, 3); mov(eax, memd[ds, eax + 0x25]);         /* mov eax, [eax+0x25] */
            ii(0x100d_a618, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_a61b, 3); lea(eax, eax + eax * 2);                /* lea eax, [eax+eax*2] */
            ii(0x100d_a61e, 3); add(edx, 0x19);                         /* add edx, 0x19 */
            ii(0x100d_a621, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_a623, 3); mov(memd[ss, ebp - 0x18], edx);         /* mov [ebp-0x18], edx */
            ii(0x100d_a626, 7); mov(memd[ss, ebp - 0x1c], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100d_a62d, 2); jmp(0x100d_a635, 0x6); goto l_0x100d_a635; /* jmp 0x100da635 */
        l_0x100d_a62f:
            ii(0x100d_a62f, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100d_a632, 3); inc(memd[ss, ebp - 0x1c]);              /* inc dword [ebp-0x1c] */
        l_0x100d_a635:
            ii(0x100d_a635, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100d_a638, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_a63b, 4); cmp(ax, memw[ds, edx + 0x51]);          /* cmp ax, [edx+0x51] */
            ii(0x100d_a63f, 6); if(jge(0x100d_a6e7, 0xa2)) goto l_0x100d_a6e7; /* jge 0x100da6e7 */
            ii(0x100d_a645, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100d_a649, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_a64c, 3); add(eax, memd[ss, ebp - 0x8]);          /* add eax, [ebp-0x8] */
            ii(0x100d_a64f, 6); mov(eax, memd[ds, eax + 0x375]);        /* mov eax, [eax+0x375] */
            ii(0x100d_a655, 5); call(0x100d_877a, -0x1ee0);             /* call 0x100d877a */
            ii(0x100d_a65a, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100d_a65e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_a661, 3); add(eax, memd[ss, ebp - 0x8]);          /* add eax, [ebp-0x8] */
            ii(0x100d_a664, 6); mov(eax, memd[ds, eax + 0x375]);        /* mov eax, [eax+0x375] */
            ii(0x100d_a66a, 5); call(0x100d_86f5, -0x1f7a);             /* call 0x100d86f5 */
            ii(0x100d_a66f, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100d_a672, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x100d_a676, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_a678, 2); if(jz(0x100d_a685, 0xb)) goto l_0x100d_a685; /* jz 0x100da685 */
            ii(0x100d_a67a, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x100d_a67e, 5); cmp(eax, 0x320);                        /* cmp eax, 0x320 */
            ii(0x100d_a683, 2); if(jl(0x100d_a687, 0x2)) goto l_0x100d_a687; /* jl 0x100da687 */
        l_0x100d_a685:
            ii(0x100d_a685, 2); jmp(0x100d_a6e2, 0x5b); goto l_0x100d_a6e2; /* jmp 0x100da6e2 */
        l_0x100d_a687:
            ii(0x100d_a687, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a68a, 3); mov(edx, memd[ds, eax + 0x25]);         /* mov edx, [eax+0x25] */
            ii(0x100d_a68d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_a690, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100d_a694, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_a697, 3); add(eax, memd[ss, ebp - 0x8]);          /* add eax, [ebp-0x8] */
            ii(0x100d_a69a, 6); mov(eax, memd[ds, eax + 0x375]);        /* mov eax, [eax+0x375] */
            ii(0x100d_a6a0, 5); call(0x100e_0b40, 0x649b);              /* call 0x100e0b40 */
            ii(0x100d_a6a5, 1); cwde();                                 /* cwde */
            ii(0x100d_a6a6, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100d_a6a9, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100d_a6ac, 2); push(0x5);                              /* push 0x5 */
            ii(0x100d_a6ae, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a6b1, 3); mov(ecx, memd[ds, eax + 0x25]);         /* mov ecx, [eax+0x25] */
            ii(0x100d_a6b4, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100d_a6b7, 5); mov(ebx, 0x18);                         /* mov ebx, 0x18 */
            ii(0x100d_a6bc, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x100d_a6c0, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_a6c3, 3); add(eax, memd[ss, ebp - 0x24]);         /* add eax, [ebp-0x24] */
            ii(0x100d_a6c6, 5); call(0x1012_b658, 0x5_0f8d);            /* call 0x1012b658 */
            ii(0x100d_a6cb, 3); mov(ebx, memd[ss, ebp - 0x10]);         /* mov ebx, [ebp-0x10] */
            ii(0x100d_a6ce, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a6d1, 3); mov(edx, memd[ds, eax + 0x25]);         /* mov edx, [eax+0x25] */
            ii(0x100d_a6d4, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_a6d7, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100d_a6da, 3); add(eax, memd[ss, ebp - 0x24]);         /* add eax, [ebp-0x24] */
            ii(0x100d_a6dd, 5); call(0x1013_f410, 0x6_4d2e);            /* call 0x1013f410 */
        l_0x100d_a6e2:
            ii(0x100d_a6e2, 5); jmp(0x100d_a62f, -0xb8); goto l_0x100d_a62f; /* jmp 0x100da62f */
        l_0x100d_a6e7:
            ii(0x100d_a6e7, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_a6ea, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100d_a6ed, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a6f0, 6); mov(eax, memd[ds, eax + 0x3a7]);        /* mov eax, [eax+0x3a7] */
            ii(0x100d_a6f6, 5); call(0x100d_7f6c, -0x278f);             /* call 0x100d7f6c */
            ii(0x100d_a6fb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a6fe, 6); mov(eax, memd[ds, eax + 0x3a7]);        /* mov eax, [eax+0x3a7] */
            ii(0x100d_a704, 5); call(0x100d_4f24, -0x57e5);             /* call 0x100d4f24 */
            ii(0x100d_a709, 3); sub(eax, 0x19);                         /* sub eax, 0x19 */
            ii(0x100d_a70c, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x100d_a70f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a712, 3); mov(eax, memd[ds, eax + 0x4b]);         /* mov eax, [eax+0x4b] */
            ii(0x100d_a715, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_a718, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_a71a, 2); if(jnz(0x100d_a725, 0x9)) goto l_0x100d_a725; /* jnz 0x100da725 */
            ii(0x100d_a71c, 7); mov(memd[ss, ebp - 0x28], 0);           /* mov dword [ebp-0x28], 0x0 */
            ii(0x100d_a723, 2); jmp(0x100d_a748, 0x23); goto l_0x100d_a748; /* jmp 0x100da748 */
        l_0x100d_a725:
            ii(0x100d_a725, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_a728, 3); mov(eax, memd[ds, edx + 0x4d]);         /* mov eax, [edx+0x4d] */
            ii(0x100d_a72b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_a72e, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x100d_a732, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100d_a735, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a738, 3); mov(ebx, memd[ds, eax + 0x4b]);         /* mov ebx, [eax+0x4b] */
            ii(0x100d_a73b, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_a73e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_a740, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100d_a743, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100d_a745, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
        l_0x100d_a748:
            ii(0x100d_a748, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a74b, 6); mov(eax, memd[ds, eax + 0x3a7]);        /* mov eax, [eax+0x3a7] */
            ii(0x100d_a751, 5); call(0x100d_4ebc, -0x589a);             /* call 0x100d4ebc */
            ii(0x100d_a756, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_a759, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a75c, 3); mov(eax, memd[ds, eax + 0x25]);         /* mov eax, [eax+0x25] */
            ii(0x100d_a75f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_a762, 3); add(edx, 0x19);                         /* add edx, 0x19 */
            ii(0x100d_a765, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100d_a768, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a76b, 6); mov(eax, memd[ds, eax + 0x3a7]);        /* mov eax, [eax+0x3a7] */
            ii(0x100d_a771, 5); call(0x100d_4ef0, -0x5886);             /* call 0x100d4ef0 */
            ii(0x100d_a776, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_a779, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a77c, 3); mov(eax, memd[ds, eax + 0x2d]);         /* mov eax, [eax+0x2d] */
            ii(0x100d_a77f, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100d_a781, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_a783, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100d_a786, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a789, 6); mov(eax, memd[ds, eax + 0x3a7]);        /* mov eax, [eax+0x3a7] */
            ii(0x100d_a78f, 5); call(0x100d_4f24, -0x5870);             /* call 0x100d4f24 */
            ii(0x100d_a794, 1); cwde();                                 /* cwde */
            ii(0x100d_a795, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x100d_a799, 3); sub(eax, 0x19);                         /* sub eax, 0x19 */
            ii(0x100d_a79c, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100d_a79e, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_a7a1, 3); mov(edx, memd[ds, edx + 0x25]);         /* mov edx, [edx+0x25] */
            ii(0x100d_a7a4, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_a7a7, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100d_a7aa, 3); add(memd[ss, ebp - 0x2c], eax);         /* add [ebp-0x2c], eax */
            ii(0x100d_a7ad, 5); mov(eax, 0x223);                        /* mov eax, 0x223 */
            ii(0x100d_a7b2, 1); push(eax);                              /* push eax */
            ii(0x100d_a7b3, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a7b6, 6); mov(eax, memd[ds, eax + 0x3a7]);        /* mov eax, [eax+0x3a7] */
            ii(0x100d_a7bc, 5); call(0x100d_4f58, -0x5869);             /* call 0x100d4f58 */
            ii(0x100d_a7c1, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100d_a7c4, 4); movsx(ebx, memw[ss, ebp - 0x28]);       /* movsx ebx, word [ebp-0x28] */
            ii(0x100d_a7c8, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_a7cb, 3); mov(edx, memd[ds, edx + 0x25]);         /* mov edx, [edx+0x25] */
            ii(0x100d_a7ce, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_a7d1, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x100d_a7d4, 5); call(0x100d_701e, -0x37bb);             /* call 0x100d701e */
            ii(0x100d_a7d9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a7dc, 3); mov(eax, memd[ds, eax + 0x4d]);         /* mov eax, [eax+0x4d] */
            ii(0x100d_a7df, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_a7e2, 1); push(eax);                              /* push eax */
            ii(0x100d_a7e3, 5); mov(eax, StringDefinitions.I14);        /* mov eax, 0x101a19e8 */
            ii(0x100d_a7e8, 1); push(eax);                              /* push eax */
            ii(0x100d_a7e9, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100d_a7ec, 1); push(eax);                              /* push eax */
            ii(0x100d_a7ed, 5); call(Definitions.sys_sprintf, 0x8_b70f); /* call 0x10165f01 */
            ii(0x100d_a7f2, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x100d_a7f5, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_a7f8, 3); mov(edx, memd[ds, edx + 0x25]);         /* mov edx, [edx+0x25] */
            ii(0x100d_a7fb, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_a7fe, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a801, 6); mov(eax, memd[ds, eax + 0x3a7]);        /* mov eax, [eax+0x3a7] */
            ii(0x100d_a807, 5); call(0x100d_4ebc, -0x5950);             /* call 0x100d4ebc */
            ii(0x100d_a80c, 1); cwde();                                 /* cwde */
            ii(0x100d_a80d, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100d_a810, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100d_a812, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a815, 6); mov(eax, memd[ds, eax + 0x3a7]);        /* mov eax, [eax+0x3a7] */
            ii(0x100d_a81b, 5); call(0x100d_4ef0, -0x5930);             /* call 0x100d4ef0 */
            ii(0x100d_a820, 1); cwde();                                 /* cwde */
            ii(0x100d_a821, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_a824, 3); mov(edx, memd[ds, edx + 0x2d]);         /* mov edx, [edx+0x2d] */
            ii(0x100d_a827, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_a829, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100d_a82b, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100d_a82e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a831, 6); mov(eax, memd[ds, eax + 0x3a7]);        /* mov eax, [eax+0x3a7] */
            ii(0x100d_a837, 5); call(0x100d_4f58, -0x58e4);             /* call 0x100d4f58 */
            ii(0x100d_a83c, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_a83f, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100d_a842, 6); call_abs(memd[ds, 0x101b_ddf4]);        /* call dword [0x101bddf4] */
            ii(0x100d_a848, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100d_a84a, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_a84c, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100d_a84f, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100d_a851, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100d_a853, 3); add(memd[ss, ebp - 0x2c], eax);         /* add [ebp-0x2c], eax */
            ii(0x100d_a856, 2); push(0x5);                              /* push 0x5 */
            ii(0x100d_a858, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a85b, 3); mov(ecx, memd[ds, eax + 0x25]);         /* mov ecx, [eax+0x25] */
            ii(0x100d_a85e, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100d_a861, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100d_a864, 6); call_abs(memd[ds, 0x101b_ddf4]);        /* call dword [0x101bddf4] */
            ii(0x100d_a86a, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100d_a86c, 3); lea(edx, ebp - 0x40);                   /* lea edx, [ebp-0x40] */
            ii(0x100d_a86f, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x100d_a872, 6); call_abs(memd[ds, 0x101b_ddec]);        /* call dword [0x101bddec] */
            ii(0x100d_a878, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_a87b, 3); mov(eax, memd[ds, eax + 0x29]);         /* mov eax, [eax+0x29] */
            ii(0x100d_a87e, 5); call(Definitions.sys_display_draw_0, 0x8_cc01); /* call 0x10167484 */
            ii(0x100d_a883, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_a885, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_a886, 1); pop(edi);                               /* pop edi */
            ii(0x100d_a887, 1); pop(esi);                               /* pop esi */
            ii(0x100d_a888, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_a889, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_a88a, 1); ret();                                  /* ret */
        }
    }
}
