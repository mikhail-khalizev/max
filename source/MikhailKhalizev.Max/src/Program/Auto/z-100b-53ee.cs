using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_53ee-abb46323")]
        public void Method_100b_53ee()
        {
            ii(0x100b_53ee, 5); pushd(0x84);                            /* push 0x84 */
            ii(0x100b_53f3, 5); calld(Definitions.sys_check_available_stack_size, 0xb_095a); /* call 0x10165d52 */
            ii(0x100b_53f8, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_53f9, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_53fa, 1); pushd(esi);                             /* push esi */
            ii(0x100b_53fb, 1); pushd(edi);                             /* push edi */
            ii(0x100b_53fc, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_53fd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_53ff, 6); sub(esp, 0x60);                         /* sub esp, 0x60 */
            ii(0x100b_5405, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_5408, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_540b, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_540e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_5411, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_5414, 5); calld(0x1007_6e00, -0x3_e619);          /* call 0x10076e00 */
            ii(0x100b_5419, 2); test(al, al);                           /* test al, al */
            ii(0x100b_541b, 2); if(jzd(0x100b_5434, 0x17)) goto l_0x100b_5434; /* jz 0x100b5434 */
            ii(0x100b_541d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_5420, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_5423, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_5426, 5); calld(0x1007_6574, -0x3_eeb7);          /* call 0x10076574 */
            ii(0x100b_542b, 5); calld(0x1015_2a52, 0x9_d622);           /* call 0x10152a52 */
            ii(0x100b_5430, 2); test(al, al);                           /* test al, al */
            ii(0x100b_5432, 2); if(jnzd(0x100b_5436, 0x2)) goto l_0x100b_5436; /* jnz 0x100b5436 */
        l_0x100b_5434:
            ii(0x100b_5434, 2); jmpd(0x100b_544d, 0x17); goto l_0x100b_544d; /* jmp 0x100b544d */
        l_0x100b_5436:
            ii(0x100b_5436, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_5439, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_543c, 5); calld(0x1007_6574, -0x3_eecd);          /* call 0x10076574 */
            ii(0x100b_5441, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x100b_5444, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_5449, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_544b, 2); if(jgd(0x100b_5452, 0x5)) goto l_0x100b_5452; /* jg 0x100b5452 */
        l_0x100b_544d:
            ii(0x100b_544d, 5); jmpd(0x100b_5817, 0x3c5); goto l_0x100b_5817; /* jmp 0x100b5817 */
        l_0x100b_5452:
            ii(0x100b_5452, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x100b_5456, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100b_5459, 5); calld(0x1008_bbed, -0x2_9871);          /* call 0x1008bbed */
            ii(0x100b_545e, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100b_5461, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100b_5465, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x100b_5469, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_546c, 5); calld(0x1008_bbed, -0x2_9884);          /* call 0x1008bbed */
            ii(0x100b_5471, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100b_5474, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100b_5478, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100b_547b, 5); calld(0x1008_a6f8, -0x2_ad88);          /* call 0x1008a6f8 */
            ii(0x100b_5480, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_5482, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_5485, 5); calld(0x100b_598b, 0x501);              /* call 0x100b598b */
            ii(0x100b_548a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_548d, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_5490, 5); calld(0x1007_6574, -0x3_ef21);          /* call 0x10076574 */
            ii(0x100b_5495, 4); test(memb_a32[ds, eax + 0x12], 0x40);   /* test byte [eax+0x12], 0x40 */
            ii(0x100b_5499, 2); if(jzd(0x100b_54cd, 0x32)) goto l_0x100b_54cd; /* jz 0x100b54cd */
            ii(0x100b_549b, 5); mov(ebx, 0x23);                         /* mov ebx, 0x23 */
            ii(0x100b_54a0, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100b_54a3, 5); calld(0x1008_a6f8, -0x2_adb0);          /* call 0x1008a6f8 */
            ii(0x100b_54a8, 3); mov(ecx, memd_a32[ss, ebp - 0x8]);      /* mov ecx, [ebp-0x8] */
            ii(0x100b_54ab, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_54ad, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100b_54af, 5); calld(0x100b_5abe, 0x60a);              /* call 0x100b5abe */
            ii(0x100b_54b4, 5); mov(ebx, 0x101c_81a8);                  /* mov ebx, 0x101c81a8 */
            ii(0x100b_54b9, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100b_54bc, 5); calld(0x1008_a6f8, -0x2_adc9);          /* call 0x1008a6f8 */
            ii(0x100b_54c1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_54c3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_54c6, 5); calld(0x100b_5c96, 0x7cb);              /* call 0x100b5c96 */
            ii(0x100b_54cb, 2); jmpd(0x100b_5544, 0x77); goto l_0x100b_5544; /* jmp 0x100b5544 */
        l_0x100b_54cd:
            ii(0x100b_54cd, 5); mov(ebx, 0x22);                         /* mov ebx, 0x22 */
            ii(0x100b_54d2, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100b_54d5, 5); calld(0x1008_a6f8, -0x2_ade2);          /* call 0x1008a6f8 */
            ii(0x100b_54da, 3); mov(ecx, memd_a32[ss, ebp - 0x8]);      /* mov ecx, [ebp-0x8] */
            ii(0x100b_54dd, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_54df, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100b_54e1, 5); calld(0x100b_5abe, 0x5d8);              /* call 0x100b5abe */
            ii(0x100b_54e6, 5); mov(ebx, 0x24);                         /* mov ebx, 0x24 */
            ii(0x100b_54eb, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100b_54ee, 5); calld(0x1008_a6f8, -0x2_adfb);          /* call 0x1008a6f8 */
            ii(0x100b_54f3, 3); mov(ecx, memd_a32[ss, ebp - 0x8]);      /* mov ecx, [ebp-0x8] */
            ii(0x100b_54f6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_54f8, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100b_54fa, 5); calld(0x100b_5abe, 0x5bf);              /* call 0x100b5abe */
            ii(0x100b_54ff, 5); mov(ebx, 0x25);                         /* mov ebx, 0x25 */
            ii(0x100b_5504, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100b_5507, 5); calld(0x1008_a6f8, -0x2_ae14);          /* call 0x1008a6f8 */
            ii(0x100b_550c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_550e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_5511, 5); calld(0x100b_5abe, 0x5a8);              /* call 0x100b5abe */
            ii(0x100b_5516, 5); mov(ebx, 0x101c_8184);                  /* mov ebx, 0x101c8184 */
            ii(0x100b_551b, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100b_551e, 5); calld(0x1008_a6f8, -0x2_ae2b);          /* call 0x1008a6f8 */
            ii(0x100b_5523, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_5525, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_5528, 5); calld(0x100b_5c96, 0x769);              /* call 0x100b5c96 */
            ii(0x100b_552d, 5); mov(ebx, 0x101c_819c);                  /* mov ebx, 0x101c819c */
            ii(0x100b_5532, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100b_5535, 5); calld(0x1008_a6f8, -0x2_ae42);          /* call 0x1008a6f8 */
            ii(0x100b_553a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_553c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_553f, 5); calld(0x100b_5c96, 0x752);              /* call 0x100b5c96 */
        l_0x100b_5544:
            ii(0x100b_5544, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_5547, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_554a, 5); calld(0x1007_6574, -0x3_efdb);          /* call 0x10076574 */
            ii(0x100b_554f, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x100b_5552, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100b_5555, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_5558, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_555b, 5); calld(0x1007_6574, -0x3_efec);          /* call 0x10076574 */
            ii(0x100b_5560, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x100b_5563, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_5566, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_5569, 5); calld(0x1007_6aac, -0x3_eac2);          /* call 0x10076aac */
            ii(0x100b_556e, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100b_5571, 5); calld(Definitions.my_ctor_0x101b_4184, -0x3_ea86); /* call 0x10076af0 */
            ii(0x100b_5576, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_5579, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_557c, 5); calld(0x1007_6574, -0x3_f00d);          /* call 0x10076574 */
            ii(0x100b_5581, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x100b_5584, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_5587, 3); imul(edx, edx, 0x33);                   /* imul edx, edx, 0x33 */
            ii(0x100b_558a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_558c, 6); mov(al, memb_a32[ds, edx + 0x101c_81d4]); /* mov al, [edx+0x101c81d4] */
            ii(0x100b_5592, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100b_5595, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_5598, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100b_559b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_559e, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x100b_55a4, 5); mov(edx, 0x101c_31c4);                  /* mov edx, 0x101c31c4 */
            ii(0x100b_55a9, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_55ab, 5); calld(0x1008_a0c8, -0x2_b4e8);          /* call 0x1008a0c8 */
            ii(0x100b_55b0, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x100b_55b3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_55b6, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_55b9, 5); calld(0x1007_6574, -0x3_f04a);          /* call 0x10076574 */
            ii(0x100b_55be, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x100b_55c1, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100b_55c4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_55c7, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_55ca, 5); calld(0x1007_6574, -0x3_f05b);          /* call 0x10076574 */
            ii(0x100b_55cf, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x100b_55d2, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_55d5, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100b_55d8, 5); calld(0x1008_a728, -0x2_aeb5);          /* call 0x1008a728 */
            ii(0x100b_55dd, 3); lea(edx, eax + ebx);                    /* lea edx, [eax+ebx] */
            ii(0x100b_55e0, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_55e2, 2); mov(al, memb_a32[ds, edx]);             /* mov al, [edx] */
            ii(0x100b_55e4, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100b_55e7, 7); mov(memd_a32[ss, ebp - 0x40], 0);       /* mov dword [ebp-0x40], 0x0 */
            ii(0x100b_55ee, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_55f1, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_55f4, 5); calld(0x1007_6574, -0x3_f085);          /* call 0x10076574 */
            ii(0x100b_55f9, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x100b_55fd, 4); mov(memw_a32[ss, ebp - 0x2c], ax);      /* mov [ebp-0x2c], ax */
            ii(0x100b_5601, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_5604, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_5607, 5); calld(0x1007_6574, -0x3_f098);          /* call 0x10076574 */
            ii(0x100b_560c, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x100b_5610, 4); mov(memw_a32[ss, ebp - 0x2a], ax);      /* mov [ebp-0x2a], ax */
            ii(0x100b_5614, 5); mov(ecx, 0x3);                          /* mov ecx, 0x3 */
            ii(0x100b_5619, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100b_561e, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_5621, 5); calld(0x1008_a6f8, -0x2_af2e);          /* call 0x1008a6f8 */
            ii(0x100b_5626, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_5628, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_562b, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_562e, 5); calld(0x1007_65d0, -0x3_f063);          /* call 0x100765d0 */
            ii(0x100b_5633, 5); calld(0x1011_ef28, 0x6_98f0);           /* call 0x1011ef28 */
            ii(0x100b_5638, 6); mov(memw_a32[ss, ebp - 0x30], 0);       /* mov word [ebp-0x30], 0x0 */
            ii(0x100b_563e, 2); jmpd(0x100b_5647, 0x7); goto l_0x100b_5647; /* jmp 0x100b5647 */
        l_0x100b_5640:
            ii(0x100b_5640, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100b_5643, 4); inc(memw_a32[ss, ebp - 0x30]);          /* inc word [ebp-0x30] */
        l_0x100b_5647:
            ii(0x100b_5647, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100b_564a, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x100b_5651, 6); if(jged(0x100b_5734, 0xdd)) goto l_0x100b_5734; /* jge 0x100b5734 */
            ii(0x100b_5657, 6); mov(memw_a32[ss, ebp - 0x2e], 0);       /* mov word [ebp-0x2e], 0x0 */
            ii(0x100b_565d, 2); jmpd(0x100b_5666, 0x7); goto l_0x100b_5666; /* jmp 0x100b5666 */
        l_0x100b_565f:
            ii(0x100b_565f, 3); mov(eax, memd_a32[ss, ebp - 0x2e]);     /* mov eax, [ebp-0x2e] */
            ii(0x100b_5662, 4); inc(memw_a32[ss, ebp - 0x2e]);          /* inc word [ebp-0x2e] */
        l_0x100b_5666:
            ii(0x100b_5666, 3); mov(eax, memd_a32[ss, ebp - 0x2e]);     /* mov eax, [ebp-0x2e] */
            ii(0x100b_5669, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x100b_5670, 6); if(jged(0x100b_572f, 0xb9)) goto l_0x100b_572f; /* jge 0x100b572f */
            ii(0x100b_5676, 4); movsx(ebx, memw_a32[ss, ebp - 0x2e]);   /* movsx ebx, word [ebp-0x2e] */
            ii(0x100b_567a, 4); movsx(edx, memw_a32[ss, ebp - 0x30]);   /* movsx edx, word [ebp-0x30] */
            ii(0x100b_567e, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100b_5681, 5); calld(0x1008_a728, -0x2_af5e);          /* call 0x1008a728 */
            ii(0x100b_5686, 3); lea(edx, eax + ebx);                    /* lea edx, [eax+ebx] */
            ii(0x100b_5689, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_568b, 2); mov(al, memb_a32[ds, edx]);             /* mov al, [edx] */
            ii(0x100b_568d, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x100b_5690, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x100b_5693, 4); cmp(ax, memw_a32[ss, ebp - 0x3c]);      /* cmp ax, [ebp-0x3c] */
            ii(0x100b_5697, 2); if(jld(0x100b_56b6, 0x1d)) goto l_0x100b_56b6; /* jl 0x100b56b6 */
            ii(0x100b_5699, 4); movsx(ebx, memw_a32[ss, ebp - 0x2e]);   /* movsx ebx, word [ebp-0x2e] */
            ii(0x100b_569d, 4); movsx(edx, memw_a32[ss, ebp - 0x30]);   /* movsx edx, word [ebp-0x30] */
            ii(0x100b_56a1, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_56a4, 5); calld(0x1008_a728, -0x2_af81);          /* call 0x1008a728 */
            ii(0x100b_56a9, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100b_56ab, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100b_56ad, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_56b2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_56b4, 2); if(jgd(0x100b_56b8, 0x2)) goto l_0x100b_56b8; /* jg 0x100b56b8 */
        l_0x100b_56b6:
            ii(0x100b_56b6, 2); jmpd(0x100b_56cf, 0x17); goto l_0x100b_56cf; /* jmp 0x100b56cf */
        l_0x100b_56b8:
            ii(0x100b_56b8, 4); movsx(eax, memw_a32[ss, ebp - 0x30]);   /* movsx eax, word [ebp-0x30] */
            ii(0x100b_56bc, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_56bf, 3); add(eax, memd_a32[ss, ebp - 0x38]);     /* add eax, [ebp-0x38] */
            ii(0x100b_56c2, 4); movsx(edx, memw_a32[ss, ebp - 0x2e]);   /* movsx edx, word [ebp-0x2e] */
            ii(0x100b_56c6, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100b_56c8, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_56ca, 3); test(memb_a32[ds, eax], 0x8);           /* test byte [eax], 0x8 */
            ii(0x100b_56cd, 2); if(jzd(0x100b_56d1, 0x2)) goto l_0x100b_56d1; /* jz 0x100b56d1 */
        l_0x100b_56cf:
            ii(0x100b_56cf, 2); jmpd(0x100b_572a, 0x59); goto l_0x100b_572a; /* jmp 0x100b572a */
        l_0x100b_56d1:
            ii(0x100b_56d1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_56d4, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_56d7, 5); calld(0x1007_6574, -0x3_f168);          /* call 0x10076574 */
            ii(0x100b_56dc, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x100b_56e0, 3); sub(eax, memd_a32[ss, ebp - 0x2e]);     /* sub eax, [ebp-0x2e] */
            ii(0x100b_56e3, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_56e6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_56e9, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_56ec, 5); calld(0x1007_6574, -0x3_f17d);          /* call 0x10076574 */
            ii(0x100b_56f1, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x100b_56f5, 3); sub(eax, memd_a32[ss, ebp - 0x30]);     /* sub eax, [ebp-0x30] */
            ii(0x100b_56f8, 1); cwde();                                 /* cwde */
            ii(0x100b_56f9, 5); calld(0x100a_5f65, -0xf799);            /* call 0x100a5f65 */
            ii(0x100b_56fe, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x100b_5701, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x100b_5704, 4); cmp(ax, memw_a32[ss, ebp - 0x3c]);      /* cmp ax, [ebp-0x3c] */
            ii(0x100b_5708, 2); if(jgd(0x100b_5713, 0x9)) goto l_0x100b_5713; /* jg 0x100b5713 */
            ii(0x100b_570a, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100b_570d, 4); cmp(ax, memw_a32[ss, ebp - 0x40]);      /* cmp ax, [ebp-0x40] */
            ii(0x100b_5711, 2); if(jged(0x100b_572a, 0x17)) goto l_0x100b_572a; /* jge 0x100b572a */
        l_0x100b_5713:
            ii(0x100b_5713, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100b_5716, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x100b_5719, 3); lea(edx, ebp - 0x30);                   /* lea edx, [ebp-0x30] */
            ii(0x100b_571c, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_571f, 5); calld(0x1008_8b44, -0x2_cbe0);          /* call 0x10088b44 */
            ii(0x100b_5724, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x100b_5727, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
        l_0x100b_572a:
            ii(0x100b_572a, 5); jmpd(0x100b_565f, -0xd0); goto l_0x100b_565f; /* jmp 0x100b565f */
        l_0x100b_572f:
            ii(0x100b_572f, 5); jmpd(0x100b_5640, -0xf4); goto l_0x100b_5640; /* jmp 0x100b5640 */
        l_0x100b_5734:
            ii(0x100b_5734, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_5737, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_573a, 5); calld(0x1007_6574, -0x3_f1cb);          /* call 0x10076574 */
            ii(0x100b_573f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_5741, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100b_5744, 4); cmp(ax, memw_a32[ds, edx + 0x1a]);      /* cmp ax, [edx+0x1a] */
            ii(0x100b_5748, 2); if(jnzd(0x100b_5764, 0x1a)) goto l_0x100b_5764; /* jnz 0x100b5764 */
            ii(0x100b_574a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_574d, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_5750, 5); calld(0x1007_6574, -0x3_f1e1);          /* call 0x10076574 */
            ii(0x100b_5755, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_5757, 3); mov(eax, memd_a32[ss, ebp - 0x2a]);     /* mov eax, [ebp-0x2a] */
            ii(0x100b_575a, 4); cmp(ax, memw_a32[ds, edx + 0x1c]);      /* cmp ax, [edx+0x1c] */
            ii(0x100b_575e, 6); if(jzd(0x100b_5803, 0x9f)) goto l_0x100b_5803; /* jz 0x100b5803 */
        l_0x100b_5764:
            ii(0x100b_5764, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x100b_5769, 5); calld(Definitions.sys_new, 0xb_0692);   /* call 0x10165e00 */
            ii(0x100b_576e, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x100b_5771, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x100b_5774, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x100b_5777, 4); cmp(memd_a32[ss, ebp - 0x50], 0);       /* cmp dword [ebp-0x50], 0x0 */
            ii(0x100b_577b, 2); if(jzd(0x100b_57ba, 0x3d)) goto l_0x100b_57ba; /* jz 0x100b57ba */
            ii(0x100b_577d, 5); mov(eax, 0x100b_594b);                  /* mov eax, 0x100b594b */
            ii(0x100b_5782, 1); pushd(eax);                             /* push eax */
            ii(0x100b_5783, 3); lea(edx, ebp - 0x2c);                   /* lea edx, [ebp-0x2c] */
            ii(0x100b_5786, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x100b_5789, 5); calld(0x1007_5e64, -0x3_f92a);          /* call 0x10075e64 */
            ii(0x100b_578e, 1); pushd(eax);                             /* push eax */
            ii(0x100b_578f, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
            ii(0x100b_5794, 1); pushd(eax);                             /* push eax */
            ii(0x100b_5795, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100b_5797, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100b_579a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_579d, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_57a0, 5); calld(0x1007_65d0, -0x3_f1d5);          /* call 0x100765d0 */
            ii(0x100b_57a5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_57a7, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x100b_57aa, 5); calld(0x100a_c220, -0x958f);            /* call 0x100ac220 */
            ii(0x100b_57af, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
            ii(0x100b_57b2, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x100b_57b5, 3); mov(memd_a32[ss, ebp - 0x5c], eax);     /* mov [ebp-0x5c], eax */
            ii(0x100b_57b8, 2); jmpd(0x100b_57c0, 0x6); goto l_0x100b_57c0; /* jmp 0x100b57c0 */
        l_0x100b_57ba:
            ii(0x100b_57ba, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x100b_57bd, 3); mov(memd_a32[ss, ebp - 0x5c], eax);     /* mov [ebp-0x5c], eax */
        l_0x100b_57c0:
            ii(0x100b_57c0, 3); mov(edx, memd_a32[ss, ebp - 0x5c]);     /* mov edx, [ebp-0x5c] */
            ii(0x100b_57c3, 3); lea(eax, ebp - 0x60);                   /* lea eax, [ebp-0x60] */
            ii(0x100b_57c6, 5); calld(0x1008_b060, -0x2_a76b);          /* call 0x1008b060 */
            ii(0x100b_57cb, 3); lea(eax, ebp - 0x60);                   /* lea eax, [ebp-0x60] */
            ii(0x100b_57ce, 5); calld(0x1008_af84, -0x2_a84f);          /* call 0x1008af84 */
            ii(0x100b_57d3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_57d5, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_57da, 5); calld(0x100a_4d50, -0x1_0a8f);          /* call 0x100a4d50 */
            ii(0x100b_57df, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x100b_57e3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_57e5, 3); lea(eax, ebp - 0x60);                   /* lea eax, [ebp-0x60] */
            ii(0x100b_57e8, 5); calld(0x1008_8b7c, -0x2_cc71);          /* call 0x10088b7c */
            ii(0x100b_57ed, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_57ef, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_57f2, 5); calld(0x1008_bc9f, -0x2_9b58);          /* call 0x1008bc9f */
            ii(0x100b_57f7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_57f9, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100b_57fc, 5); calld(0x1008_bc9f, -0x2_9b62);          /* call 0x1008bc9f */
            ii(0x100b_5801, 2); jmpd(0x100b_581b, 0x18); goto l_0x100b_581b; /* jmp 0x100b581b */
        l_0x100b_5803:
            ii(0x100b_5803, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_5805, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_5808, 5); calld(0x1008_bc9f, -0x2_9b6e);          /* call 0x1008bc9f */
            ii(0x100b_580d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_580f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100b_5812, 5); calld(0x1008_bc9f, -0x2_9b78);          /* call 0x1008bc9f */
        l_0x100b_5817:
            ii(0x100b_5817, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
        l_0x100b_581b:
            ii(0x100b_581b, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x100b_581e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_5820, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_5821, 1); popd(edi);                              /* pop edi */
            ii(0x100b_5822, 1); popd(esi);                              /* pop esi */
            ii(0x100b_5823, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_5824, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_5825, 1); retd();                                 /* ret */
        }
    }
}
