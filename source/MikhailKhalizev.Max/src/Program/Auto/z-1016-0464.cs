using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_0464-7db46bce")]
        public void Method_1016_0464()
        {
            ii(0x1016_0464, 5); push(0x38);                             /* push 0x38 */
            ii(0x1016_0469, 5); call(Definitions.sys_check_available_stack_size, 0x58e4); /* call 0x10165d52 */
            ii(0x1016_046e, 1); push(ebx);                              /* push ebx */
            ii(0x1016_046f, 1); push(ecx);                              /* push ecx */
            ii(0x1016_0470, 1); push(edx);                              /* push edx */
            ii(0x1016_0471, 1); push(esi);                              /* push esi */
            ii(0x1016_0472, 1); push(edi);                              /* push edi */
            ii(0x1016_0473, 1); push(ebp);                              /* push ebp */
            ii(0x1016_0474, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_0476, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1016_047c, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1016_047f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_0481, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1016_0484, 3); mov(al, memb[ds, edx + 0x26]);          /* mov al, [edx+0x26] */
            ii(0x1016_0487, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1016_048a, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1016_048d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1016_0490, 5); call(0x1007_66ac, -0xe_9de9);           /* call 0x100766ac */
            ii(0x1016_0495, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_0498, 5); call(0x1007_611c, -0xe_a381);           /* call 0x1007611c */
            ii(0x1016_049d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_049f, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1016_04a2, 5); call(0x1007_66ac, -0xe_9dfb);           /* call 0x100766ac */
            ii(0x1016_04a7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_04aa, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1016_04ad, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_04b0, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1016_04b3, 6); mov(al, memb[ds, eax + 0x101c_81d5]);   /* mov al, [eax+0x101c81d5] */
            ii(0x1016_04b9, 3); mov(memb[ss, ebp - 0x8], al);           /* mov [ebp-0x8], al */
            ii(0x1016_04bc, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_04bf, 4); mov(ax, memw[ds, eax + 0x41]);          /* mov ax, [eax+0x41] */
            ii(0x1016_04c3, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1016_04c6, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1016_04ca, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_04cc, 2); if(jge(0x1016_04f0, 0x22)) goto l_0x1016_04f0; /* jge 0x101604f0 */
            ii(0x1016_04ce, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x1016_04d1, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1016_04d4, 5); call(0x1008_ac18, -0xd_58c1);           /* call 0x1008ac18 */
            ii(0x1016_04d9, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1016_04dc, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1016_04df, 5); call(0x1007_6630, -0xe_9eb4);           /* call 0x10076630 */
            ii(0x1016_04e4, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1016_04e8, 5); call(/* sys */ 0x1016_5df8, 0x590b);    /* call 0x10165df8 */
            ii(0x1016_04ed, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x1016_04f0:
            ii(0x1016_04f0, 4); cmp(memb[ss, ebp - 0x8], 0x1);          /* cmp byte [ebp-0x8], 0x1 */
            ii(0x1016_04f4, 6); if(jnz(0x1016_05ad, 0xb3)) goto l_0x1016_05ad; /* jnz 0x101605ad */
            ii(0x1016_04fa, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1016_04fe, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1016_0501, 5); call(0x1007_6574, -0xe_9f92);           /* call 0x10076574 */
            ii(0x1016_0506, 5); call(0x1014_fc73, -0x1_0898);           /* call 0x1014fc73 */
            ii(0x1016_050b, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1016_050e, 5); call(0x1007_6574, -0xe_9f9f);           /* call 0x10076574 */
            ii(0x1016_0513, 5); call(0x1007_6204, -0xe_a314);           /* call 0x10076204 */
            ii(0x1016_0518, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_051a, 2); if(jz(0x1016_0532, 0x16)) goto l_0x1016_0532; /* jz 0x10160532 */
            ii(0x1016_051c, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1016_051f, 5); call(0x1007_6574, -0xe_9fb0);           /* call 0x10076574 */
            ii(0x1016_0524, 5); call(0x1007_6204, -0xe_a325);           /* call 0x10076204 */
            ii(0x1016_0529, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_052b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1016_052e, 4); sub(memw[ds, edx + 0x8], ax);           /* sub [edx+0x8], ax */
        l_0x1016_0532:
            ii(0x1016_0532, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1016_0535, 5); call(0x1007_6574, -0xe_9fc6);           /* call 0x10076574 */
            ii(0x1016_053a, 4); mov(ax, memw[ds, eax + 0x52]);          /* mov ax, [eax+0x52] */
            ii(0x1016_053e, 4); cmp(ax, memw[ss, ebp - 0x10]);          /* cmp ax, [ebp-0x10] */
            ii(0x1016_0542, 2); if(jl(0x1016_0557, 0x13)) goto l_0x1016_0557; /* jl 0x10160557 */
            ii(0x1016_0544, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1016_0547, 5); call(0x1007_6574, -0xe_9fd8);           /* call 0x10076574 */
            ii(0x1016_054c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_054e, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1016_0551, 4); sub(memw[ds, edx + 0x52], ax);          /* sub [edx+0x52], ax */
            ii(0x1016_0555, 2); jmp(0x1016_05a8, 0x51); goto l_0x1016_05a8; /* jmp 0x101605a8 */
        l_0x1016_0557:
            ii(0x1016_0557, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1016_055a, 5); call(0x1007_6574, -0xe_9feb);           /* call 0x10076574 */
            ii(0x1016_055f, 4); mov(ax, memw[ds, eax + 0x52]);          /* mov ax, [eax+0x52] */
            ii(0x1016_0563, 3); sub(memd[ss, ebp - 0x10], eax);         /* sub [ebp-0x10], eax */
            ii(0x1016_0566, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1016_0569, 5); call(0x1007_6574, -0xe_9ffa);           /* call 0x10076574 */
            ii(0x1016_056e, 6); mov(memw[ds, eax + 0x52], 0);           /* mov word [eax+0x52], 0x0 */
            ii(0x1016_0574, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_0576, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_0578, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1016_057b, 2); neg(eax);                               /* neg eax */
            ii(0x1016_057d, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1016_0580, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1016_0583, 5); call(0x1007_6574, -0xe_a014);           /* call 0x10076574 */
            ii(0x1016_0588, 5); call(0x1007_6204, -0xe_a389);           /* call 0x10076204 */
            ii(0x1016_058d, 5); call(0x100d_7a9c, -0x8_8af6);           /* call 0x100d7a9c */
            ii(0x1016_0592, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1016_0595, 5); call(0x1007_6574, -0xe_a026);           /* call 0x10076574 */
            ii(0x1016_059a, 5); call(0x1007_6204, -0xe_a39b);           /* call 0x10076204 */
            ii(0x1016_059f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_05a1, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1016_05a4, 4); add(memw[ds, edx + 0x8], ax);           /* add [edx+0x8], ax */
        l_0x1016_05a8:
            ii(0x1016_05a8, 5); jmp(0x1016_0718, 0x16b); goto l_0x1016_0718; /* jmp 0x10160718 */
        l_0x1016_05ad:
            ii(0x1016_05ad, 4); cmp(memb[ss, ebp - 0x8], 0x2);          /* cmp byte [ebp-0x8], 0x2 */
            ii(0x1016_05b1, 6); if(jnz(0x1016_066a, 0xb3)) goto l_0x1016_066a; /* jnz 0x1016066a */
            ii(0x1016_05b7, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1016_05bb, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1016_05be, 5); call(0x1007_6574, -0xe_a04f);           /* call 0x10076574 */
            ii(0x1016_05c3, 5); call(0x1014_fe6a, -0x1_075e);           /* call 0x1014fe6a */
            ii(0x1016_05c8, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1016_05cb, 5); call(0x1007_6574, -0xe_a05c);           /* call 0x10076574 */
            ii(0x1016_05d0, 5); call(0x1007_6204, -0xe_a3d1);           /* call 0x10076204 */
            ii(0x1016_05d5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_05d7, 2); if(jz(0x1016_05ef, 0x16)) goto l_0x1016_05ef; /* jz 0x101605ef */
            ii(0x1016_05d9, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1016_05dc, 5); call(0x1007_6574, -0xe_a06d);           /* call 0x10076574 */
            ii(0x1016_05e1, 5); call(0x1007_6204, -0xe_a3e2);           /* call 0x10076204 */
            ii(0x1016_05e6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_05e8, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1016_05eb, 4); sub(memw[ds, edx + 0xa], ax);           /* sub [edx+0xa], ax */
        l_0x1016_05ef:
            ii(0x1016_05ef, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1016_05f2, 5); call(0x1007_6574, -0xe_a083);           /* call 0x10076574 */
            ii(0x1016_05f7, 4); mov(ax, memw[ds, eax + 0x52]);          /* mov ax, [eax+0x52] */
            ii(0x1016_05fb, 4); cmp(ax, memw[ss, ebp - 0x10]);          /* cmp ax, [ebp-0x10] */
            ii(0x1016_05ff, 2); if(jl(0x1016_0614, 0x13)) goto l_0x1016_0614; /* jl 0x10160614 */
            ii(0x1016_0601, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1016_0604, 5); call(0x1007_6574, -0xe_a095);           /* call 0x10076574 */
            ii(0x1016_0609, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_060b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1016_060e, 4); sub(memw[ds, edx + 0x52], ax);          /* sub [edx+0x52], ax */
            ii(0x1016_0612, 2); jmp(0x1016_0665, 0x51); goto l_0x1016_0665; /* jmp 0x10160665 */
        l_0x1016_0614:
            ii(0x1016_0614, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1016_0617, 5); call(0x1007_6574, -0xe_a0a8);           /* call 0x10076574 */
            ii(0x1016_061c, 4); mov(ax, memw[ds, eax + 0x52]);          /* mov ax, [eax+0x52] */
            ii(0x1016_0620, 3); sub(memd[ss, ebp - 0x10], eax);         /* sub [ebp-0x10], eax */
            ii(0x1016_0623, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1016_0626, 5); call(0x1007_6574, -0xe_a0b7);           /* call 0x10076574 */
            ii(0x1016_062b, 6); mov(memw[ds, eax + 0x52], 0);           /* mov word [eax+0x52], 0x0 */
            ii(0x1016_0631, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_0633, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1016_0636, 2); neg(eax);                               /* neg eax */
            ii(0x1016_0638, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1016_063b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_063d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1016_0640, 5); call(0x1007_6574, -0xe_a0d1);           /* call 0x10076574 */
            ii(0x1016_0645, 5); call(0x1007_6204, -0xe_a446);           /* call 0x10076204 */
            ii(0x1016_064a, 5); call(0x100d_7a9c, -0x8_8bb3);           /* call 0x100d7a9c */
            ii(0x1016_064f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1016_0652, 5); call(0x1007_6574, -0xe_a0e3);           /* call 0x10076574 */
            ii(0x1016_0657, 5); call(0x1007_6204, -0xe_a458);           /* call 0x10076204 */
            ii(0x1016_065c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_065e, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1016_0661, 4); add(memw[ds, edx + 0xa], ax);           /* add [edx+0xa], ax */
        l_0x1016_0665:
            ii(0x1016_0665, 5); jmp(0x1016_0718, 0xae); goto l_0x1016_0718; /* jmp 0x10160718 */
        l_0x1016_066a:
            ii(0x1016_066a, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1016_066e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1016_0671, 5); call(0x1007_6574, -0xe_a102);           /* call 0x10076574 */
            ii(0x1016_0676, 5); call(0x1015_0061, -0x1_061a);           /* call 0x10150061 */
            ii(0x1016_067b, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1016_067e, 5); call(0x1007_6574, -0xe_a10f);           /* call 0x10076574 */
            ii(0x1016_0683, 5); call(0x1007_6204, -0xe_a484);           /* call 0x10076204 */
            ii(0x1016_0688, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_068a, 2); if(jz(0x1016_06a2, 0x16)) goto l_0x1016_06a2; /* jz 0x101606a2 */
            ii(0x1016_068c, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1016_068f, 5); call(0x1007_6574, -0xe_a120);           /* call 0x10076574 */
            ii(0x1016_0694, 5); call(0x1007_6204, -0xe_a495);           /* call 0x10076204 */
            ii(0x1016_0699, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_069b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1016_069e, 4); sub(memw[ds, edx + 0xc], ax);           /* sub [edx+0xc], ax */
        l_0x1016_06a2:
            ii(0x1016_06a2, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1016_06a5, 5); call(0x1007_6574, -0xe_a136);           /* call 0x10076574 */
            ii(0x1016_06aa, 4); mov(ax, memw[ds, eax + 0x52]);          /* mov ax, [eax+0x52] */
            ii(0x1016_06ae, 4); cmp(ax, memw[ss, ebp - 0x10]);          /* cmp ax, [ebp-0x10] */
            ii(0x1016_06b2, 2); if(jl(0x1016_06c7, 0x13)) goto l_0x1016_06c7; /* jl 0x101606c7 */
            ii(0x1016_06b4, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1016_06b7, 5); call(0x1007_6574, -0xe_a148);           /* call 0x10076574 */
            ii(0x1016_06bc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_06be, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1016_06c1, 4); sub(memw[ds, edx + 0x52], ax);          /* sub [edx+0x52], ax */
            ii(0x1016_06c5, 2); jmp(0x1016_0718, 0x51); goto l_0x1016_0718; /* jmp 0x10160718 */
        l_0x1016_06c7:
            ii(0x1016_06c7, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1016_06ca, 5); call(0x1007_6574, -0xe_a15b);           /* call 0x10076574 */
            ii(0x1016_06cf, 4); mov(ax, memw[ds, eax + 0x52]);          /* mov ax, [eax+0x52] */
            ii(0x1016_06d3, 3); sub(memd[ss, ebp - 0x10], eax);         /* sub [ebp-0x10], eax */
            ii(0x1016_06d6, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1016_06d9, 5); call(0x1007_6574, -0xe_a16a);           /* call 0x10076574 */
            ii(0x1016_06de, 6); mov(memw[ds, eax + 0x52], 0);           /* mov word [eax+0x52], 0x0 */
            ii(0x1016_06e4, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1016_06e7, 2); neg(eax);                               /* neg eax */
            ii(0x1016_06e9, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1016_06ec, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_06ee, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_06f0, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1016_06f3, 5); call(0x1007_6574, -0xe_a184);           /* call 0x10076574 */
            ii(0x1016_06f8, 5); call(0x1007_6204, -0xe_a4f9);           /* call 0x10076204 */
            ii(0x1016_06fd, 5); call(0x100d_7a9c, -0x8_8c66);           /* call 0x100d7a9c */
            ii(0x1016_0702, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1016_0705, 5); call(0x1007_6574, -0xe_a196);           /* call 0x10076574 */
            ii(0x1016_070a, 5); call(0x1007_6204, -0xe_a50b);           /* call 0x10076204 */
            ii(0x1016_070f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_0711, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1016_0714, 4); add(memw[ds, edx + 0xc], ax);           /* add [edx+0xc], ax */
        l_0x1016_0718:
            ii(0x1016_0718, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_071b, 5); call(0x1014_f08b, -0x1_1695);           /* call 0x1014f08b */
            ii(0x1016_0720, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1016_0725, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_0728, 5); call(0x1007_6d98, -0xe_9995);           /* call 0x10076d98 */
            ii(0x1016_072d, 2); test(al, al);                           /* test al, al */
            ii(0x1016_072f, 2); if(jz(0x1016_0739, 0x8)) goto l_0x1016_0739; /* jz 0x10160739 */
            ii(0x1016_0731, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_0734, 5); call(0x1010_094d, -0x5_fdec);           /* call 0x1010094d */
        l_0x1016_0739:
            ii(0x1016_0739, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1016_073e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1016_0741, 5); call(0x1008_b530, -0xd_5216);           /* call 0x1008b530 */
            ii(0x1016_0746, 2); test(al, al);                           /* test al, al */
            ii(0x1016_0748, 2); if(jz(0x1016_0757, 0xd)) goto l_0x1016_0757; /* jz 0x10160757 */
            ii(0x1016_074a, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1016_074d, 5); call(0x1007_65d0, -0xe_a182);           /* call 0x100765d0 */
            ii(0x1016_0752, 5); call(0x1010_094d, -0x5_fe0a);           /* call 0x1010094d */
        l_0x1016_0757:
            ii(0x1016_0757, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_075a, 5); call(0x1007_611c, -0xe_a643);           /* call 0x1007611c */
            ii(0x1016_075f, 3); lea(ebx, ebp - 0x14);                   /* lea ebx, [ebp-0x14] */
            ii(0x1016_0762, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_0764, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_0766, 5); call(0x1007_6630, -0xe_a13b);           /* call 0x10076630 */
            ii(0x1016_076b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1016_076e, 5); call(0x1007_6574, -0xe_a1ff);           /* call 0x10076574 */
            ii(0x1016_0773, 5); call(0x1015_26ac, -0xe0cc);             /* call 0x101526ac */
            ii(0x1016_0778, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_077a, 2); if(jz(0x1016_07a2, 0x26)) goto l_0x1016_07a2; /* jz 0x101607a2 */
            ii(0x1016_077c, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1016_077f, 5); call(0x1007_6574, -0xe_a210);           /* call 0x10076574 */
            ii(0x1016_0784, 5); call(0x1015_26ac, -0xe0dd);             /* call 0x101526ac */
            ii(0x1016_0789, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1016_078c, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1016_078f, 3); mov(ebx, memd[ds, eax + 0x2]);          /* mov ebx, [eax+0x2] */
            ii(0x1016_0792, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1016_0795, 5); call(0x1007_6600, -0xe_a19a);           /* call 0x10076600 */
            ii(0x1016_079a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_079c, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1016_079f, 3); call_abs(memd[ds, ebx + 0x58]);         /* call dword [ebx+0x58] */
        l_0x1016_07a2:
            ii(0x1016_07a2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_07a4, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1016_07a7, 5); call(0x1007_5f2c, -0xe_a880);           /* call 0x10075f2c */
            ii(0x1016_07ac, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_07ae, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1016_07b1, 5); call(0x1007_5f2c, -0xe_a88a);           /* call 0x10075f2c */
            ii(0x1016_07b6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_07b8, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_07b9, 1); pop(edi);                               /* pop edi */
            ii(0x1016_07ba, 1); pop(esi);                               /* pop esi */
            ii(0x1016_07bb, 1); pop(edx);                               /* pop edx */
            ii(0x1016_07bc, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_07bd, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_07be, 1); ret();                                  /* ret */
        }
    }
}
