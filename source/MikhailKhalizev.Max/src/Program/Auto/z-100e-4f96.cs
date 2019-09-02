using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_4f96-49c06e03")]
        public void Method_100e_4f96()
        {
            ii(0x100e_4f96, 5); push(0x54);                             /* push 0x54 */
            ii(0x100e_4f9b, 5); call(Definitions.sys_check_available_stack_size, 0x8_0db2); /* call 0x10165d52 */
            ii(0x100e_4fa0, 1); push(ebx);                              /* push ebx */
            ii(0x100e_4fa1, 1); push(ecx);                              /* push ecx */
            ii(0x100e_4fa2, 1); push(edx);                              /* push edx */
            ii(0x100e_4fa3, 1); push(esi);                              /* push esi */
            ii(0x100e_4fa4, 1); push(edi);                              /* push edi */
            ii(0x100e_4fa5, 1); push(ebp);                              /* push ebp */
            ii(0x100e_4fa6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_4fa8, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x100e_4fae, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_4fb1, 3); lea(edi, memd[ss, ebp - 0x20]);         /* lea edi, [ebp-0x20] */
            ii(0x100e_4fb4, 3); mov(esi, memd[ss, ebp - 4]);            /* mov esi, [ebp-0x4] */
            ii(0x100e_4fb7, 1); movsd();                                /* movsd */
            ii(0x100e_4fb8, 1); movsd();                                /* movsd */
            ii(0x100e_4fb9, 1); movsd();                                /* movsd */
            ii(0x100e_4fba, 1); movsd();                                /* movsd */
            ii(0x100e_4fbb, 7); cmp(memd[ds, 0x101c_38c4], 0);          /* cmp dword [0x101c38c4], 0x0 */
            ii(0x100e_4fc2, 6); if(jz(0x100e_535c, 0x394)) goto l_0x100e_535c; /* jz 0x100e535c */
            ii(0x100e_4fc8, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100e_4fcb, 6); cmp(eax, memd[ds, 0x101c_38ec]);        /* cmp eax, [0x101c38ec] */
            ii(0x100e_4fd1, 2); if(jge(0x100e_4fdb, 8)) goto l_0x100e_4fdb; /* jge 0x100e4fdb */
            ii(0x100e_4fd3, 5); mov(eax, memd[ds, 0x101c_38ec]);        /* mov eax, [0x101c38ec] */
            ii(0x100e_4fd8, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
        l_0x100e_4fdb:
            ii(0x100e_4fdb, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_4fde, 6); cmp(eax, memd[ds, 0x101c_38f0]);        /* cmp eax, [0x101c38f0] */
            ii(0x100e_4fe4, 2); if(jge(0x100e_4fee, 8)) goto l_0x100e_4fee; /* jge 0x100e4fee */
            ii(0x100e_4fe6, 5); mov(eax, memd[ds, 0x101c_38f0]);        /* mov eax, [0x101c38f0] */
            ii(0x100e_4feb, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
        l_0x100e_4fee:
            ii(0x100e_4fee, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100e_4ff1, 6); cmp(eax, memd[ds, 0x101c_38f4]);        /* cmp eax, [0x101c38f4] */
            ii(0x100e_4ff7, 2); if(jle(0x100e_5002, 9)) goto l_0x100e_5002; /* jle 0x100e5002 */
            ii(0x100e_4ff9, 5); mov(eax, memd[ds, 0x101c_38f4]);        /* mov eax, [0x101c38f4] */
            ii(0x100e_4ffe, 1); inc(eax);                               /* inc eax */
            ii(0x100e_4fff, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
        l_0x100e_5002:
            ii(0x100e_5002, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100e_5005, 6); cmp(eax, memd[ds, 0x101c_38f8]);        /* cmp eax, [0x101c38f8] */
            ii(0x100e_500b, 2); if(jle(0x100e_5016, 9)) goto l_0x100e_5016; /* jle 0x100e5016 */
            ii(0x100e_500d, 5); mov(eax, memd[ds, 0x101c_38f8]);        /* mov eax, [0x101c38f8] */
            ii(0x100e_5012, 1); inc(eax);                               /* inc eax */
            ii(0x100e_5013, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
        l_0x100e_5016:
            ii(0x100e_5016, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100e_5019, 3); cmp(eax, memd[ss, ebp - 0x20]);         /* cmp eax, [ebp-0x20] */
            ii(0x100e_501c, 2); if(jle(0x100e_5026, 8)) goto l_0x100e_5026; /* jle 0x100e5026 */
            ii(0x100e_501e, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100e_5021, 3); cmp(eax, memd[ss, ebp - 0x1c]);         /* cmp eax, [ebp-0x1c] */
            ii(0x100e_5024, 2); if(jg(0x100e_502b, 5)) goto l_0x100e_502b; /* jg 0x100e502b */
        l_0x100e_5026:
            ii(0x100e_5026, 5); jmp(0x100e_535c, 0x331); goto l_0x100e_535c; /* jmp 0x100e535c */
        l_0x100e_502b:
            ii(0x100e_502b, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_5030, 5); call(Definitions.my_3_get_count, -0x5_9bb5); /* call 0x1008b480 */
            ii(0x100e_5035, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x100e_5038:
            ii(0x100e_5038, 3); dec(memd[ss, ebp - 0x10]);              /* dec dword [ebp-0x10] */
            ii(0x100e_503b, 5); cmp(memw[ss, ebp - 0x10], -1 /* 0xff */); /* cmp word [ebp-0x10], 0xffff */
            ii(0x100e_5040, 6); if(jz(0x100e_5212, 0x1cc)) goto l_0x100e_5212; /* jz 0x100e5212 */
            ii(0x100e_5046, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100e_504a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_504c, 2); if(jl(0x100e_505e, 0x10)) goto l_0x100e_505e; /* jl 0x100e505e */
            ii(0x100e_504e, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_5053, 5); call(Definitions.my_3_get_count, -0x5_9bd8); /* call 0x1008b480 */
            ii(0x100e_5058, 4); cmp(ax, memw[ss, ebp - 0x10]);          /* cmp ax, [ebp-0x10] */
            ii(0x100e_505c, 2); if(jg(0x100e_5060, 2)) goto l_0x100e_5060; /* jg 0x100e5060 */
        l_0x100e_505e:
            ii(0x100e_505e, 2); jmp(0x100e_5069, 9); goto l_0x100e_5069; /* jmp 0x100e5069 */
        l_0x100e_5060:
            ii(0x100e_5060, 7); mov(memd[ss, ebp - 0x24], 0);           /* mov dword [ebp-0x24], 0x0 */
            ii(0x100e_5067, 2); jmp(0x100e_5082, 0x19); goto l_0x100e_5082; /* jmp 0x100e5082 */
        l_0x100e_5069:
            ii(0x100e_5069, 5); mov(ecx, 0x98);                         /* mov ecx, 0x98 */
            ii(0x100e_506e, 5); mov(ebx, StringDefinitions.DrawmapCpp7); /* mov ebx, 0x101a1db8 */
            ii(0x100e_5073, 5); mov(edx, StringDefinitions.IGreaterOrEqual0ILessDirtyRectanglesGetcount2); /* mov edx, 0x101a1dc4 */
            ii(0x100e_5078, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_507a, 5); call(Definitions.sys_assert, 0x8_0d13); /* call 0x10165d92 */
            ii(0x100e_507f, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
        l_0x100e_5082:
            ii(0x100e_5082, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100e_5086, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_508b, 5); call(0x100e_84b8, 0x3428);              /* call 0x100e84b8 */
            ii(0x100e_5090, 3); lea(edi, memd[ss, ebp - 0x34]);         /* lea edi, [ebp-0x34] */
            ii(0x100e_5093, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x100e_5095, 1); movsd();                                /* movsd */
            ii(0x100e_5096, 1); movsd();                                /* movsd */
            ii(0x100e_5097, 1); movsd();                                /* movsd */
            ii(0x100e_5098, 1); movsd();                                /* movsd */
            ii(0x100e_5099, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100e_509c, 3); cmp(eax, memd[ss, ebp - 0x34]);         /* cmp eax, [ebp-0x34] */
            ii(0x100e_509f, 2); if(jle(0x100e_50a9, 8)) goto l_0x100e_50a9; /* jle 0x100e50a9 */
            ii(0x100e_50a1, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100e_50a4, 3); cmp(eax, memd[ss, ebp - 0x2c]);         /* cmp eax, [ebp-0x2c] */
            ii(0x100e_50a7, 2); if(jl(0x100e_50ab, 2)) goto l_0x100e_50ab; /* jl 0x100e50ab */
        l_0x100e_50a9:
            ii(0x100e_50a9, 2); jmp(0x100e_50b3, 8); goto l_0x100e_50b3; /* jmp 0x100e50b3 */
        l_0x100e_50ab:
            ii(0x100e_50ab, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100e_50ae, 3); cmp(eax, memd[ss, ebp - 0x30]);         /* cmp eax, [ebp-0x30] */
            ii(0x100e_50b1, 2); if(jg(0x100e_50b5, 2)) goto l_0x100e_50b5; /* jg 0x100e50b5 */
        l_0x100e_50b3:
            ii(0x100e_50b3, 2); jmp(0x100e_50bd, 8); goto l_0x100e_50bd; /* jmp 0x100e50bd */
        l_0x100e_50b5:
            ii(0x100e_50b5, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_50b8, 3); cmp(eax, memd[ss, ebp - 0x28]);         /* cmp eax, [ebp-0x28] */
            ii(0x100e_50bb, 2); if(jl(0x100e_50c2, 5)) goto l_0x100e_50c2; /* jl 0x100e50c2 */
        l_0x100e_50bd:
            ii(0x100e_50bd, 5); jmp(0x100e_520d, 0x14b); goto l_0x100e_520d; /* jmp 0x100e520d */
        l_0x100e_50c2:
            ii(0x100e_50c2, 4); movsx(ecx, memw[ss, ebp - 0x2c]);       /* movsx ecx, word [ebp-0x2c] */
            ii(0x100e_50c6, 4); movsx(ebx, memw[ss, ebp - 0x34]);       /* movsx ebx, word [ebp-0x34] */
            ii(0x100e_50ca, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x100e_50ce, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x100e_50d2, 5); call(0x100e_4cfc, -0x3db);              /* call 0x100e4cfc */
            ii(0x100e_50d7, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100e_50da, 4); movsx(ecx, memw[ss, ebp - 0x28]);       /* movsx ecx, word [ebp-0x28] */
            ii(0x100e_50de, 4); movsx(ebx, memw[ss, ebp - 0x30]);       /* movsx ebx, word [ebp-0x30] */
            ii(0x100e_50e2, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x100e_50e6, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100e_50ea, 5); call(0x100e_4cfc, -0x3f3);              /* call 0x100e4cfc */
            ii(0x100e_50ef, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_50f2, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100e_50f6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_50f8, 2); if(jnz(0x100e_5102, 8)) goto l_0x100e_5102; /* jnz 0x100e5102 */
            ii(0x100e_50fa, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100e_50fe, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_5100, 2); if(jz(0x100e_5104, 2)) goto l_0x100e_5104; /* jz 0x100e5104 */
        l_0x100e_5102:
            ii(0x100e_5102, 2); jmp(0x100e_5109, 5); goto l_0x100e_5109; /* jmp 0x100e5109 */
        l_0x100e_5104:
            ii(0x100e_5104, 5); jmp(0x100e_535c, 0x253); goto l_0x100e_535c; /* jmp 0x100e535c */
        l_0x100e_5109:
            ii(0x100e_5109, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100e_510d, 3); cmp(eax, 3);                            /* cmp eax, 0x3 */
            ii(0x100e_5110, 2); if(jnz(0x100e_511b, 9)) goto l_0x100e_511b; /* jnz 0x100e511b */
            ii(0x100e_5112, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100e_5116, 3); cmp(eax, 3);                            /* cmp eax, 0x3 */
            ii(0x100e_5119, 2); if(jz(0x100e_511d, 2)) goto l_0x100e_511d; /* jz 0x100e511d */
        l_0x100e_511b:
            ii(0x100e_511b, 2); jmp(0x100e_5130, 0x13); goto l_0x100e_5130; /* jmp 0x100e5130 */
        l_0x100e_511d:
            ii(0x100e_511d, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100e_5121, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_5126, 5); call(0x100c_db14, -0x1_7617);           /* call 0x100cdb14 */
            ii(0x100e_512b, 5); jmp(0x100e_51f0, 0xc0); goto l_0x100e_51f0; /* jmp 0x100e51f0 */
        l_0x100e_5130:
            ii(0x100e_5130, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100e_5134, 3); cmp(eax, 3);                            /* cmp eax, 0x3 */
            ii(0x100e_5137, 2); if(jz(0x100e_5156, 0x1d)) goto l_0x100e_5156; /* jz 0x100e5156 */
            ii(0x100e_5139, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100e_513d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_513f, 2); if(jz(0x100e_5149, 8)) goto l_0x100e_5149; /* jz 0x100e5149 */
            ii(0x100e_5141, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100e_5145, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_5147, 2); if(jnz(0x100e_514b, 2)) goto l_0x100e_514b; /* jnz 0x100e514b */
        l_0x100e_5149:
            ii(0x100e_5149, 2); jmp(0x100e_5154, 9); goto l_0x100e_5154; /* jmp 0x100e5154 */
        l_0x100e_514b:
            ii(0x100e_514b, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100e_514f, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x100e_5152, 2); if(jnz(0x100e_5156, 2)) goto l_0x100e_5156; /* jnz 0x100e5156 */
        l_0x100e_5154:
            ii(0x100e_5154, 2); jmp(0x100e_51bb, 0x65); goto l_0x100e_51bb; /* jmp 0x100e51bb */
        l_0x100e_5156:
            ii(0x100e_5156, 5); mov(eax, 3);                            /* mov eax, 0x3 */
            ii(0x100e_515b, 3); sub(eax, memd[ss, ebp - 8]);            /* sub eax, [ebp-0x8] */
            ii(0x100e_515e, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100e_5161, 5); mov(eax, 3);                            /* mov eax, 0x3 */
            ii(0x100e_5166, 3); sub(eax, memd[ss, ebp - 0xc]);          /* sub eax, [ebp-0xc] */
            ii(0x100e_5169, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100e_516c, 3); lea(esi, memd[ss, ebp - 0x20]);         /* lea esi, [ebp-0x20] */
            ii(0x100e_516f, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100e_5173, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_5178, 5); call(0x100e_84b8, 0x333b);              /* call 0x100e84b8 */
            ii(0x100e_517d, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x100e_517f, 5); call(0x100e_4d79, -0x40b);              /* call 0x100e4d79 */
            ii(0x100e_5184, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100e_5188, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_518d, 5); call(0x100e_84b8, 0x3326);              /* call 0x100e84b8 */
            ii(0x100e_5192, 3); lea(edi, memd[ss, ebp - 0x34]);         /* lea edi, [ebp-0x34] */
            ii(0x100e_5195, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x100e_5197, 1); movsd();                                /* movsd */
            ii(0x100e_5198, 1); movsd();                                /* movsd */
            ii(0x100e_5199, 1); movsd();                                /* movsd */
            ii(0x100e_519a, 1); movsd();                                /* movsd */
            ii(0x100e_519b, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x100e_519e, 3); cmp(eax, memd[ss, ebp - 0x34]);         /* cmp eax, [ebp-0x34] */
            ii(0x100e_51a1, 2); if(jle(0x100e_51ab, 8)) goto l_0x100e_51ab; /* jle 0x100e51ab */
            ii(0x100e_51a3, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x100e_51a6, 3); cmp(eax, memd[ss, ebp - 0x30]);         /* cmp eax, [ebp-0x30] */
            ii(0x100e_51a9, 2); if(jg(0x100e_51b9, 0xe)) goto l_0x100e_51b9; /* jg 0x100e51b9 */
        l_0x100e_51ab:
            ii(0x100e_51ab, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100e_51af, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_51b4, 5); call(0x100c_db14, -0x1_76a5);           /* call 0x100cdb14 */
        l_0x100e_51b9:
            ii(0x100e_51b9, 2); jmp(0x100e_51f0, 0x35); goto l_0x100e_51f0; /* jmp 0x100e51f0 */
        l_0x100e_51bb:
            ii(0x100e_51bb, 4); movsx(ecx, memw[ss, ebp - 8]);          /* movsx ecx, word [ebp-0x8] */
            ii(0x100e_51bf, 4); movsx(ebx, memw[ss, ebp - 0xc]);        /* movsx ebx, word [ebp-0xc] */
            ii(0x100e_51c3, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100e_51c7, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_51cc, 5); call(0x100e_84b8, 0x32e7);              /* call 0x100e84b8 */
            ii(0x100e_51d1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_51d3, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100e_51d6, 5); call(0x100e_4d79, -0x462);              /* call 0x100e4d79 */
            ii(0x100e_51db, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100e_51de, 3); cmp(eax, memd[ss, ebp - 0x20]);         /* cmp eax, [ebp-0x20] */
            ii(0x100e_51e1, 2); if(jle(0x100e_51eb, 8)) goto l_0x100e_51eb; /* jle 0x100e51eb */
            ii(0x100e_51e3, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100e_51e6, 3); cmp(eax, memd[ss, ebp - 0x1c]);         /* cmp eax, [ebp-0x1c] */
            ii(0x100e_51e9, 2); if(jg(0x100e_51f0, 5)) goto l_0x100e_51f0; /* jg 0x100e51f0 */
        l_0x100e_51eb:
            ii(0x100e_51eb, 5); jmp(0x100e_535c, 0x16c); goto l_0x100e_535c; /* jmp 0x100e535c */
        l_0x100e_51f0:
            ii(0x100e_51f0, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_51f5, 5); call(Definitions.my_3_get_count, -0x5_9d7a); /* call 0x1008b480 */
            ii(0x100e_51fa, 4); cmp(ax, memw[ss, ebp - 0x10]);          /* cmp ax, [ebp-0x10] */
            ii(0x100e_51fe, 2); if(jge(0x100e_520d, 0xd)) goto l_0x100e_520d; /* jge 0x100e520d */
            ii(0x100e_5200, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_5205, 5); call(Definitions.my_3_get_count, -0x5_9d8a); /* call 0x1008b480 */
            ii(0x100e_520a, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x100e_520d:
            ii(0x100e_520d, 5); jmp(0x100e_5038, -0x1da); goto l_0x100e_5038; /* jmp 0x100e5038 */
        l_0x100e_5212:
            ii(0x100e_5212, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_5217, 5); call(Definitions.my_3_get_count, -0x5_9d9c); /* call 0x1008b480 */
            ii(0x100e_521c, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x100e_521f:
            ii(0x100e_521f, 3); dec(memd[ss, ebp - 0x10]);              /* dec dword [ebp-0x10] */
            ii(0x100e_5222, 5); cmp(memw[ss, ebp - 0x10], -1 /* 0xff */); /* cmp word [ebp-0x10], 0xffff */
            ii(0x100e_5227, 6); if(jz(0x100e_534f, 0x122)) goto l_0x100e_534f; /* jz 0x100e534f */
            ii(0x100e_522d, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100e_5231, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_5233, 2); if(jl(0x100e_5245, 0x10)) goto l_0x100e_5245; /* jl 0x100e5245 */
            ii(0x100e_5235, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_523a, 5); call(Definitions.my_3_get_count, -0x5_9dbf); /* call 0x1008b480 */
            ii(0x100e_523f, 4); cmp(ax, memw[ss, ebp - 0x10]);          /* cmp ax, [ebp-0x10] */
            ii(0x100e_5243, 2); if(jg(0x100e_5247, 2)) goto l_0x100e_5247; /* jg 0x100e5247 */
        l_0x100e_5245:
            ii(0x100e_5245, 2); jmp(0x100e_5250, 9); goto l_0x100e_5250; /* jmp 0x100e5250 */
        l_0x100e_5247:
            ii(0x100e_5247, 7); mov(memd[ss, ebp - 0x38], 0);           /* mov dword [ebp-0x38], 0x0 */
            ii(0x100e_524e, 2); jmp(0x100e_5269, 0x19); goto l_0x100e_5269; /* jmp 0x100e5269 */
        l_0x100e_5250:
            ii(0x100e_5250, 5); mov(ecx, 0xd4);                         /* mov ecx, 0xd4 */
            ii(0x100e_5255, 5); mov(ebx, StringDefinitions.DrawmapCpp3); /* mov ebx, 0x101a1dee */
            ii(0x100e_525a, 5); mov(edx, StringDefinitions.IGreaterOrEqual0ILessDirtyRectanglesGetcount); /* mov edx, 0x101a1dfa */
            ii(0x100e_525f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_5261, 5); call(Definitions.sys_assert, 0x8_0b2c); /* call 0x10165d92 */
            ii(0x100e_5266, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
        l_0x100e_5269:
            ii(0x100e_5269, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100e_526d, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_5272, 5); call(0x100e_84b8, 0x3241);              /* call 0x100e84b8 */
            ii(0x100e_5277, 3); lea(edi, memd[ss, ebp - 0x34]);         /* lea edi, [ebp-0x34] */
            ii(0x100e_527a, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x100e_527c, 1); movsd();                                /* movsd */
            ii(0x100e_527d, 1); movsd();                                /* movsd */
            ii(0x100e_527e, 1); movsd();                                /* movsd */
            ii(0x100e_527f, 1); movsd();                                /* movsd */
            ii(0x100e_5280, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100e_5283, 3); cmp(eax, memd[ss, ebp - 0x34]);         /* cmp eax, [ebp-0x34] */
            ii(0x100e_5286, 2); if(jnz(0x100e_5290, 8)) goto l_0x100e_5290; /* jnz 0x100e5290 */
            ii(0x100e_5288, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100e_528b, 3); cmp(eax, memd[ss, ebp - 0x2c]);         /* cmp eax, [ebp-0x2c] */
            ii(0x100e_528e, 2); if(jz(0x100e_5292, 2)) goto l_0x100e_5292; /* jz 0x100e5292 */
        l_0x100e_5290:
            ii(0x100e_5290, 2); jmp(0x100e_52a4, 0x12); goto l_0x100e_52a4; /* jmp 0x100e52a4 */
        l_0x100e_5292:
            ii(0x100e_5292, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100e_5295, 3); cmp(eax, memd[ss, ebp - 0x14]);         /* cmp eax, [ebp-0x14] */
            ii(0x100e_5298, 2); if(jz(0x100e_52a2, 8)) goto l_0x100e_52a2; /* jz 0x100e52a2 */
            ii(0x100e_529a, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x100e_529d, 3); cmp(eax, memd[ss, ebp - 0x1c]);         /* cmp eax, [ebp-0x1c] */
            ii(0x100e_52a0, 2); if(jnz(0x100e_52a4, 2)) goto l_0x100e_52a4; /* jnz 0x100e52a4 */
        l_0x100e_52a2:
            ii(0x100e_52a2, 2); jmp(0x100e_52a6, 2); goto l_0x100e_52a6; /* jmp 0x100e52a6 */
        l_0x100e_52a4:
            ii(0x100e_52a4, 2); jmp(0x100e_52e7, 0x41); goto l_0x100e_52e7; /* jmp 0x100e52e7 */
        l_0x100e_52a6:
            ii(0x100e_52a6, 3); mov(edx, memd[ss, ebp - 0x1c]);         /* mov edx, [ebp-0x1c] */
            ii(0x100e_52a9, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100e_52ac, 5); call(Definitions.my_min, -0x5_bb2d);    /* call 0x10089784 */
            ii(0x100e_52b1, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100e_52b3, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100e_52b7, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_52bc, 5); call(0x100e_84b8, 0x31f7);              /* call 0x100e84b8 */
            ii(0x100e_52c1, 3); mov(memd[ds, eax + 4], ebx);            /* mov [eax+0x4], ebx */
            ii(0x100e_52c4, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x100e_52c7, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x100e_52ca, 5); call(0x1007_6e7c, -0x6_e453);           /* call 0x10076e7c */
            ii(0x100e_52cf, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100e_52d1, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100e_52d5, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_52da, 5); call(0x100e_84b8, 0x31d9);              /* call 0x100e84b8 */
            ii(0x100e_52df, 3); mov(memd[ds, eax + 0xc], ebx);          /* mov [eax+0xc], ebx */
            ii(0x100e_52e2, 5); jmp(0x100e_535c, 0x75); goto l_0x100e_535c; /* jmp 0x100e535c */
        l_0x100e_52e7:
            ii(0x100e_52e7, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_52ea, 3); cmp(eax, memd[ss, ebp - 0x30]);         /* cmp eax, [ebp-0x30] */
            ii(0x100e_52ed, 2); if(jnz(0x100e_52f7, 8)) goto l_0x100e_52f7; /* jnz 0x100e52f7 */
            ii(0x100e_52ef, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100e_52f2, 3); cmp(eax, memd[ss, ebp - 0x28]);         /* cmp eax, [ebp-0x28] */
            ii(0x100e_52f5, 2); if(jz(0x100e_52f9, 2)) goto l_0x100e_52f9; /* jz 0x100e52f9 */
        l_0x100e_52f7:
            ii(0x100e_52f7, 2); jmp(0x100e_530b, 0x12); goto l_0x100e_530b; /* jmp 0x100e530b */
        l_0x100e_52f9:
            ii(0x100e_52f9, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x100e_52fc, 3); cmp(eax, memd[ss, ebp - 0x18]);         /* cmp eax, [ebp-0x18] */
            ii(0x100e_52ff, 2); if(jz(0x100e_5309, 8)) goto l_0x100e_5309; /* jz 0x100e5309 */
            ii(0x100e_5301, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x100e_5304, 3); cmp(eax, memd[ss, ebp - 0x20]);         /* cmp eax, [ebp-0x20] */
            ii(0x100e_5307, 2); if(jnz(0x100e_530b, 2)) goto l_0x100e_530b; /* jnz 0x100e530b */
        l_0x100e_5309:
            ii(0x100e_5309, 2); jmp(0x100e_530d, 2); goto l_0x100e_530d; /* jmp 0x100e530d */
        l_0x100e_530b:
            ii(0x100e_530b, 2); jmp(0x100e_534a, 0x3d); goto l_0x100e_534a; /* jmp 0x100e534a */
        l_0x100e_530d:
            ii(0x100e_530d, 3); mov(edx, memd[ss, ebp - 0x20]);         /* mov edx, [ebp-0x20] */
            ii(0x100e_5310, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x100e_5313, 5); call(Definitions.my_min, -0x5_bb94);    /* call 0x10089784 */
            ii(0x100e_5318, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100e_531a, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100e_531e, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_5323, 5); call(0x100e_84b8, 0x3190);              /* call 0x100e84b8 */
            ii(0x100e_5328, 2); mov(memd[ds, eax], ebx);                /* mov [eax], ebx */
            ii(0x100e_532a, 3); mov(edx, memd[ss, ebp - 0x18]);         /* mov edx, [ebp-0x18] */
            ii(0x100e_532d, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x100e_5330, 5); call(0x1007_6e7c, -0x6_e4b9);           /* call 0x10076e7c */
            ii(0x100e_5335, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100e_5337, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100e_533b, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_5340, 5); call(0x100e_84b8, 0x3173);              /* call 0x100e84b8 */
            ii(0x100e_5345, 3); mov(memd[ds, eax + 8], ebx);            /* mov [eax+0x8], ebx */
            ii(0x100e_5348, 2); jmp(0x100e_535c, 0x12); goto l_0x100e_535c; /* jmp 0x100e535c */
        l_0x100e_534a:
            ii(0x100e_534a, 5); jmp(0x100e_521f, -0x130); goto l_0x100e_521f; /* jmp 0x100e521f */
        l_0x100e_534f:
            ii(0x100e_534f, 3); lea(edx, memd[ss, ebp - 0x20]);         /* lea edx, [ebp-0x20] */
            ii(0x100e_5352, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_5357, 5); call(0x100e_84f4, 0x3198);              /* call 0x100e84f4 */
        l_0x100e_535c:
            ii(0x100e_535c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_535e, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_535f, 1); pop(edi);                               /* pop edi */
            ii(0x100e_5360, 1); pop(esi);                               /* pop esi */
            ii(0x100e_5361, 1); pop(edx);                               /* pop edx */
            ii(0x100e_5362, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_5363, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_5364, 1); ret();                                  /* ret */
        }
    }
}
