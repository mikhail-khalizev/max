using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_440e-fba6acc9")]
        public void Method_100c_440e()
        {
            ii(0x100c_440e, 5); pushd(0x4c);                            /* push 0x4c */
            ii(0x100c_4413, 5); calld(Definitions.sys_check_available_stack_size, 0xa_193a); /* call 0x10165d52 */
            ii(0x100c_4418, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_4419, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_441a, 1); pushd(esi);                             /* push esi */
            ii(0x100c_441b, 1); pushd(edi);                             /* push edi */
            ii(0x100c_441c, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_441d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_441f, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x100c_4425, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_4428, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_442b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_442e, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_4431, 3); imul(edx, eax, 0x13);                   /* imul edx, eax, 0x13 */
            ii(0x100c_4434, 5); mov(eax, 0x101c_35b4);                  /* mov eax, 0x101c35b4 */
            ii(0x100c_4439, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_443b, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100c_443e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4441, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_4444, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_444a, 6); mov(al, memb_a32[ds, eax + 0x101c_a4ef]); /* mov al, [eax+0x101ca4ef] */
            ii(0x100c_4450, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100c_4452, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100c_4455, 5); mov(eax, 0x101c_3c4c);                  /* mov eax, 0x101c3c4c */
            ii(0x100c_445a, 5); calld(0x1010_6752, 0x4_22f3);           /* call 0x10106752 */
            ii(0x100c_445f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_4461, 5); mov(eax, 0x48);                         /* mov eax, 0x48 */
            ii(0x100c_4466, 5); calld(0x1007_5fdc, -0x4_e48f);          /* call 0x10075fdc */
            ii(0x100c_446b, 3); mov(ebx, memd_a32[ss, ebp - 0x24]);     /* mov ebx, [ebp-0x24] */
            ii(0x100c_446e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_4470, 4); mov(memw_a32[ds, ebx + 0x10], ax);      /* mov [ebx+0x10], ax */
            ii(0x100c_4474, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100c_4477, 5); calld(0x1009_caf8, -0x2_7984);          /* call 0x1009caf8 */
            ii(0x100c_447c, 7); mov(memd_a32[ss, ebp - 0x10], 0x31);    /* mov dword [ebp-0x10], 0x31 */
            ii(0x100c_4483, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x100c_4486, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100c_4489, 5); calld(0x1008_b2a8, -0x3_91e6);          /* call 0x1008b2a8 */
            ii(0x100c_448e, 7); mov(memd_a32[ss, ebp - 0xc], 0x3d);     /* mov dword [ebp-0xc], 0x3d */
            ii(0x100c_4495, 3); lea(edx, ebp - 0xc);                    /* lea edx, [ebp-0xc] */
            ii(0x100c_4498, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100c_449b, 5); calld(0x1008_b2a8, -0x3_91f8);          /* call 0x1008b2a8 */
            ii(0x100c_44a0, 7); mov(memd_a32[ss, ebp - 0x20], 0x39);    /* mov dword [ebp-0x20], 0x39 */
            ii(0x100c_44a7, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x100c_44aa, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100c_44ad, 5); calld(0x1008_b2a8, -0x3_920a);          /* call 0x1008b2a8 */
            ii(0x100c_44b2, 5); calld(0x1009_cb74, -0x2_7943);          /* call 0x1009cb74 */
            ii(0x100c_44b7, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_44b9, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_44bb, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x100c_44be, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100c_44c1, 5); calld(0x1009_cab0, -0x2_7a16);          /* call 0x1009cab0 */
            ii(0x100c_44c6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_44c8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_44cb, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_44ce, 5); calld(0x100d_c405, 0x1_7f32);           /* call 0x100dc405 */
            ii(0x100c_44d3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_44d5, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100c_44d8, 5); calld(0x1008_8b04, -0x3_b9d9);          /* call 0x10088b04 */
            ii(0x100c_44dd, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100c_44e0, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100c_44e3, 5); calld(0x100c_aac8, 0x65e0);             /* call 0x100caac8 */
            ii(0x100c_44e8, 7); mov(memd_a32[ss, ebp - 0x18], 0x28);    /* mov dword [ebp-0x18], 0x28 */
            ii(0x100c_44ef, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x100c_44f2, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100c_44f5, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100c_44f8, 5); calld(0x100c_aa44, 0x6547);             /* call 0x100caa44 */
            ii(0x100c_44fd, 7); mov(memd_a32[ss, ebp - 0x1c], 0x14);    /* mov dword [ebp-0x1c], 0x14 */
            ii(0x100c_4504, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x100c_4507, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100c_450a, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100c_450d, 5); calld(0x100c_aa44, 0x6532);             /* call 0x100caa44 */
            ii(0x100c_4512, 7); mov(memd_a32[ss, ebp - 0x14], 0x2);     /* mov dword [ebp-0x14], 0x2 */
            ii(0x100c_4519, 2); jmpd(0x100c_4521, 0x6); goto l_0x100c_4521; /* jmp 0x100c4521 */
        l_0x100c_451b:
            ii(0x100c_451b, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_451e, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x100c_4521:
            ii(0x100c_4521, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100c_4524, 5); calld(Definitions.my_2_get_count, -0x3_91c1); /* call 0x1008b368 */
            ii(0x100c_4529, 4); cmp(ax, memw_a32[ss, ebp - 0x14]);      /* cmp ax, [ebp-0x14] */
            ii(0x100c_452d, 2); if(jled(0x100c_4546, 0x17)) goto l_0x100c_4546; /* jle 0x100c4546 */
            ii(0x100c_452f, 7); mov(memd_a32[ss, ebp - 0x2c], 0);       /* mov dword [ebp-0x2c], 0x0 */
            ii(0x100c_4536, 3); lea(edx, ebp - 0x2c);                   /* lea edx, [ebp-0x2c] */
            ii(0x100c_4539, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100c_453c, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100c_453f, 5); calld(0x100c_aa44, 0x6500);             /* call 0x100caa44 */
            ii(0x100c_4544, 2); jmpd(0x100c_451b, -0x2b); goto l_0x100c_451b; /* jmp 0x100c451b */
        l_0x100c_4546:
            ii(0x100c_4546, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4549, 3); mov(al, memb_a32[ds, eax + 0x2]);       /* mov al, [eax+0x2] */
            ii(0x100c_454c, 3); mov(memb_a32[ss, ebp - 0x30], al);      /* mov [ebp-0x30], al */
            ii(0x100c_454f, 5); jmpd(0x100c_5074, 0xb20); goto l_0x100c_5074; /* jmp 0x100c5074 */
        l_0x100c_4554:
            ii(0x100c_4554, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_4558, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100c_455b, 2); if(jzd(0x100c_456c, 0xf)) goto l_0x100c_456c; /* jz 0x100c456c */
            ii(0x100c_455d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_455f, 5); mov(edx, 0x3d);                         /* mov edx, 0x3d */
            ii(0x100c_4564, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4567, 5); calld(0x100c_42ad, -0x2bf);             /* call 0x100c42ad */
        l_0x100c_456c:
            ii(0x100c_456c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_456e, 5); mov(edx, 0x3a);                         /* mov edx, 0x3a */
            ii(0x100c_4573, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4576, 5); calld(0x100c_42ad, -0x2ce);             /* call 0x100c42ad */
            ii(0x100c_457b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_457d, 5); mov(edx, 0x36);                         /* mov edx, 0x36 */
            ii(0x100c_4582, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4585, 5); calld(0x100c_42ad, -0x2dd);             /* call 0x100c42ad */
            ii(0x100c_458a, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_458e, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100c_4591, 2); if(jzd(0x100c_45a2, 0xf)) goto l_0x100c_45a2; /* jz 0x100c45a2 */
            ii(0x100c_4593, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4595, 5); mov(edx, 0x3d);                         /* mov edx, 0x3d */
            ii(0x100c_459a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_459d, 5); calld(0x100c_42ad, -0x2f5);             /* call 0x100c42ad */
        l_0x100c_45a2:
            ii(0x100c_45a2, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_45a4, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x100c_45a9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_45ac, 5); calld(0x100c_42ad, -0x304);             /* call 0x100c42ad */
            ii(0x100c_45b1, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_45b5, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100c_45b8, 2); if(jzd(0x100c_45cc, 0x12)) goto l_0x100c_45cc; /* jz 0x100c45cc */
            ii(0x100c_45ba, 5); mov(ebx, 0x8);                          /* mov ebx, 0x8 */
            ii(0x100c_45bf, 5); mov(edx, 0x31);                         /* mov edx, 0x31 */
            ii(0x100c_45c4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_45c7, 5); calld(0x100c_42ad, -0x31f);             /* call 0x100c42ad */
        l_0x100c_45cc:
            ii(0x100c_45cc, 5); calld(/* sys */ 0x1016_5e9b, 0xa_18ca); /* call 0x10165e9b */
            ii(0x100c_45d1, 3); lea(eax, eax + eax * 4);                /* lea eax, [eax+eax*4] */
            ii(0x100c_45d4, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100c_45d7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_45d9, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100c_45dc, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x100c_45df, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_45e2, 3); add(edx, 0x4);                          /* add edx, 0x4 */
            ii(0x100c_45e5, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100c_45e8, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100c_45ea, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100c_45ed, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x100c_45f0, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x100c_45f2, 3); sar(eax, 0x4);                          /* sar eax, 0x4 */
            ii(0x100c_45f5, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100c_45f8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_45fb, 5); calld(0x100c_7824, 0x3224);             /* call 0x100c7824 */
            ii(0x100c_4600, 5); calld(0x100c_43a0, -0x265);             /* call 0x100c43a0 */
            ii(0x100c_4605, 1); cwde();                                 /* cwde */
            ii(0x100c_4606, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100c_4609, 2); if(jled(0x100c_461a, 0xf)) goto l_0x100c_461a; /* jle 0x100c461a */
            ii(0x100c_460b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_460d, 5); mov(edx, 0x39);                         /* mov edx, 0x39 */
            ii(0x100c_4612, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4615, 5); calld(0x100c_42ad, -0x36d);             /* call 0x100c42ad */
        l_0x100c_461a:
            ii(0x100c_461a, 5); mov(ebx, 0x10);                         /* mov ebx, 0x10 */
            ii(0x100c_461f, 5); mov(edx, 0x38);                         /* mov edx, 0x38 */
            ii(0x100c_4624, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4627, 5); calld(0x100c_42ad, -0x37f);             /* call 0x100c42ad */
            ii(0x100c_462c, 5); calld(0x100c_43a0, -0x291);             /* call 0x100c43a0 */
            ii(0x100c_4631, 1); cwde();                                 /* cwde */
            ii(0x100c_4632, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100c_4635, 2); if(jled(0x100c_4678, 0x41)) goto l_0x100c_4678; /* jle 0x100c4678 */
        l_0x100c_4637:
            ii(0x100c_4637, 5); mov(ebx, 0x8);                          /* mov ebx, 0x8 */
            ii(0x100c_463c, 5); mov(edx, 0x3d);                         /* mov edx, 0x3d */
            ii(0x100c_4641, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4644, 5); calld(0x100c_42ad, -0x39c);             /* call 0x100c42ad */
            ii(0x100c_4649, 2); test(al, al);                           /* test al, al */
            ii(0x100c_464b, 2); if(jzd(0x100c_4673, 0x26)) goto l_0x100c_4673; /* jz 0x100c4673 */
            ii(0x100c_464d, 5); mov(ebx, 0x18);                         /* mov ebx, 0x18 */
            ii(0x100c_4652, 5); mov(edx, 0x3d);                         /* mov edx, 0x3d */
            ii(0x100c_4657, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_465a, 5); calld(0x100c_42ad, -0x3b2);             /* call 0x100c42ad */
            ii(0x100c_465f, 5); mov(ebx, 0x14);                         /* mov ebx, 0x14 */
            ii(0x100c_4664, 5); mov(edx, 0x31);                         /* mov edx, 0x31 */
            ii(0x100c_4669, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_466c, 5); calld(0x100c_42ad, -0x3c4);             /* call 0x100c42ad */
            ii(0x100c_4671, 2); jmpd(0x100c_4637, -0x3c); goto l_0x100c_4637; /* jmp 0x100c4637 */
        l_0x100c_4673:
            ii(0x100c_4673, 5); jmpd(0x100c_46ec, 0x74); goto l_0x100c_46ec; /* jmp 0x100c46ec */
        l_0x100c_4678:
            ii(0x100c_4678, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_467a, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100c_467f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4682, 5); calld(0x100c_42ad, -0x3da);             /* call 0x100c42ad */
            ii(0x100c_4687, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x100c_468a, 3); mov(edx, memd_a32[ds, edx + 0xe]);      /* mov edx, [edx+0xe] */
            ii(0x100c_468d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_4690, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100c_4692, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100c_4695, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100c_4697, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100c_4699, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100c_469c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_469f, 5); calld(0x100c_7824, 0x3180);             /* call 0x100c7824 */
            ii(0x100c_46a4, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x100c_46a9, 5); calld(0x1007_5fdc, -0x4_e6d2);          /* call 0x10075fdc */
            ii(0x100c_46ae, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100c_46b1, 2); if(jged(0x100c_46d9, 0x26)) goto l_0x100c_46d9; /* jge 0x100c46d9 */
        l_0x100c_46b3:
            ii(0x100c_46b3, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_46b5, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x100c_46ba, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_46bd, 5); calld(0x100c_42ad, -0x415);             /* call 0x100c42ad */
            ii(0x100c_46c2, 2); test(al, al);                           /* test al, al */
            ii(0x100c_46c4, 2); if(jzd(0x100c_46d7, 0x11)) goto l_0x100c_46d7; /* jz 0x100c46d7 */
            ii(0x100c_46c6, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_46c8, 5); mov(edx, 0x36);                         /* mov edx, 0x36 */
            ii(0x100c_46cd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_46d0, 5); calld(0x100c_42ad, -0x428);             /* call 0x100c42ad */
            ii(0x100c_46d5, 2); jmpd(0x100c_46b3, -0x24); goto l_0x100c_46b3; /* jmp 0x100c46b3 */
        l_0x100c_46d7:
            ii(0x100c_46d7, 2); jmpd(0x100c_46ec, 0x13); goto l_0x100c_46ec; /* jmp 0x100c46ec */
        l_0x100c_46d9:
            ii(0x100c_46d9, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_46db, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x100c_46e0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_46e3, 5); calld(0x100c_42ad, -0x43b);             /* call 0x100c42ad */
            ii(0x100c_46e8, 2); test(al, al);                           /* test al, al */
            ii(0x100c_46ea, 2); if(jnzd(0x100c_46d9, -0x13)) goto l_0x100c_46d9; /* jnz 0x100c46d9 */
        l_0x100c_46ec:
            ii(0x100c_46ec, 5); jmpd(0x100c_5091, 0x9a0); goto l_0x100c_5091; /* jmp 0x100c5091 */
        l_0x100c_46f1:
            ii(0x100c_46f1, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_46f3, 5); mov(edx, 0x3a);                         /* mov edx, 0x3a */
            ii(0x100c_46f8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_46fb, 5); calld(0x100c_42ad, -0x453);             /* call 0x100c42ad */
            ii(0x100c_4700, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4702, 5); mov(edx, 0x36);                         /* mov edx, 0x36 */
            ii(0x100c_4707, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_470a, 5); calld(0x100c_42ad, -0x462);             /* call 0x100c42ad */
            ii(0x100c_470f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4711, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x100c_4716, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4719, 5); calld(0x100c_42ad, -0x471);             /* call 0x100c42ad */
            ii(0x100c_471e, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_4722, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100c_4725, 2); if(jzd(0x100c_4736, 0xf)) goto l_0x100c_4736; /* jz 0x100c4736 */
            ii(0x100c_4727, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4729, 5); mov(edx, 0x3d);                         /* mov edx, 0x3d */
            ii(0x100c_472e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4731, 5); calld(0x100c_42ad, -0x489);             /* call 0x100c42ad */
        l_0x100c_4736:
            ii(0x100c_4736, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4738, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100c_473d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4740, 5); calld(0x100c_42ad, -0x498);             /* call 0x100c42ad */
            ii(0x100c_4745, 5); calld(0x100c_43a0, -0x3aa);             /* call 0x100c43a0 */
            ii(0x100c_474a, 1); cwde();                                 /* cwde */
            ii(0x100c_474b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_474d, 2); if(jled(0x100c_4758, 0x9)) goto l_0x100c_4758; /* jle 0x100c4758 */
            ii(0x100c_474f, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_4753, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100c_4756, 2); if(jnzd(0x100c_475a, 0x2)) goto l_0x100c_475a; /* jnz 0x100c475a */
        l_0x100c_4758:
            ii(0x100c_4758, 2); jmpd(0x100c_4769, 0xf); goto l_0x100c_4769; /* jmp 0x100c4769 */
        l_0x100c_475a:
            ii(0x100c_475a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_475c, 5); mov(edx, 0x31);                         /* mov edx, 0x31 */
            ii(0x100c_4761, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4764, 5); calld(0x100c_42ad, -0x4bc);             /* call 0x100c42ad */
        l_0x100c_4769:
            ii(0x100c_4769, 5); calld(/* sys */ 0x1016_5e9b, 0xa_172d); /* call 0x10165e9b */
            ii(0x100c_476e, 3); lea(eax, eax + eax * 4);                /* lea eax, [eax+eax*4] */
            ii(0x100c_4771, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100c_4774, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_4776, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100c_4779, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x100c_477c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_477f, 3); add(edx, 0x4);                          /* add edx, 0x4 */
            ii(0x100c_4782, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100c_4785, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100c_4787, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100c_478a, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x100c_478d, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x100c_478f, 3); sar(eax, 0x4);                          /* sar eax, 0x4 */
            ii(0x100c_4792, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100c_4795, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4798, 5); calld(0x100c_7824, 0x3087);             /* call 0x100c7824 */
            ii(0x100c_479d, 5); calld(0x100c_43a0, -0x402);             /* call 0x100c43a0 */
            ii(0x100c_47a2, 1); cwde();                                 /* cwde */
            ii(0x100c_47a3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_47a5, 2); if(jled(0x100c_47b0, 0x9)) goto l_0x100c_47b0; /* jle 0x100c47b0 */
            ii(0x100c_47a7, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_47ab, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100c_47ae, 2); if(jnzd(0x100c_47b2, 0x2)) goto l_0x100c_47b2; /* jnz 0x100c47b2 */
        l_0x100c_47b0:
            ii(0x100c_47b0, 2); jmpd(0x100c_47c1, 0xf); goto l_0x100c_47c1; /* jmp 0x100c47c1 */
        l_0x100c_47b2:
            ii(0x100c_47b2, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_47b4, 5); mov(edx, 0x3d);                         /* mov edx, 0x3d */
            ii(0x100c_47b9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_47bc, 5); calld(0x100c_42ad, -0x514);             /* call 0x100c42ad */
        l_0x100c_47c1:
            ii(0x100c_47c1, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_47c3, 5); mov(edx, 0x36);                         /* mov edx, 0x36 */
            ii(0x100c_47c8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_47cb, 5); calld(0x100c_42ad, -0x523);             /* call 0x100c42ad */
            ii(0x100c_47d0, 5); calld(0x100c_43a0, -0x435);             /* call 0x100c43a0 */
            ii(0x100c_47d5, 1); cwde();                                 /* cwde */
            ii(0x100c_47d6, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100c_47d9, 2); if(jled(0x100c_47ea, 0xf)) goto l_0x100c_47ea; /* jle 0x100c47ea */
            ii(0x100c_47db, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_47dd, 5); mov(edx, 0x39);                         /* mov edx, 0x39 */
            ii(0x100c_47e2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_47e5, 5); calld(0x100c_42ad, -0x53d);             /* call 0x100c42ad */
        l_0x100c_47ea:
            ii(0x100c_47ea, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_47ec, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x100c_47f1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_47f4, 5); calld(0x100c_42ad, -0x54c);             /* call 0x100c42ad */
            ii(0x100c_47f9, 2); test(al, al);                           /* test al, al */
            ii(0x100c_47fb, 2); if(jzd(0x100c_483d, 0x40)) goto l_0x100c_483d; /* jz 0x100c483d */
            ii(0x100c_47fd, 5); calld(0x100c_43a0, -0x462);             /* call 0x100c43a0 */
            ii(0x100c_4802, 1); cwde();                                 /* cwde */
            ii(0x100c_4803, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100c_4806, 2); if(jled(0x100c_482c, 0x24)) goto l_0x100c_482c; /* jle 0x100c482c */
            ii(0x100c_4808, 5); mov(ebx, 0x14);                         /* mov ebx, 0x14 */
            ii(0x100c_480d, 5); mov(edx, 0x31);                         /* mov edx, 0x31 */
            ii(0x100c_4812, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4815, 5); calld(0x100c_42ad, -0x56d);             /* call 0x100c42ad */
            ii(0x100c_481a, 5); mov(ebx, 0x8);                          /* mov ebx, 0x8 */
            ii(0x100c_481f, 5); mov(edx, 0x3d);                         /* mov edx, 0x3d */
            ii(0x100c_4824, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4827, 5); calld(0x100c_42ad, -0x57f);             /* call 0x100c42ad */
        l_0x100c_482c:
            ii(0x100c_482c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_482e, 5); mov(edx, 0x36);                         /* mov edx, 0x36 */
            ii(0x100c_4833, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4836, 5); calld(0x100c_42ad, -0x58e);             /* call 0x100c42ad */
            ii(0x100c_483b, 2); jmpd(0x100c_47ea, -0x53); goto l_0x100c_47ea; /* jmp 0x100c47ea */
        l_0x100c_483d:
            ii(0x100c_483d, 5); jmpd(0x100c_5091, 0x84f); goto l_0x100c_5091; /* jmp 0x100c5091 */
        l_0x100c_4842:
            ii(0x100c_4842, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4844, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100c_4849, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_484c, 5); calld(0x100c_42ad, -0x5a4);             /* call 0x100c42ad */
            ii(0x100c_4851, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4853, 5); mov(edx, 0x3a);                         /* mov edx, 0x3a */
            ii(0x100c_4858, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_485b, 5); calld(0x100c_42ad, -0x5b3);             /* call 0x100c42ad */
            ii(0x100c_4860, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4862, 5); mov(edx, 0x36);                         /* mov edx, 0x36 */
            ii(0x100c_4867, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_486a, 5); calld(0x100c_42ad, -0x5c2);             /* call 0x100c42ad */
            ii(0x100c_486f, 5); calld(0x100c_43a0, -0x4d4);             /* call 0x100c43a0 */
            ii(0x100c_4874, 1); cwde();                                 /* cwde */
            ii(0x100c_4875, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_4877, 2); if(jled(0x100c_4882, 0x9)) goto l_0x100c_4882; /* jle 0x100c4882 */
            ii(0x100c_4879, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_487d, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100c_4880, 2); if(jnzd(0x100c_4884, 0x2)) goto l_0x100c_4884; /* jnz 0x100c4884 */
        l_0x100c_4882:
            ii(0x100c_4882, 2); jmpd(0x100c_4896, 0x12); goto l_0x100c_4896; /* jmp 0x100c4896 */
        l_0x100c_4884:
            ii(0x100c_4884, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x100c_4889, 5); mov(edx, 0x31);                         /* mov edx, 0x31 */
            ii(0x100c_488e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4891, 5); calld(0x100c_42ad, -0x5e9);             /* call 0x100c42ad */
        l_0x100c_4896:
            ii(0x100c_4896, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_489a, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100c_489d, 2); if(jzd(0x100c_48b1, 0x12)) goto l_0x100c_48b1; /* jz 0x100c48b1 */
            ii(0x100c_489f, 5); mov(ebx, 0x8);                          /* mov ebx, 0x8 */
            ii(0x100c_48a4, 5); mov(edx, 0x3d);                         /* mov edx, 0x3d */
            ii(0x100c_48a9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_48ac, 5); calld(0x100c_42ad, -0x604);             /* call 0x100c42ad */
        l_0x100c_48b1:
            ii(0x100c_48b1, 5); calld(/* sys */ 0x1016_5e9b, 0xa_15e5); /* call 0x10165e9b */
            ii(0x100c_48b6, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_48b9, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100c_48bc, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x100c_48bf, 3); mov(edx, memd_a32[ds, edx + 0xe]);      /* mov edx, [edx+0xe] */
            ii(0x100c_48c2, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_48c5, 1); inc(eax);                               /* inc eax */
            ii(0x100c_48c6, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100c_48c9, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100c_48cb, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100c_48ce, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x100c_48d1, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x100c_48d3, 3); sar(eax, 0x4);                          /* sar eax, 0x4 */
            ii(0x100c_48d6, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100c_48d9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_48dc, 5); calld(0x100c_7824, 0x2f43);             /* call 0x100c7824 */
            ii(0x100c_48e1, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_48e3, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100c_48e8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_48eb, 5); calld(0x100c_42ad, -0x643);             /* call 0x100c42ad */
            ii(0x100c_48f0, 5); calld(0x100c_43a0, -0x555);             /* call 0x100c43a0 */
            ii(0x100c_48f5, 1); cwde();                                 /* cwde */
            ii(0x100c_48f6, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100c_48f9, 2); if(jled(0x100c_4937, 0x3c)) goto l_0x100c_4937; /* jle 0x100c4937 */
            ii(0x100c_48fb, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_48fd, 5); mov(edx, 0x39);                         /* mov edx, 0x39 */
            ii(0x100c_4902, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4905, 5); calld(0x100c_42ad, -0x65d);             /* call 0x100c42ad */
            ii(0x100c_490a, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_490e, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100c_4911, 2); if(jzd(0x100c_4937, 0x24)) goto l_0x100c_4937; /* jz 0x100c4937 */
            ii(0x100c_4913, 5); mov(ebx, 0x28);                         /* mov ebx, 0x28 */
            ii(0x100c_4918, 5); mov(edx, 0x31);                         /* mov edx, 0x31 */
            ii(0x100c_491d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4920, 5); calld(0x100c_42ad, -0x678);             /* call 0x100c42ad */
            ii(0x100c_4925, 5); mov(ebx, 0x8);                          /* mov ebx, 0x8 */
            ii(0x100c_492a, 5); mov(edx, 0x3d);                         /* mov edx, 0x3d */
            ii(0x100c_492f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4932, 5); calld(0x100c_42ad, -0x68a);             /* call 0x100c42ad */
        l_0x100c_4937:
            ii(0x100c_4937, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4939, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100c_493e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4941, 5); calld(0x100c_42ad, -0x699);             /* call 0x100c42ad */
            ii(0x100c_4946, 5); calld(0x100c_43a0, -0x5ab);             /* call 0x100c43a0 */
            ii(0x100c_494b, 1); cwde();                                 /* cwde */
            ii(0x100c_494c, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100c_494f, 2); if(jled(0x100c_4969, 0x18)) goto l_0x100c_4969; /* jle 0x100c4969 */
        l_0x100c_4951:
            ii(0x100c_4951, 5); mov(ebx, 0x28);                         /* mov ebx, 0x28 */
            ii(0x100c_4956, 5); mov(edx, 0x31);                         /* mov edx, 0x31 */
            ii(0x100c_495b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_495e, 5); calld(0x100c_42ad, -0x6b6);             /* call 0x100c42ad */
            ii(0x100c_4963, 2); test(al, al);                           /* test al, al */
            ii(0x100c_4965, 2); if(jnzd(0x100c_4951, -0x16)) goto l_0x100c_4951; /* jnz 0x100c4951 */
            ii(0x100c_4967, 2); jmpd(0x100c_4999, 0x30); goto l_0x100c_4999; /* jmp 0x100c4999 */
        l_0x100c_4969:
            ii(0x100c_4969, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x100c_496c, 3); mov(edx, memd_a32[ds, edx + 0xe]);      /* mov edx, [edx+0xe] */
            ii(0x100c_496f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_4972, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100c_4974, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100c_4977, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100c_4979, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100c_497b, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100c_497e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4981, 5); calld(0x100c_7824, 0x2e9e);             /* call 0x100c7824 */
        l_0x100c_4986:
            ii(0x100c_4986, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4988, 5); mov(edx, 0x36);                         /* mov edx, 0x36 */
            ii(0x100c_498d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4990, 5); calld(0x100c_42ad, -0x6e8);             /* call 0x100c42ad */
            ii(0x100c_4995, 2); test(al, al);                           /* test al, al */
            ii(0x100c_4997, 2); if(jnzd(0x100c_4986, -0x13)) goto l_0x100c_4986; /* jnz 0x100c4986 */
        l_0x100c_4999:
            ii(0x100c_4999, 5); jmpd(0x100c_5091, 0x6f3); goto l_0x100c_5091; /* jmp 0x100c5091 */
        l_0x100c_499e:
            ii(0x100c_499e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_49a0, 5); mov(edx, 0x3a);                         /* mov edx, 0x3a */
            ii(0x100c_49a5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_49a8, 5); calld(0x100c_42ad, -0x700);             /* call 0x100c42ad */
            ii(0x100c_49ad, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_49af, 5); mov(edx, 0x36);                         /* mov edx, 0x36 */
            ii(0x100c_49b4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_49b7, 5); calld(0x100c_42ad, -0x70f);             /* call 0x100c42ad */
            ii(0x100c_49bc, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_49c0, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100c_49c3, 2); if(jzd(0x100c_49d4, 0xf)) goto l_0x100c_49d4; /* jz 0x100c49d4 */
            ii(0x100c_49c5, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_49c7, 5); mov(edx, 0x3d);                         /* mov edx, 0x3d */
            ii(0x100c_49cc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_49cf, 5); calld(0x100c_42ad, -0x727);             /* call 0x100c42ad */
        l_0x100c_49d4:
            ii(0x100c_49d4, 5); calld(0x100c_43a0, -0x639);             /* call 0x100c43a0 */
            ii(0x100c_49d9, 1); cwde();                                 /* cwde */
            ii(0x100c_49da, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_49dc, 2); if(jled(0x100c_49e7, 0x9)) goto l_0x100c_49e7; /* jle 0x100c49e7 */
            ii(0x100c_49de, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_49e2, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100c_49e5, 2); if(jnzd(0x100c_49e9, 0x2)) goto l_0x100c_49e9; /* jnz 0x100c49e9 */
        l_0x100c_49e7:
            ii(0x100c_49e7, 2); jmpd(0x100c_49f8, 0xf); goto l_0x100c_49f8; /* jmp 0x100c49f8 */
        l_0x100c_49e9:
            ii(0x100c_49e9, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_49eb, 5); mov(edx, 0x31);                         /* mov edx, 0x31 */
            ii(0x100c_49f0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_49f3, 5); calld(0x100c_42ad, -0x74b);             /* call 0x100c42ad */
        l_0x100c_49f8:
            ii(0x100c_49f8, 5); calld(/* sys */ 0x1016_5e9b, 0xa_149e); /* call 0x10165e9b */
            ii(0x100c_49fd, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_4a00, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100c_4a03, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x100c_4a06, 3); mov(edx, memd_a32[ds, edx + 0xe]);      /* mov edx, [edx+0xe] */
            ii(0x100c_4a09, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_4a0c, 1); inc(eax);                               /* inc eax */
            ii(0x100c_4a0d, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100c_4a10, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100c_4a12, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100c_4a15, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x100c_4a18, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x100c_4a1a, 3); sar(eax, 0x4);                          /* sar eax, 0x4 */
            ii(0x100c_4a1d, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100c_4a20, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4a23, 5); calld(0x100c_7824, 0x2dfc);             /* call 0x100c7824 */
            ii(0x100c_4a28, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4a2a, 5); mov(edx, 0x37);                         /* mov edx, 0x37 */
            ii(0x100c_4a2f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4a32, 5); calld(0x100c_42ad, -0x78a);             /* call 0x100c42ad */
            ii(0x100c_4a37, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4a39, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100c_4a3e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4a41, 5); calld(0x100c_42ad, -0x799);             /* call 0x100c42ad */
            ii(0x100c_4a46, 5); calld(0x100c_43a0, -0x6ab);             /* call 0x100c43a0 */
            ii(0x100c_4a4b, 1); cwde();                                 /* cwde */
            ii(0x100c_4a4c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_4a4e, 2); if(jled(0x100c_4a59, 0x9)) goto l_0x100c_4a59; /* jle 0x100c4a59 */
            ii(0x100c_4a50, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_4a54, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100c_4a57, 2); if(jnzd(0x100c_4a5b, 0x2)) goto l_0x100c_4a5b; /* jnz 0x100c4a5b */
        l_0x100c_4a59:
            ii(0x100c_4a59, 2); jmpd(0x100c_4a6a, 0xf); goto l_0x100c_4a6a; /* jmp 0x100c4a6a */
        l_0x100c_4a5b:
            ii(0x100c_4a5b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4a5d, 5); mov(edx, 0x3d);                         /* mov edx, 0x3d */
            ii(0x100c_4a62, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4a65, 5); calld(0x100c_42ad, -0x7bd);             /* call 0x100c42ad */
        l_0x100c_4a6a:
            ii(0x100c_4a6a, 5); calld(0x100c_43a0, -0x6cf);             /* call 0x100c43a0 */
            ii(0x100c_4a6f, 1); cwde();                                 /* cwde */
            ii(0x100c_4a70, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100c_4a73, 2); if(jled(0x100c_4a96, 0x21)) goto l_0x100c_4a96; /* jle 0x100c4a96 */
            ii(0x100c_4a75, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4a77, 5); mov(edx, 0x39);                         /* mov edx, 0x39 */
            ii(0x100c_4a7c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4a7f, 5); calld(0x100c_42ad, -0x7d7);             /* call 0x100c42ad */
            ii(0x100c_4a84, 5); mov(ebx, 0x28);                         /* mov ebx, 0x28 */
            ii(0x100c_4a89, 5); mov(edx, 0x31);                         /* mov edx, 0x31 */
            ii(0x100c_4a8e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4a91, 5); calld(0x100c_42ad, -0x7e9);             /* call 0x100c42ad */
        l_0x100c_4a96:
            ii(0x100c_4a96, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4a98, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100c_4a9d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4aa0, 5); calld(0x100c_42ad, -0x7f8);             /* call 0x100c42ad */
            ii(0x100c_4aa5, 5); calld(0x100c_43a0, -0x70a);             /* call 0x100c43a0 */
            ii(0x100c_4aaa, 1); cwde();                                 /* cwde */
            ii(0x100c_4aab, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100c_4aae, 2); if(jled(0x100c_4ac2, 0x12)) goto l_0x100c_4ac2; /* jle 0x100c4ac2 */
            ii(0x100c_4ab0, 5); mov(ebx, 0x8);                          /* mov ebx, 0x8 */
            ii(0x100c_4ab5, 5); mov(edx, 0x3d);                         /* mov edx, 0x3d */
            ii(0x100c_4aba, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4abd, 5); calld(0x100c_42ad, -0x815);             /* call 0x100c42ad */
        l_0x100c_4ac2:
            ii(0x100c_4ac2, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4ac4, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100c_4ac9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4acc, 5); calld(0x100c_42ad, -0x824);             /* call 0x100c42ad */
            ii(0x100c_4ad1, 5); calld(0x100c_43a0, -0x736);             /* call 0x100c43a0 */
            ii(0x100c_4ad6, 1); cwde();                                 /* cwde */
            ii(0x100c_4ad7, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100c_4ada, 2); if(jled(0x100c_4af4, 0x18)) goto l_0x100c_4af4; /* jle 0x100c4af4 */
        l_0x100c_4adc:
            ii(0x100c_4adc, 5); mov(ebx, 0x28);                         /* mov ebx, 0x28 */
            ii(0x100c_4ae1, 5); mov(edx, 0x31);                         /* mov edx, 0x31 */
            ii(0x100c_4ae6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4ae9, 5); calld(0x100c_42ad, -0x841);             /* call 0x100c42ad */
            ii(0x100c_4aee, 2); test(al, al);                           /* test al, al */
            ii(0x100c_4af0, 2); if(jnzd(0x100c_4adc, -0x16)) goto l_0x100c_4adc; /* jnz 0x100c4adc */
            ii(0x100c_4af2, 2); jmpd(0x100c_4b24, 0x30); goto l_0x100c_4b24; /* jmp 0x100c4b24 */
        l_0x100c_4af4:
            ii(0x100c_4af4, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x100c_4af7, 3); mov(edx, memd_a32[ds, edx + 0xe]);      /* mov edx, [edx+0xe] */
            ii(0x100c_4afa, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_4afd, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100c_4aff, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100c_4b02, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100c_4b04, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100c_4b06, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100c_4b09, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4b0c, 5); calld(0x100c_7824, 0x2d13);             /* call 0x100c7824 */
        l_0x100c_4b11:
            ii(0x100c_4b11, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4b13, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100c_4b18, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4b1b, 5); calld(0x100c_42ad, -0x873);             /* call 0x100c42ad */
            ii(0x100c_4b20, 2); test(al, al);                           /* test al, al */
            ii(0x100c_4b22, 2); if(jnzd(0x100c_4b11, -0x13)) goto l_0x100c_4b11; /* jnz 0x100c4b11 */
        l_0x100c_4b24:
            ii(0x100c_4b24, 5); jmpd(0x100c_5091, 0x568); goto l_0x100c_5091; /* jmp 0x100c5091 */
        l_0x100c_4b29:
            ii(0x100c_4b29, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_4b2d, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100c_4b30, 2); if(jzd(0x100c_4b41, 0xf)) goto l_0x100c_4b41; /* jz 0x100c4b41 */
            ii(0x100c_4b32, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4b34, 5); mov(edx, 0x3d);                         /* mov edx, 0x3d */
            ii(0x100c_4b39, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4b3c, 5); calld(0x100c_42ad, -0x894);             /* call 0x100c42ad */
        l_0x100c_4b41:
            ii(0x100c_4b41, 5); calld(/* sys */ 0x1016_5e9b, 0xa_1355); /* call 0x10165e9b */
            ii(0x100c_4b46, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_4b49, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100c_4b4c, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x100c_4b4f, 3); mov(edx, memd_a32[ds, edx + 0xe]);      /* mov edx, [edx+0xe] */
            ii(0x100c_4b52, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_4b55, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x100c_4b58, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100c_4b5b, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100c_4b5d, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100c_4b60, 3); shl(edx, 0x3);                          /* shl edx, 0x3 */
            ii(0x100c_4b63, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x100c_4b65, 3); sar(eax, 0x3);                          /* sar eax, 0x3 */
            ii(0x100c_4b68, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100c_4b6b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4b6e, 5); calld(0x100c_7824, 0x2cb1);             /* call 0x100c7824 */
        l_0x100c_4b73:
            ii(0x100c_4b73, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4b75, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100c_4b7a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4b7d, 5); calld(0x100c_42ad, -0x8d5);             /* call 0x100c42ad */
            ii(0x100c_4b82, 2); test(al, al);                           /* test al, al */
            ii(0x100c_4b84, 2); if(jnzd(0x100c_4b73, -0x13)) goto l_0x100c_4b73; /* jnz 0x100c4b73 */
            ii(0x100c_4b86, 5); jmpd(0x100c_5091, 0x506); goto l_0x100c_5091; /* jmp 0x100c5091 */
        l_0x100c_4b8b:
            ii(0x100c_4b8b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4b8d, 5); mov(edx, 0x3a);                         /* mov edx, 0x3a */
            ii(0x100c_4b92, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4b95, 5); calld(0x100c_42ad, -0x8ed);             /* call 0x100c42ad */
            ii(0x100c_4b9a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4b9c, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100c_4ba1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4ba4, 5); calld(0x100c_42ad, -0x8fc);             /* call 0x100c42ad */
            ii(0x100c_4ba9, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4bab, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x100c_4bb0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4bb3, 5); calld(0x100c_42ad, -0x90b);             /* call 0x100c42ad */
            ii(0x100c_4bb8, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4bba, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100c_4bbf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4bc2, 5); calld(0x100c_42ad, -0x91a);             /* call 0x100c42ad */
            ii(0x100c_4bc7, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4bc9, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x100c_4bce, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4bd1, 5); calld(0x100c_42ad, -0x929);             /* call 0x100c42ad */
            ii(0x100c_4bd6, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4bd8, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100c_4bdd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4be0, 5); calld(0x100c_42ad, -0x938);             /* call 0x100c42ad */
            ii(0x100c_4be5, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4be7, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x100c_4bec, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4bef, 5); calld(0x100c_42ad, -0x947);             /* call 0x100c42ad */
            ii(0x100c_4bf4, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4bf6, 5); mov(edx, 0x3f);                         /* mov edx, 0x3f */
            ii(0x100c_4bfb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4bfe, 5); calld(0x100c_42ad, -0x956);             /* call 0x100c42ad */
            ii(0x100c_4c03, 5); calld(/* sys */ 0x1016_5e9b, 0xa_1293); /* call 0x10165e9b */
            ii(0x100c_4c08, 3); imul(eax, eax, 0x6);                    /* imul eax, eax, 0x6 */
            ii(0x100c_4c0b, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100c_4c0e, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x100c_4c11, 3); mov(edx, memd_a32[ds, edx + 0xe]);      /* mov edx, [edx+0xe] */
            ii(0x100c_4c14, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_4c17, 1); inc(eax);                               /* inc eax */
            ii(0x100c_4c18, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100c_4c1b, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100c_4c1d, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100c_4c20, 3); shl(edx, 0x3);                          /* shl edx, 0x3 */
            ii(0x100c_4c23, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x100c_4c25, 3); sar(eax, 0x3);                          /* sar eax, 0x3 */
            ii(0x100c_4c28, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100c_4c2b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4c2e, 5); calld(0x100c_7824, 0x2bf1);             /* call 0x100c7824 */
            ii(0x100c_4c33, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4c35, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x100c_4c3a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4c3d, 5); calld(0x100c_42ad, -0x995);             /* call 0x100c42ad */
            ii(0x100c_4c42, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4c44, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x100c_4c49, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4c4c, 5); calld(0x100c_42ad, -0x9a4);             /* call 0x100c42ad */
            ii(0x100c_4c51, 5); calld(0x100c_43a0, -0x8b6);             /* call 0x100c43a0 */
            ii(0x100c_4c56, 1); cwde();                                 /* cwde */
            ii(0x100c_4c57, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100c_4c5a, 2); if(jled(0x100c_4c6b, 0xf)) goto l_0x100c_4c6b; /* jle 0x100c4c6b */
            ii(0x100c_4c5c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4c5e, 5); mov(edx, 0x3d);                         /* mov edx, 0x3d */
            ii(0x100c_4c63, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4c66, 5); calld(0x100c_42ad, -0x9be);             /* call 0x100c42ad */
        l_0x100c_4c6b:
            ii(0x100c_4c6b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4c6d, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x100c_4c72, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4c75, 5); calld(0x100c_42ad, -0x9cd);             /* call 0x100c42ad */
            ii(0x100c_4c7a, 2); test(al, al);                           /* test al, al */
            ii(0x100c_4c7c, 2); if(jnzd(0x100c_4c6b, -0x13)) goto l_0x100c_4c6b; /* jnz 0x100c4c6b */
            ii(0x100c_4c7e, 5); jmpd(0x100c_5091, 0x40e); goto l_0x100c_5091; /* jmp 0x100c5091 */
        l_0x100c_4c83:
            ii(0x100c_4c83, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_4c87, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100c_4c8a, 2); if(jzd(0x100c_4c9b, 0xf)) goto l_0x100c_4c9b; /* jz 0x100c4c9b */
            ii(0x100c_4c8c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4c8e, 5); mov(edx, 0x3d);                         /* mov edx, 0x3d */
            ii(0x100c_4c93, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4c96, 5); calld(0x100c_42ad, -0x9ee);             /* call 0x100c42ad */
        l_0x100c_4c9b:
            ii(0x100c_4c9b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4c9d, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100c_4ca2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4ca5, 5); calld(0x100c_42ad, -0x9fd);             /* call 0x100c42ad */
            ii(0x100c_4caa, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4cac, 5); mov(edx, 0x34);                         /* mov edx, 0x34 */
            ii(0x100c_4cb1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4cb4, 5); calld(0x100c_42ad, -0xa0c);             /* call 0x100c42ad */
            ii(0x100c_4cb9, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4cbb, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100c_4cc0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4cc3, 5); calld(0x100c_42ad, -0xa1b);             /* call 0x100c42ad */
            ii(0x100c_4cc8, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4cca, 5); mov(edx, 0x34);                         /* mov edx, 0x34 */
            ii(0x100c_4ccf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4cd2, 5); calld(0x100c_42ad, -0xa2a);             /* call 0x100c42ad */
            ii(0x100c_4cd7, 5); calld(0x100c_43a0, -0x93c);             /* call 0x100c43a0 */
            ii(0x100c_4cdc, 1); cwde();                                 /* cwde */
            ii(0x100c_4cdd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_4cdf, 2); if(jled(0x100c_4cea, 0x9)) goto l_0x100c_4cea; /* jle 0x100c4cea */
            ii(0x100c_4ce1, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_4ce5, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100c_4ce8, 2); if(jnzd(0x100c_4cec, 0x2)) goto l_0x100c_4cec; /* jnz 0x100c4cec */
        l_0x100c_4cea:
            ii(0x100c_4cea, 2); jmpd(0x100c_4cfb, 0xf); goto l_0x100c_4cfb; /* jmp 0x100c4cfb */
        l_0x100c_4cec:
            ii(0x100c_4cec, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4cee, 5); mov(edx, 0x31);                         /* mov edx, 0x31 */
            ii(0x100c_4cf3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4cf6, 5); calld(0x100c_42ad, -0xa4e);             /* call 0x100c42ad */
        l_0x100c_4cfb:
            ii(0x100c_4cfb, 5); calld(/* sys */ 0x1016_5e9b, 0xa_119b); /* call 0x10165e9b */
            ii(0x100c_4d00, 3); lea(eax, eax + eax * 4);                /* lea eax, [eax+eax*4] */
            ii(0x100c_4d03, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100c_4d06, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x100c_4d09, 3); mov(edx, memd_a32[ds, edx + 0xe]);      /* mov edx, [edx+0xe] */
            ii(0x100c_4d0c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_4d0f, 3); add(eax, 0x3);                          /* add eax, 0x3 */
            ii(0x100c_4d12, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100c_4d15, 5); mov(ebx, 0xc);                          /* mov ebx, 0xc */
            ii(0x100c_4d1a, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100c_4d1c, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100c_4d1f, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100c_4d21, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100c_4d24, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4d27, 5); calld(0x100c_7824, 0x2af8);             /* call 0x100c7824 */
            ii(0x100c_4d2c, 5); calld(0x100c_43a0, -0x991);             /* call 0x100c43a0 */
            ii(0x100c_4d31, 1); cwde();                                 /* cwde */
            ii(0x100c_4d32, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_4d34, 2); if(jled(0x100c_4d3f, 0x9)) goto l_0x100c_4d3f; /* jle 0x100c4d3f */
            ii(0x100c_4d36, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_4d3a, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100c_4d3d, 2); if(jnzd(0x100c_4d41, 0x2)) goto l_0x100c_4d41; /* jnz 0x100c4d41 */
        l_0x100c_4d3f:
            ii(0x100c_4d3f, 2); jmpd(0x100c_4d50, 0xf); goto l_0x100c_4d50; /* jmp 0x100c4d50 */
        l_0x100c_4d41:
            ii(0x100c_4d41, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4d43, 5); mov(edx, 0x3d);                         /* mov edx, 0x3d */
            ii(0x100c_4d48, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4d4b, 5); calld(0x100c_42ad, -0xaa3);             /* call 0x100c42ad */
        l_0x100c_4d50:
            ii(0x100c_4d50, 5); calld(0x100c_43a0, -0x9b5);             /* call 0x100c43a0 */
            ii(0x100c_4d55, 1); cwde();                                 /* cwde */
            ii(0x100c_4d56, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100c_4d59, 2); if(jled(0x100c_4d6a, 0xf)) goto l_0x100c_4d6a; /* jle 0x100c4d6a */
            ii(0x100c_4d5b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4d5d, 5); mov(edx, 0x39);                         /* mov edx, 0x39 */
            ii(0x100c_4d62, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4d65, 5); calld(0x100c_42ad, -0xabd);             /* call 0x100c42ad */
        l_0x100c_4d6a:
            ii(0x100c_4d6a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4d6c, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100c_4d71, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4d74, 5); calld(0x100c_42ad, -0xacc);             /* call 0x100c42ad */
            ii(0x100c_4d79, 2); test(al, al);                           /* test al, al */
            ii(0x100c_4d7b, 2); if(jzd(0x100c_4ddb, 0x5e)) goto l_0x100c_4ddb; /* jz 0x100c4ddb */
            ii(0x100c_4d7d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4d7f, 5); mov(edx, 0x34);                         /* mov edx, 0x34 */
            ii(0x100c_4d84, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4d87, 5); calld(0x100c_42ad, -0xadf);             /* call 0x100c42ad */
            ii(0x100c_4d8c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4d8e, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100c_4d93, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4d96, 5); calld(0x100c_42ad, -0xaee);             /* call 0x100c42ad */
            ii(0x100c_4d9b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4d9d, 5); mov(edx, 0x34);                         /* mov edx, 0x34 */
            ii(0x100c_4da2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4da5, 5); calld(0x100c_42ad, -0xafd);             /* call 0x100c42ad */
            ii(0x100c_4daa, 5); calld(0x100c_43a0, -0xa0f);             /* call 0x100c43a0 */
            ii(0x100c_4daf, 1); cwde();                                 /* cwde */
            ii(0x100c_4db0, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100c_4db3, 2); if(jled(0x100c_4dd9, 0x24)) goto l_0x100c_4dd9; /* jle 0x100c4dd9 */
            ii(0x100c_4db5, 5); mov(ebx, 0x14);                         /* mov ebx, 0x14 */
            ii(0x100c_4dba, 5); mov(edx, 0x31);                         /* mov edx, 0x31 */
            ii(0x100c_4dbf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4dc2, 5); calld(0x100c_42ad, -0xb1a);             /* call 0x100c42ad */
            ii(0x100c_4dc7, 5); mov(ebx, 0x8);                          /* mov ebx, 0x8 */
            ii(0x100c_4dcc, 5); mov(edx, 0x3d);                         /* mov edx, 0x3d */
            ii(0x100c_4dd1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4dd4, 5); calld(0x100c_42ad, -0xb2c);             /* call 0x100c42ad */
        l_0x100c_4dd9:
            ii(0x100c_4dd9, 2); jmpd(0x100c_4d6a, -0x71); goto l_0x100c_4d6a; /* jmp 0x100c4d6a */
        l_0x100c_4ddb:
            ii(0x100c_4ddb, 5); jmpd(0x100c_5091, 0x2b1); goto l_0x100c_5091; /* jmp 0x100c5091 */
        l_0x100c_4de0:
            ii(0x100c_4de0, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4de2, 5); mov(edx, 0x3a);                         /* mov edx, 0x3a */
            ii(0x100c_4de7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4dea, 5); calld(0x100c_42ad, -0xb42);             /* call 0x100c42ad */
            ii(0x100c_4def, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4df1, 5); mov(edx, 0x36);                         /* mov edx, 0x36 */
            ii(0x100c_4df6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4df9, 5); calld(0x100c_42ad, -0xb51);             /* call 0x100c42ad */
            ii(0x100c_4dfe, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4e00, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x100c_4e05, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4e08, 5); calld(0x100c_42ad, -0xb60);             /* call 0x100c42ad */
            ii(0x100c_4e0d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4e0f, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100c_4e14, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4e17, 5); calld(0x100c_42ad, -0xb6f);             /* call 0x100c42ad */
            ii(0x100c_4e1c, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_4e20, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100c_4e23, 2); if(jzd(0x100c_4e34, 0xf)) goto l_0x100c_4e34; /* jz 0x100c4e34 */
            ii(0x100c_4e25, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4e27, 5); mov(edx, 0x3d);                         /* mov edx, 0x3d */
            ii(0x100c_4e2c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4e2f, 5); calld(0x100c_42ad, -0xb87);             /* call 0x100c42ad */
        l_0x100c_4e34:
            ii(0x100c_4e34, 5); calld(0x100c_43a0, -0xa99);             /* call 0x100c43a0 */
            ii(0x100c_4e39, 1); cwde();                                 /* cwde */
            ii(0x100c_4e3a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_4e3c, 2); if(jled(0x100c_4e47, 0x9)) goto l_0x100c_4e47; /* jle 0x100c4e47 */
            ii(0x100c_4e3e, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_4e42, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100c_4e45, 2); if(jnzd(0x100c_4e49, 0x2)) goto l_0x100c_4e49; /* jnz 0x100c4e49 */
        l_0x100c_4e47:
            ii(0x100c_4e47, 2); jmpd(0x100c_4e58, 0xf); goto l_0x100c_4e58; /* jmp 0x100c4e58 */
        l_0x100c_4e49:
            ii(0x100c_4e49, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4e4b, 5); mov(edx, 0x31);                         /* mov edx, 0x31 */
            ii(0x100c_4e50, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4e53, 5); calld(0x100c_42ad, -0xbab);             /* call 0x100c42ad */
        l_0x100c_4e58:
            ii(0x100c_4e58, 5); calld(0x100c_43a0, -0xabd);             /* call 0x100c43a0 */
            ii(0x100c_4e5d, 1); cwde();                                 /* cwde */
            ii(0x100c_4e5e, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100c_4e61, 2); if(jled(0x100c_4e72, 0xf)) goto l_0x100c_4e72; /* jle 0x100c4e72 */
            ii(0x100c_4e63, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4e65, 5); mov(edx, 0x39);                         /* mov edx, 0x39 */
            ii(0x100c_4e6a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4e6d, 5); calld(0x100c_42ad, -0xbc5);             /* call 0x100c42ad */
        l_0x100c_4e72:
            ii(0x100c_4e72, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4e74, 5); mov(edx, 0x36);                         /* mov edx, 0x36 */
            ii(0x100c_4e79, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4e7c, 5); calld(0x100c_42ad, -0xbd4);             /* call 0x100c42ad */
            ii(0x100c_4e81, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4e83, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x100c_4e88, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4e8b, 5); calld(0x100c_42ad, -0xbe3);             /* call 0x100c42ad */
            ii(0x100c_4e90, 5); calld(/* sys */ 0x1016_5e9b, 0xa_1006); /* call 0x10165e9b */
            ii(0x100c_4e95, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x100c_4e98, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100c_4e9b, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x100c_4e9e, 3); mov(edx, memd_a32[ds, edx + 0xe]);      /* mov edx, [edx+0xe] */
            ii(0x100c_4ea1, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_4ea4, 3); add(eax, 0x3);                          /* add eax, 0x3 */
            ii(0x100c_4ea7, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100c_4eaa, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100c_4eac, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100c_4eaf, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x100c_4eb2, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x100c_4eb4, 3); sar(eax, 0x4);                          /* sar eax, 0x4 */
            ii(0x100c_4eb7, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100c_4eba, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4ebd, 5); calld(0x100c_7824, 0x2962);             /* call 0x100c7824 */
        l_0x100c_4ec2:
            ii(0x100c_4ec2, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4ec4, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100c_4ec9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4ecc, 5); calld(0x100c_42ad, -0xc24);             /* call 0x100c42ad */
            ii(0x100c_4ed1, 2); test(al, al);                           /* test al, al */
            ii(0x100c_4ed3, 2); if(jzd(0x100c_4f24, 0x4f)) goto l_0x100c_4f24; /* jz 0x100c4f24 */
            ii(0x100c_4ed5, 5); calld(0x100c_43a0, -0xb3a);             /* call 0x100c43a0 */
            ii(0x100c_4eda, 1); cwde();                                 /* cwde */
            ii(0x100c_4edb, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100c_4ede, 2); if(jled(0x100c_4f04, 0x24)) goto l_0x100c_4f04; /* jle 0x100c4f04 */
            ii(0x100c_4ee0, 5); mov(ebx, 0x14);                         /* mov ebx, 0x14 */
            ii(0x100c_4ee5, 5); mov(edx, 0x31);                         /* mov edx, 0x31 */
            ii(0x100c_4eea, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4eed, 5); calld(0x100c_42ad, -0xc45);             /* call 0x100c42ad */
            ii(0x100c_4ef2, 5); mov(ebx, 0x8);                          /* mov ebx, 0x8 */
            ii(0x100c_4ef7, 5); mov(edx, 0x3d);                         /* mov edx, 0x3d */
            ii(0x100c_4efc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4eff, 5); calld(0x100c_42ad, -0xc57);             /* call 0x100c42ad */
        l_0x100c_4f04:
            ii(0x100c_4f04, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4f06, 5); mov(edx, 0x36);                         /* mov edx, 0x36 */
            ii(0x100c_4f0b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4f0e, 5); calld(0x100c_42ad, -0xc66);             /* call 0x100c42ad */
            ii(0x100c_4f13, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4f15, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x100c_4f1a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4f1d, 5); calld(0x100c_42ad, -0xc75);             /* call 0x100c42ad */
            ii(0x100c_4f22, 2); jmpd(0x100c_4ec2, -0x62); goto l_0x100c_4ec2; /* jmp 0x100c4ec2 */
        l_0x100c_4f24:
            ii(0x100c_4f24, 5); jmpd(0x100c_5091, 0x168); goto l_0x100c_5091; /* jmp 0x100c5091 */
        l_0x100c_4f29:
            ii(0x100c_4f29, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_4f2d, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100c_4f30, 2); if(jzd(0x100c_4f41, 0xf)) goto l_0x100c_4f41; /* jz 0x100c4f41 */
            ii(0x100c_4f32, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4f34, 5); mov(edx, 0x3d);                         /* mov edx, 0x3d */
            ii(0x100c_4f39, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4f3c, 5); calld(0x100c_42ad, -0xc94);             /* call 0x100c42ad */
        l_0x100c_4f41:
            ii(0x100c_4f41, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4f43, 5); mov(edx, 0x3a);                         /* mov edx, 0x3a */
            ii(0x100c_4f48, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4f4b, 5); calld(0x100c_42ad, -0xca3);             /* call 0x100c42ad */
            ii(0x100c_4f50, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4f52, 5); mov(edx, 0x36);                         /* mov edx, 0x36 */
            ii(0x100c_4f57, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4f5a, 5); calld(0x100c_42ad, -0xcb2);             /* call 0x100c42ad */
            ii(0x100c_4f5f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4f61, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100c_4f66, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4f69, 5); calld(0x100c_42ad, -0xcc1);             /* call 0x100c42ad */
            ii(0x100c_4f6e, 5); calld(0x100c_43a0, -0xbd3);             /* call 0x100c43a0 */
            ii(0x100c_4f73, 1); cwde();                                 /* cwde */
            ii(0x100c_4f74, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_4f76, 2); if(jled(0x100c_4f81, 0x9)) goto l_0x100c_4f81; /* jle 0x100c4f81 */
            ii(0x100c_4f78, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_4f7c, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100c_4f7f, 2); if(jnzd(0x100c_4f83, 0x2)) goto l_0x100c_4f83; /* jnz 0x100c4f83 */
        l_0x100c_4f81:
            ii(0x100c_4f81, 2); jmpd(0x100c_4f92, 0xf); goto l_0x100c_4f92; /* jmp 0x100c4f92 */
        l_0x100c_4f83:
            ii(0x100c_4f83, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4f85, 5); mov(edx, 0x31);                         /* mov edx, 0x31 */
            ii(0x100c_4f8a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4f8d, 5); calld(0x100c_42ad, -0xce5);             /* call 0x100c42ad */
        l_0x100c_4f92:
            ii(0x100c_4f92, 5); calld(/* sys */ 0x1016_5e9b, 0xa_0f04); /* call 0x10165e9b */
            ii(0x100c_4f97, 3); imul(eax, eax, 0xb);                    /* imul eax, eax, 0xb */
            ii(0x100c_4f9a, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100c_4f9d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_4f9f, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100c_4fa2, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x100c_4fa5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_4fa8, 3); add(edx, 0x2);                          /* add edx, 0x2 */
            ii(0x100c_4fab, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100c_4fae, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100c_4fb0, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100c_4fb3, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x100c_4fb6, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x100c_4fb8, 3); sar(eax, 0x4);                          /* sar eax, 0x4 */
            ii(0x100c_4fbb, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100c_4fbe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4fc1, 5); calld(0x100c_7824, 0x285e);             /* call 0x100c7824 */
            ii(0x100c_4fc6, 5); calld(0x100c_43a0, -0xc2b);             /* call 0x100c43a0 */
            ii(0x100c_4fcb, 1); cwde();                                 /* cwde */
            ii(0x100c_4fcc, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_4fce, 2); if(jled(0x100c_4fd9, 0x9)) goto l_0x100c_4fd9; /* jle 0x100c4fd9 */
            ii(0x100c_4fd0, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_4fd4, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100c_4fd7, 2); if(jnzd(0x100c_4fdb, 0x2)) goto l_0x100c_4fdb; /* jnz 0x100c4fdb */
        l_0x100c_4fd9:
            ii(0x100c_4fd9, 2); jmpd(0x100c_4fea, 0xf); goto l_0x100c_4fea; /* jmp 0x100c4fea */
        l_0x100c_4fdb:
            ii(0x100c_4fdb, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4fdd, 5); mov(edx, 0x3d);                         /* mov edx, 0x3d */
            ii(0x100c_4fe2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4fe5, 5); calld(0x100c_42ad, -0xd3d);             /* call 0x100c42ad */
        l_0x100c_4fea:
            ii(0x100c_4fea, 5); calld(0x100c_43a0, -0xc4f);             /* call 0x100c43a0 */
            ii(0x100c_4fef, 1); cwde();                                 /* cwde */
            ii(0x100c_4ff0, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100c_4ff3, 2); if(jled(0x100c_5004, 0xf)) goto l_0x100c_5004; /* jle 0x100c5004 */
            ii(0x100c_4ff5, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_4ff7, 5); mov(edx, 0x39);                         /* mov edx, 0x39 */
            ii(0x100c_4ffc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4fff, 5); calld(0x100c_42ad, -0xd57);             /* call 0x100c42ad */
        l_0x100c_5004:
            ii(0x100c_5004, 5); calld(0x100c_43a0, -0xc69);             /* call 0x100c43a0 */
            ii(0x100c_5009, 1); cwde();                                 /* cwde */
            ii(0x100c_500a, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100c_500d, 2); if(jled(0x100c_5027, 0x18)) goto l_0x100c_5027; /* jle 0x100c5027 */
        l_0x100c_500f:
            ii(0x100c_500f, 5); mov(ebx, 0x14);                         /* mov ebx, 0x14 */
            ii(0x100c_5014, 5); mov(edx, 0x31);                         /* mov edx, 0x31 */
            ii(0x100c_5019, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_501c, 5); calld(0x100c_42ad, -0xd74);             /* call 0x100c42ad */
            ii(0x100c_5021, 2); test(al, al);                           /* test al, al */
            ii(0x100c_5023, 2); if(jnzd(0x100c_500f, -0x16)) goto l_0x100c_500f; /* jnz 0x100c500f */
            ii(0x100c_5025, 2); jmpd(0x100c_504b, 0x24); goto l_0x100c_504b; /* jmp 0x100c504b */
        l_0x100c_5027:
            ii(0x100c_5027, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_5029, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x100c_502e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_5031, 5); calld(0x100c_42ad, -0xd89);             /* call 0x100c42ad */
            ii(0x100c_5036, 2); test(al, al);                           /* test al, al */
            ii(0x100c_5038, 2); if(jzd(0x100c_504b, 0x11)) goto l_0x100c_504b; /* jz 0x100c504b */
            ii(0x100c_503a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_503c, 5); mov(edx, 0x36);                         /* mov edx, 0x36 */
            ii(0x100c_5041, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_5044, 5); calld(0x100c_42ad, -0xd9c);             /* call 0x100c42ad */
            ii(0x100c_5049, 2); jmpd(0x100c_5027, -0x24); goto l_0x100c_5027; /* jmp 0x100c5027 */
        l_0x100c_504b:
            ii(0x100c_504b, 2); jmpd(0x100c_5091, 0x44); goto l_0x100c_5091; /* jmp 0x100c5091 */
        l_0x100c_504d:
            ii(0x100c_504d, 2); jmpd(0x100c_5091, 0x42); goto l_0x100c_5091; /* jmp 0x100c5091 */
        //  ii(0x100c_504f, 1); nop();                                  /* nop */
        //  ii(0x100c_5050, 36); /* Служебная область с абсолютными адресами переходов. (0x100c_4554, 0x100c_46f1, 0x100c_4842, 0x100c_499e, 0x100c_4b29, 0x100c_4b8b, 0x100c_4c83, 0x100c_4de0, 0x100c_4f29). */
        l_0x100c_5074:
            ii(0x100c_5074, 3); mov(al, memb_a32[ss, ebp - 0x30]);      /* mov al, [ebp-0x30] */
            ii(0x100c_5077, 2); dec(al);                                /* dec al */
            ii(0x100c_5079, 3); mov(memb_a32[ss, ebp - 0x34], al);      /* mov [ebp-0x34], al */
            ii(0x100c_507c, 4); cmp(memb_a32[ss, ebp - 0x34], 0x8);     /* cmp byte [ebp-0x34], 0x8 */
            ii(0x100c_5080, 2); if(jad(0x100c_504d, -0x35)) goto l_0x100c_504d; /* ja 0x100c504d */
            ii(0x100c_5082, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_5084, 3); mov(al, memb_a32[ss, ebp - 0x34]);      /* mov al, [ebp-0x34] */
            ii(0x100c_5087, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_508a, 7); 
            switch (jmpd_abs_switch(memd_a32[cs, eax + 0x100c_5050]))
            {
                case 0x100c_4554:
                    goto l_0x100c_4554;
                case 0x100c_46f1:
                    goto l_0x100c_46f1;
                case 0x100c_4842:
                    goto l_0x100c_4842;
                case 0x100c_499e:
                    goto l_0x100c_499e;
                case 0x100c_4b29:
                    goto l_0x100c_4b29;
                case 0x100c_4b8b:
                    goto l_0x100c_4b8b;
                case 0x100c_4c83:
                    goto l_0x100c_4c83;
                case 0x100c_4de0:
                    goto l_0x100c_4de0;
                case 0x100c_4f29:
                    goto l_0x100c_4f29;
                default:
                    throw new NotImplementedException();
            } /* jmp dword [cs:eax+0x100c5050] */
        l_0x100c_5091:
            ii(0x100c_5091, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100c_5094, 3); mov(edx, memd_a32[ds, eax + 0xe]);      /* mov edx, [eax+0xe] */
            ii(0x100c_5097, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_509a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_509d, 5); calld(0x100c_7824, 0x2782);             /* call 0x100c7824 */
            ii(0x100c_50a2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_50a4, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_50a5, 1); popd(edi);                              /* pop edi */
            ii(0x100c_50a6, 1); popd(esi);                              /* pop esi */
            ii(0x100c_50a7, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_50a8, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_50a9, 1); retd(); return;                         /* ret */
        }
    }
}
