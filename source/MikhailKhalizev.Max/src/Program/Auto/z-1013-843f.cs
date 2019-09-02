using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_843f-78f44b2b")]
        public void Method_1013_843f()
        {
            ii(0x1013_843f, 5); push(0x3e8);                            /* push 0x3e8 */
            ii(0x1013_8444, 5); call(Definitions.sys_check_available_stack_size, 0x2_d909); /* call 0x10165d52 */
            ii(0x1013_8449, 1); push(ebx);                              /* push ebx */
            ii(0x1013_844a, 1); push(ecx);                              /* push ecx */
            ii(0x1013_844b, 1); push(esi);                              /* push esi */
            ii(0x1013_844c, 1); push(edi);                              /* push edi */
            ii(0x1013_844d, 1); push(ebp);                              /* push ebp */
            ii(0x1013_844e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_8450, 6); sub(esp, 0x3bc);                        /* sub esp, 0x3bc */
            ii(0x1013_8456, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
            ii(0x1013_8459, 3); mov(memb[ss, ebp - 4], dl);             /* mov [ebp-0x4], dl */
            ii(0x1013_845c, 7); mov(memd[ss, ebp - 12], 0);             /* mov dword [ebp-0xc], 0x0 */
            ii(0x1013_8463, 7); mov(memd[ss, ebp - 16], 0);             /* mov dword [ebp-0x10], 0x0 */
            ii(0x1013_846a, 7); mov(memd[ss, ebp - 20], 0xffff_ffff);   /* mov dword [ebp-0x14], 0xffffffff */
            ii(0x1013_8471, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_8473, 5); mov(al, memb[ds, 0x101c_70f8]);         /* mov al, [0x101c70f8] */
            ii(0x1013_8478, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_847a, 2); if(jnz(0x1013_8483, 7)) goto l_0x1013_8483; /* jnz 0x10138483 */
            ii(0x1013_847c, 7); mov(memb[ds, 0x101c_70fc], 0);          /* mov byte [0x101c70fc], 0x0 */
        l_0x1013_8483:
            ii(0x1013_8483, 5); call(0x1013_9c10, 0x1788);              /* call 0x10139c10 */
            ii(0x1013_8488, 3); mov(memb[ss, ebp - 24], al);            /* mov [ebp-0x18], al */
            ii(0x1013_848b, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1013_8490, 1); push(eax);                              /* push eax */
            ii(0x1013_8491, 5); mov(eax, memd[ds, 0x101b_d366]);        /* mov eax, [0x101bd366] */
            ii(0x1013_8496, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_8499, 1); push(eax);                              /* push eax */
            ii(0x1013_849a, 4); movsx(eax, memb[ss, ebp - 24]);         /* movsx eax, byte [ebp-0x18] */
            ii(0x1013_849e, 1); push(eax);                              /* push eax */
            ii(0x1013_849f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_84a1, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x1013_84a4, 1); push(eax);                              /* push eax */
            ii(0x1013_84a5, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_84a7, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1013_84aa, 1); push(eax);                              /* push eax */
            ii(0x1013_84ab, 3); lea(ecx, memd[ss, ebp - 16]);           /* lea ecx, [ebp-0x10] */
            ii(0x1013_84ae, 3); lea(ebx, memd[ss, ebp - 52]);           /* lea ebx, [ebp-0x34] */
            ii(0x1013_84b1, 5); mov(edx, 0xa);                          /* mov edx, 0xa */
            ii(0x1013_84b6, 6); lea(eax, memd[ss, ebp - 884]);          /* lea eax, [ebp-0x374] */
            ii(0x1013_84bc, 5); call(0x1013_7a19, -0xaa8);              /* call 0x10137a19 */
            ii(0x1013_84c1, 5); call(0x1014_82f4, 0xfe2e);              /* call 0x101482f4 */
            ii(0x1013_84c6, 6); mov(memd[ss, ebp - 888], eax);          /* mov [ebp-0x378], eax */
            ii(0x1013_84cc, 10); mov(memd[ss, ebp - 892], 0);           /* mov dword [ebp-0x37c], 0x0 */
        l_0x1013_84d6:
            ii(0x1013_84d6, 7); cmp(memb[ds, 0x101c_5630], 1);          /* cmp byte [0x101c5630], 0x1 */
            ii(0x1013_84dd, 2); if(jnz(0x1013_84e4, 5)) goto l_0x1013_84e4; /* jnz 0x101384e4 */
            ii(0x1013_84df, 5); call(0x1012_ac94, -0xd850);             /* call 0x1012ac94 */
        l_0x1013_84e4:
            ii(0x1013_84e4, 5); call(/* sys */ 0x1016_b208, 0x3_2d1f);  /* call 0x1016b208 */
            ii(0x1013_84e9, 6); mov(memd[ss, ebp - 896], eax);          /* mov [ebp-0x380], eax */
            ii(0x1013_84ef, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1013_84f3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_84f5, 6); if(jl(0x1013_8571, 0x76)) goto l_0x1013_8571; /* jl 0x10138571 */
            ii(0x1013_84fb, 10); cmp(memd[ss, ebp - 896], 0x149);       /* cmp dword [ebp-0x380], 0x149 */
            ii(0x1013_8505, 2); if(jz(0x1013_8513, 0xc)) goto l_0x1013_8513; /* jz 0x10138513 */
            ii(0x1013_8507, 10); cmp(memd[ss, ebp - 896], 0x151);       /* cmp dword [ebp-0x380], 0x151 */
            ii(0x1013_8511, 2); if(jnz(0x1013_852d, 0x1a)) goto l_0x1013_852d; /* jnz 0x1013852d */
        l_0x1013_8513:
            ii(0x1013_8513, 5); mov(edx, 0x1b);                         /* mov edx, 0x1b */
            ii(0x1013_8518, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1013_851c, 3); imul(eax, eax, 0x53);                   /* imul eax, eax, 0x53 */
            ii(0x1013_851f, 7); mov(eax, memd[ds, eax + ebp - 805]);    /* mov eax, [eax+ebp-0x325] */
            ii(0x1013_8526, 5); call(0x100e_b283, -0x4_d2a8);           /* call 0x100eb283 */
            ii(0x1013_852b, 2); jmp(0x1013_8571, 0x44); goto l_0x1013_8571; /* jmp 0x10138571 */
        l_0x1013_852d:
            ii(0x1013_852d, 6); mov(edx, memd[ss, ebp - 896]);          /* mov edx, [ebp-0x380] */
            ii(0x1013_8533, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1013_8537, 3); imul(eax, eax, 0x53);                   /* imul eax, eax, 0x53 */
            ii(0x1013_853a, 7); mov(eax, memd[ds, eax + ebp - 805]);    /* mov eax, [eax+ebp-0x325] */
            ii(0x1013_8541, 5); call(0x100e_b283, -0x4_d2c3);           /* call 0x100eb283 */
            ii(0x1013_8546, 2); test(al, al);                           /* test al, al */
            ii(0x1013_8548, 2); if(jz(0x1013_8571, 0x27)) goto l_0x1013_8571; /* jz 0x10138571 */
            ii(0x1013_854a, 7); cmp(memd[ss, ebp - 896], 0xd);          /* cmp dword [ebp-0x380], 0xd */
            ii(0x1013_8551, 2); if(jnz(0x1013_8559, 6)) goto l_0x1013_8559; /* jnz 0x10138559 */
            ii(0x1013_8553, 4); cmp(memb[ss, ebp - 8], 0);              /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1013_8557, 2); if(jnz(0x1013_855b, 2)) goto l_0x1013_855b; /* jnz 0x1013855b */
        l_0x1013_8559:
            ii(0x1013_8559, 2); jmp(0x1013_8567, 0xc); goto l_0x1013_8567; /* jmp 0x10138567 */
        l_0x1013_855b:
            ii(0x1013_855b, 10); mov(memd[ss, ebp - 896], 0x3fe);       /* mov dword [ebp-0x380], 0x3fe */
            ii(0x1013_8565, 2); jmp(0x1013_8571, 0xa); goto l_0x1013_8571; /* jmp 0x10138571 */
        l_0x1013_8567:
            ii(0x1013_8567, 10); mov(memd[ss, ebp - 896], 0xffff_ffff); /* mov dword [ebp-0x380], 0xffffffff */
        l_0x1013_8571:
            ii(0x1013_8571, 7); cmp(memd[ss, ebp - 896], 0);            /* cmp dword [ebp-0x380], 0x0 */
            ii(0x1013_8578, 6); if(jl(0x1013_8bfe, 0x680)) goto l_0x1013_8bfe; /* jl 0x10138bfe */
            ii(0x1013_857e, 10); cmp(memd[ss, ebp - 896], 0x3e9);       /* cmp dword [ebp-0x380], 0x3e9 */
            ii(0x1013_8588, 2); if(jl(0x1013_8596, 0xc)) goto l_0x1013_8596; /* jl 0x10138596 */
            ii(0x1013_858a, 10); cmp(memd[ss, ebp - 896], 0x3f2);       /* cmp dword [ebp-0x380], 0x3f2 */
            ii(0x1013_8594, 2); if(jle(0x1013_8598, 2)) goto l_0x1013_8598; /* jle 0x10138598 */
        l_0x1013_8596:
            ii(0x1013_8596, 2); jmp(0x1013_85bc, 0x24); goto l_0x1013_85bc; /* jmp 0x101385bc */
        l_0x1013_8598:
            ii(0x1013_8598, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1013_859a, 3); mov(cl, memb[ss, ebp - 8]);             /* mov cl, [ebp-0x8] */
            ii(0x1013_859d, 6); mov(eax, memd[ss, ebp - 896]);          /* mov eax, [ebp-0x380] */
            ii(0x1013_85a3, 6); sub(eax, 0x3e9);                        /* sub eax, 0x3e9 */
            ii(0x1013_85a9, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1013_85ac, 3); lea(edx, memd[ss, ebp - 20]);           /* lea edx, [ebp-0x14] */
            ii(0x1013_85af, 6); lea(eax, memd[ss, ebp - 884]);          /* lea eax, [ebp-0x374] */
            ii(0x1013_85b5, 5); call(0x1013_830c, -0x2ae);              /* call 0x1013830c */
            ii(0x1013_85ba, 2); jmp(0x1013_85fc, 0x40); goto l_0x1013_85fc; /* jmp 0x101385fc */
        l_0x1013_85bc:
            ii(0x1013_85bc, 10); cmp(memd[ss, ebp - 896], 0x3f3);       /* cmp dword [ebp-0x380], 0x3f3 */
            ii(0x1013_85c6, 2); if(jl(0x1013_85d4, 0xc)) goto l_0x1013_85d4; /* jl 0x101385d4 */
            ii(0x1013_85c8, 10); cmp(memd[ss, ebp - 896], 0x3fc);       /* cmp dword [ebp-0x380], 0x3fc */
            ii(0x1013_85d2, 2); if(jle(0x1013_85d6, 2)) goto l_0x1013_85d6; /* jle 0x101385d6 */
        l_0x1013_85d4:
            ii(0x1013_85d4, 2); jmp(0x1013_85fc, 0x26); goto l_0x1013_85fc; /* jmp 0x101385fc */
        l_0x1013_85d6:
            ii(0x1013_85d6, 4); cmp(memb[ss, ebp - 8], 0);              /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1013_85da, 2); if(jz(0x1013_85f2, 0x16)) goto l_0x1013_85f2; /* jz 0x101385f2 */
            ii(0x1013_85dc, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_85de, 3); mov(bl, memb[ss, ebp - 8]);             /* mov bl, [ebp-0x8] */
            ii(0x1013_85e1, 4); movsx(edx, memw[ss, ebp - 20]);         /* movsx edx, word [ebp-0x14] */
            ii(0x1013_85e5, 6); lea(eax, memd[ss, ebp - 884]);          /* lea eax, [ebp-0x374] */
            ii(0x1013_85eb, 5); call(0x1013_83d6, -0x21a);              /* call 0x101383d6 */
            ii(0x1013_85f0, 2); jmp(0x1013_85fc, 0xa); goto l_0x1013_85fc; /* jmp 0x101385fc */
        l_0x1013_85f2:
            ii(0x1013_85f2, 10); mov(memd[ss, ebp - 896], 0x3ff);       /* mov dword [ebp-0x380], 0x3ff */
        l_0x1013_85fc:
            ii(0x1013_85fc, 6); mov(eax, memd[ss, ebp - 896]);          /* mov eax, [ebp-0x380] */
            ii(0x1013_8602, 6); mov(memd[ss, ebp - 900], eax);          /* mov [ebp-0x384], eax */
            ii(0x1013_8608, 5); jmp(0x1013_8b0a, 0x4fd); goto l_0x1013_8b0a; /* jmp 0x10138b0a */
        l_0x1013_860d:
            ii(0x1013_860d, 5); mov(eax, 0x51b);                        /* mov eax, 0x51b */
            ii(0x1013_8612, 5); call(0x1013_82da, -0x33d);              /* call 0x101382da */
            ii(0x1013_8617, 4); cmp(memb[ss, ebp - 8], 0);              /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1013_861b, 2); if(jz(0x1013_8626, 9)) goto l_0x1013_8626; /* jz 0x10138626 */
            ii(0x1013_861d, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x1013_8624, 2); if(jnz(0x1013_8628, 2)) goto l_0x1013_8628; /* jnz 0x10138628 */
        l_0x1013_8626:
            ii(0x1013_8626, 2); jmp(0x1013_866b, 0x43); goto l_0x1013_866b; /* jmp 0x1013866b */
        l_0x1013_8628:
            ii(0x1013_8628, 5); mov(al, memb[ds, 0x101c_391e]);         /* mov al, [0x101c391e] */
            ii(0x1013_862d, 6); mov(memb[ss, ebp - 904], al);           /* mov [ebp-0x388], al */
            ii(0x1013_8633, 7); mov(memb[ds, 0x101c_391e], 0xa);        /* mov byte [0x101c391e], 0xa */
            ii(0x1013_863a, 5); call(0x100c_aa00, -0x6_dc3f);           /* call 0x100caa00 */
            ii(0x1013_863f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_8644, 1); push(eax);                              /* push eax */
            ii(0x1013_8645, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x1013_864a, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1013_864f, 5); mov(edx, 2);                            /* mov edx, 0x2 */
            ii(0x1013_8654, 5); mov(eax, StringDefinitions.UnableToLoadASavedGameWhileRemotePlayInProgress2); /* mov eax, 0x101ac834 */
            ii(0x1013_8659, 5); call(0x1011_5d23, -0x2_293b);           /* call 0x10115d23 */
            ii(0x1013_865e, 6); mov(al, memb[ss, ebp - 904]);           /* mov al, [ebp-0x388] */
            ii(0x1013_8664, 5); mov(memb[ds, 0x101c_391e], al);         /* mov [0x101c391e], al */
            ii(0x1013_8669, 2); jmp(0x1013_86a2, 0x37); goto l_0x1013_86a2; /* jmp 0x101386a2 */
        l_0x1013_866b:
            ii(0x1013_866b, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1013_866f, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x1013_8672, 2); if(jz(0x1013_8685, 0x11)) goto l_0x1013_8685; /* jz 0x10138685 */
            ii(0x1013_8674, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1013_8678, 3); imul(eax, eax, 0x53);                   /* imul eax, eax, 0x53 */
            ii(0x1013_867b, 8); cmp(memb[ds, eax + ebp - 807], 0);      /* cmp byte [eax+ebp-0x327], 0x0 */
            ii(0x1013_8683, 2); if(jnz(0x1013_8687, 2)) goto l_0x1013_8687; /* jnz 0x10138687 */
        l_0x1013_8685:
            ii(0x1013_8685, 2); jmp(0x1013_86a2, 0x1b); goto l_0x1013_86a2; /* jmp 0x101386a2 */
        l_0x1013_8687:
            ii(0x1013_8687, 4); movsx(edx, memw[ss, ebp - 20]);         /* movsx edx, word [ebp-0x14] */
            ii(0x1013_868b, 5); mov(eax, memd[ds, 0x101b_d366]);        /* mov eax, [0x101bd366] */
            ii(0x1013_8690, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_8693, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_8695, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x1013_8698, 10); mov(memd[ss, ebp - 892], 1);           /* mov dword [ebp-0x37c], 0x1 */
        l_0x1013_86a2:
            ii(0x1013_86a2, 5); jmp(0x1013_8bfe, 0x557); goto l_0x1013_8bfe; /* jmp 0x10138bfe */
        l_0x1013_86a7:
            ii(0x1013_86a7, 5); mov(eax, 0x517);                        /* mov eax, 0x517 */
            ii(0x1013_86ac, 5); call(0x1013_82da, -0x3d7);              /* call 0x101382da */
            ii(0x1013_86b1, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1013_86b5, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x1013_86b8, 6); if(jz(0x1013_884f, 0x191)) goto l_0x1013_884f; /* jz 0x1013884f */
            ii(0x1013_86be, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x1013_86c3, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1013_86c7, 3); imul(eax, eax, 0x53);                   /* imul eax, eax, 0x53 */
            ii(0x1013_86ca, 7); mov(eax, memd[ds, eax + ebp - 805]);    /* mov eax, [eax+ebp-0x325] */
            ii(0x1013_86d1, 5); call(0x100e_b283, -0x4_d453);           /* call 0x100eb283 */
            ii(0x1013_86d6, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1013_86da, 3); imul(eax, eax, 0x53);                   /* imul eax, eax, 0x53 */
            ii(0x1013_86dd, 6); lea(edx, memd[ss, ebp - 884]);          /* lea edx, [ebp-0x374] */
            ii(0x1013_86e3, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_86e5, 5); call(0x1013_6e52, -0x1898);             /* call 0x10136e52 */
            ii(0x1013_86ea, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x1013_86f1, 2); if(jz(0x1013_86fc, 9)) goto l_0x1013_86fc; /* jz 0x101386fc */
            ii(0x1013_86f3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_86f5, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x1013_86f8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_86fa, 2); if(jz(0x1013_86fe, 2)) goto l_0x1013_86fe; /* jz 0x101386fe */
        l_0x1013_86fc:
            ii(0x1013_86fc, 2); jmp(0x1013_8727, 0x29); goto l_0x1013_8727; /* jmp 0x10138727 */
        l_0x1013_86fe:
            ii(0x1013_86fe, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1013_8702, 3); imul(edx, eax, 0x53);                   /* imul edx, eax, 0x53 */
            ii(0x1013_8705, 6); lea(eax, memd[ss, ebp - 884]);          /* lea eax, [ebp-0x374] */
            ii(0x1013_870b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_870d, 3); lea(edx, memd[ds, eax + 47]);           /* lea edx, [eax+0x2f] */
            ii(0x1013_8710, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1013_8714, 3); imul(eax, eax, 0x53);                   /* imul eax, eax, 0x53 */
            ii(0x1013_8717, 6); lea(ebx, memd[ss, ebp - 884]);          /* lea ebx, [ebp-0x374] */
            ii(0x1013_871d, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1013_871f, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1013_8722, 5); call(0x1012_9155, -0xf5d2);             /* call 0x10129155 */
        l_0x1013_8727:
            ii(0x1013_8727, 4); cmp(memb[ss, ebp - 24], 1);             /* cmp byte [ebp-0x18], 0x1 */
            ii(0x1013_872b, 2); if(jz(0x1013_8733, 6)) goto l_0x1013_8733; /* jz 0x10138733 */
            ii(0x1013_872d, 4); cmp(memb[ss, ebp - 24], 8);             /* cmp byte [ebp-0x18], 0x8 */
            ii(0x1013_8731, 2); if(jnz(0x1013_8735, 2)) goto l_0x1013_8735; /* jnz 0x10138735 */
        l_0x1013_8733:
            ii(0x1013_8733, 2); jmp(0x1013_873b, 6); goto l_0x1013_873b; /* jmp 0x1013873b */
        l_0x1013_8735:
            ii(0x1013_8735, 4); cmp(memb[ss, ebp - 24], 2);             /* cmp byte [ebp-0x18], 0x2 */
            ii(0x1013_8739, 2); if(jnz(0x1013_873d, 2)) goto l_0x1013_873d; /* jnz 0x1013873d */
        l_0x1013_873b:
            ii(0x1013_873b, 2); jmp(0x1013_8747, 0xa); goto l_0x1013_8747; /* jmp 0x10138747 */
        l_0x1013_873d:
            ii(0x1013_873d, 4); cmp(memb[ss, ebp - 24], 9);             /* cmp byte [ebp-0x18], 0x9 */
            ii(0x1013_8741, 6); if(jnz(0x1013_87c9, 0x82)) goto l_0x1013_87c9; /* jnz 0x101387c9 */
        l_0x1013_8747:
            ii(0x1013_8747, 10); mov(memd[ds, 0x101c_37dc], 1);         /* mov dword [0x101c37dc], 0x1 */
            ii(0x1013_8751, 6); mov(ax, memw[ds, 0x101b_d368]);         /* mov ax, [0x101bd368] */
            ii(0x1013_8757, 3); mov(edx, memd[ss, ebp - 20]);           /* mov edx, [ebp-0x14] */
            ii(0x1013_875a, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_875c, 7); mov(memw[ds, 0x101c_3982], dx);         /* mov [0x101c3982], dx */
            ii(0x1013_8763, 4); cmp(memb[ss, ebp - 24], 9);             /* cmp byte [ebp-0x18], 0x9 */
            ii(0x1013_8767, 2); if(jnz(0x1013_87c9, 0x60)) goto l_0x1013_87c9; /* jnz 0x101387c9 */
            ii(0x1013_8769, 10); mov(memd[ss, ebp - 908], 0);           /* mov dword [ebp-0x38c], 0x0 */
            ii(0x1013_8773, 2); jmp(0x1013_8781, 0xc); goto l_0x1013_8781; /* jmp 0x10138781 */
        l_0x1013_8775:
            ii(0x1013_8775, 6); mov(eax, memd[ss, ebp - 908]);          /* mov eax, [ebp-0x38c] */
            ii(0x1013_877b, 6); inc(memd[ss, ebp - 908]);               /* inc dword [ebp-0x38c] */
        l_0x1013_8781:
            ii(0x1013_8781, 7); cmp(memd[ss, ebp - 908], 4);            /* cmp dword [ebp-0x38c], 0x4 */
            ii(0x1013_8788, 2); if(jge(0x1013_87c9, 0x3f)) goto l_0x1013_87c9; /* jge 0x101387c9 */
            ii(0x1013_878a, 10); imul(eax, memd[ss, ebp - 908], 0x247); /* imul eax, [ebp-0x38c], 0x247 */
            ii(0x1013_8794, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1013_879a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_879f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_87a1, 2); if(jz(0x1013_87c7, 0x24)) goto l_0x1013_87c7; /* jz 0x101387c7 */
            ii(0x1013_87a3, 6); mov(eax, memd[ss, ebp - 908]);          /* mov eax, [ebp-0x38c] */
            ii(0x1013_87a9, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1013_87ac, 6); mov(ebx, memd[ds, eax + 0x101b_b444]);  /* mov ebx, [eax+0x101bb444] */
            ii(0x1013_87b2, 6); mov(al, memb[ss, ebp - 908]);           /* mov al, [ebp-0x38c] */
            ii(0x1013_87b8, 2); add(al, 0x63);                          /* add al, 0x63 */
            ii(0x1013_87ba, 3); movsx(edx, al);                         /* movsx edx, al */
            ii(0x1013_87bd, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1013_87c2, 5); call(0x1010_6205, -0x3_25c2);           /* call 0x10106205 */
        l_0x1013_87c7:
            ii(0x1013_87c7, 2); jmp(0x1013_8775, -0x54); goto l_0x1013_8775; /* jmp 0x10138775 */
        l_0x1013_87c9:
            ii(0x1013_87c9, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1013_87ce, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1013_87d2, 3); imul(edx, eax, 0x53);                   /* imul edx, eax, 0x53 */
            ii(0x1013_87d5, 6); lea(eax, memd[ss, ebp - 884]);          /* lea eax, [ebp-0x374] */
            ii(0x1013_87db, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_87dd, 3); add(edx, 0x2f);                         /* add edx, 0x2f */
            ii(0x1013_87e0, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1013_87e4, 3); imul(eax, eax, 0x53);                   /* imul eax, eax, 0x53 */
            ii(0x1013_87e7, 6); lea(ecx, memd[ss, ebp - 884]);          /* lea ecx, [ebp-0x374] */
            ii(0x1013_87ed, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1013_87ef, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1013_87f2, 5); call(0x1013_6e81, -0x1976);             /* call 0x10136e81 */
            ii(0x1013_87f7, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1013_87fb, 3); imul(eax, eax, 0x53);                   /* imul eax, eax, 0x53 */
            ii(0x1013_87fe, 8); mov(memb[ds, eax + ebp - 807], 1);      /* mov byte [eax+ebp-0x327], 0x1 */
            ii(0x1013_8806, 4); movsx(edx, memw[ss, ebp - 20]);         /* movsx edx, word [ebp-0x14] */
            ii(0x1013_880a, 3); imul(edx, edx, 0x53);                   /* imul edx, edx, 0x53 */
            ii(0x1013_880d, 7); mov(dl, memb[ds, edx + ebp - 806]);     /* mov dl, [edx+ebp-0x326] */
            ii(0x1013_8814, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1013_881a, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1013_881e, 3); imul(eax, eax, 0x53);                   /* imul eax, eax, 0x53 */
            ii(0x1013_8821, 6); lea(ebx, memd[ss, ebp - 884]);          /* lea ebx, [ebp-0x374] */
            ii(0x1013_8827, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1013_8829, 5); call(0x1013_784d, -0xfe1);              /* call 0x1013784d */
            ii(0x1013_882e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_8830, 5); call(0x100e_883d, -0x4_fff8);           /* call 0x100e883d */
            ii(0x1013_8835, 3); mov(eax, memd[ds, eax + 18]);           /* mov eax, [eax+0x12] */
            ii(0x1013_8838, 5); call(Definitions.sys_display_draw_0, 0x2_ec47); /* call 0x10167484 */
            ii(0x1013_883d, 6); mov(ax, memw[ds, 0x101b_d368]);         /* mov ax, [0x101bd368] */
            ii(0x1013_8843, 3); mov(edx, memd[ss, ebp - 20]);           /* mov edx, [ebp-0x14] */
            ii(0x1013_8846, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_8848, 7); mov(memw[ds, 0x101c_7120], dx);         /* mov [0x101c7120], dx */
        l_0x1013_884f:
            ii(0x1013_884f, 5); jmp(0x1013_8bfe, 0x3aa); goto l_0x1013_8bfe; /* jmp 0x10138bfe */
        l_0x1013_8854:
            ii(0x1013_8854, 5); call(0x1011_6ba6, -0x2_1cb3);           /* call 0x10116ba6 */
            ii(0x1013_8859, 5); jmp(0x1013_8bfe, 0x3a0); goto l_0x1013_8bfe; /* jmp 0x10138bfe */
        l_0x1013_885e:
            ii(0x1013_885e, 5); mov(eax, 0x51a);                        /* mov eax, 0x51a */
            ii(0x1013_8863, 5); call(0x1013_82da, -0x58e);              /* call 0x101382da */
        l_0x1013_8868:
            ii(0x1013_8868, 4); cmp(memb[ss, ebp - 8], 0);              /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1013_886c, 2); if(jz(0x1013_889d, 0x2f)) goto l_0x1013_889d; /* jz 0x1013889d */
            ii(0x1013_886e, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x1013_8875, 2); if(jnz(0x1013_8880, 9)) goto l_0x1013_8880; /* jnz 0x10138880 */
            ii(0x1013_8877, 7); mov(memb[ss, ebp - 912], 1);            /* mov byte [ebp-0x390], 0x1 */
            ii(0x1013_887e, 2); jmp(0x1013_8887, 7); goto l_0x1013_8887; /* jmp 0x10138887 */
        l_0x1013_8880:
            ii(0x1013_8880, 7); mov(memb[ss, ebp - 912], 0);            /* mov byte [ebp-0x390], 0x0 */
        l_0x1013_8887:
            ii(0x1013_8887, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_8889, 6); mov(bl, memb[ss, ebp - 912]);           /* mov bl, [ebp-0x390] */
            ii(0x1013_888f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_8891, 5); mov(eax, 8);                            /* mov eax, 0x8 */
            ii(0x1013_8896, 5); call(0x1010_5b00, -0x3_2d9b);           /* call 0x10105b00 */
            ii(0x1013_889b, 2); jmp(0x1013_88b2, 0x15); goto l_0x1013_88b2; /* jmp 0x101388b2 */
        l_0x1013_889d:
            ii(0x1013_889d, 5); call(0x100d_4e6c, -0x6_3a36);           /* call 0x100d4e6c */
            ii(0x1013_88a2, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_88a4, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1013_88a6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_88a8, 5); mov(eax, 7);                            /* mov eax, 0x7 */
            ii(0x1013_88ad, 5); call(0x1010_5b00, -0x3_2db2);           /* call 0x10105b00 */
        l_0x1013_88b2:
            ii(0x1013_88b2, 5); jmp(0x1013_8bfe, 0x347); goto l_0x1013_8bfe; /* jmp 0x10138bfe */
        l_0x1013_88b7:
            ii(0x1013_88b7, 5); mov(eax, 0x519);                        /* mov eax, 0x519 */
            ii(0x1013_88bc, 5); call(0x1013_82da, -0x5e7);              /* call 0x101382da */
        l_0x1013_88c1:
            ii(0x1013_88c1, 10); mov(memd[ss, ebp - 892], 1);           /* mov dword [ebp-0x37c], 0x1 */
            ii(0x1013_88cb, 5); jmp(0x1013_8bfe, 0x32e); goto l_0x1013_8bfe; /* jmp 0x10138bfe */
        l_0x1013_88d0:
            ii(0x1013_88d0, 5); mov(eax, 0x518);                        /* mov eax, 0x518 */
            ii(0x1013_88d5, 5); call(0x1013_82da, -0x600);              /* call 0x101382da */
            ii(0x1013_88da, 7); mov(memb[ds, 0x101c_391e], 3);          /* mov byte [0x101c391e], 0x3 */
            ii(0x1013_88e1, 10); mov(memd[ss, ebp - 892], 1);           /* mov dword [ebp-0x37c], 0x1 */
            ii(0x1013_88eb, 5); jmp(0x1013_8bfe, 0x30e); goto l_0x1013_8bfe; /* jmp 0x10138bfe */
        l_0x1013_88f0:
            ii(0x1013_88f0, 5); mov(eax, 0x4ff);                        /* mov eax, 0x4ff */
            ii(0x1013_88f5, 5); call(0x1013_82da, -0x620);              /* call 0x101382da */
            ii(0x1013_88fa, 10); cmp(memd[ss, ebp - 896], 0x149);       /* cmp dword [ebp-0x380], 0x149 */
            ii(0x1013_8904, 2); if(jnz(0x1013_8913, 0xd)) goto l_0x1013_8913; /* jnz 0x10138913 */
            ii(0x1013_8906, 5); mov(eax, memd[ds, 0x101b_d366]);        /* mov eax, [0x101bd366] */
            ii(0x1013_890b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_890e, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x1013_8911, 2); if(jz(0x1013_8915, 2)) goto l_0x1013_8915; /* jz 0x10138915 */
        l_0x1013_8913:
            ii(0x1013_8913, 2); jmp(0x1013_891a, 5); goto l_0x1013_891a; /* jmp 0x1013891a */
        l_0x1013_8915:
            ii(0x1013_8915, 5); jmp(0x1013_8bfe, 0x2e4); goto l_0x1013_8bfe; /* jmp 0x10138bfe */
        l_0x1013_891a:
            ii(0x1013_891a, 10); cmp(memd[ss, ebp - 896], 0x151);       /* cmp dword [ebp-0x380], 0x151 */
            ii(0x1013_8924, 2); if(jnz(0x1013_8933, 0xd)) goto l_0x1013_8933; /* jnz 0x10138933 */
            ii(0x1013_8926, 5); mov(eax, memd[ds, 0x101b_d366]);        /* mov eax, [0x101bd366] */
            ii(0x1013_892b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_892e, 3); cmp(eax, 0x5b);                         /* cmp eax, 0x5b */
            ii(0x1013_8931, 2); if(jz(0x1013_8935, 2)) goto l_0x1013_8935; /* jz 0x10138935 */
        l_0x1013_8933:
            ii(0x1013_8933, 2); jmp(0x1013_893a, 5); goto l_0x1013_893a; /* jmp 0x1013893a */
        l_0x1013_8935:
            ii(0x1013_8935, 5); jmp(0x1013_8bfe, 0x2c4); goto l_0x1013_8bfe; /* jmp 0x10138bfe */
        l_0x1013_893a:
            ii(0x1013_893a, 4); cmp(memb[ss, ebp - 8], 0);              /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1013_893e, 2); if(jz(0x1013_894c, 0xc)) goto l_0x1013_894c; /* jz 0x1013894c */
            ii(0x1013_8940, 10); mov(memd[ss, ebp - 916], 7);           /* mov dword [ebp-0x394], 0x7 */
            ii(0x1013_894a, 2); jmp(0x1013_8956, 0xa); goto l_0x1013_8956; /* jmp 0x10138956 */
        l_0x1013_894c:
            ii(0x1013_894c, 10); mov(memd[ss, ebp - 916], 5);           /* mov dword [ebp-0x394], 0x5 */
        l_0x1013_8956:
            ii(0x1013_8956, 6); mov(eax, memd[ss, ebp - 916]);          /* mov eax, [ebp-0x394] */
            ii(0x1013_895c, 6); mov(memd[ss, ebp - 920], eax);          /* mov [ebp-0x398], eax */
            ii(0x1013_8962, 10); mov(memd[ss, ebp - 908], 0);           /* mov dword [ebp-0x38c], 0x0 */
            ii(0x1013_896c, 2); jmp(0x1013_897a, 0xc); goto l_0x1013_897a; /* jmp 0x1013897a */
        l_0x1013_896e:
            ii(0x1013_896e, 6); mov(eax, memd[ss, ebp - 908]);          /* mov eax, [ebp-0x38c] */
            ii(0x1013_8974, 6); inc(memd[ss, ebp - 908]);               /* inc dword [ebp-0x38c] */
        l_0x1013_897a:
            ii(0x1013_897a, 7); movsx(eax, memw[ss, ebp - 920]);        /* movsx eax, word [ebp-0x398] */
            ii(0x1013_8981, 6); cmp(eax, memd[ss, ebp - 908]);          /* cmp eax, [ebp-0x38c] */
            ii(0x1013_8987, 2); if(jle(0x1013_89cb, 0x42)) goto l_0x1013_89cb; /* jle 0x101389cb */
            ii(0x1013_8989, 6); mov(eax, memd[ss, ebp - 908]);          /* mov eax, [ebp-0x38c] */
            ii(0x1013_898f, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1013_8992, 4); mov(eax, memd[ds, eax + ebp - 52]);     /* mov eax, [eax+ebp-0x34] */
            ii(0x1013_8996, 6); mov(memd[ss, ebp - 924], eax);          /* mov [ebp-0x39c], eax */
            ii(0x1013_899c, 7); cmp(memd[ss, ebp - 924], 0);            /* cmp dword [ebp-0x39c], 0x0 */
            ii(0x1013_89a3, 2); if(jz(0x1013_89bf, 0x1a)) goto l_0x1013_89bf; /* jz 0x101389bf */
            ii(0x1013_89a5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_89a7, 6); mov(eax, memd[ss, ebp - 924]);          /* mov eax, [ebp-0x39c] */
            ii(0x1013_89ad, 5); call(Definitions.my_dtor_d2, -0x6_a47a); /* call 0x100ce538 */
            ii(0x1013_89b2, 5); call(Definitions.sys_delete, 0x2_d5ad); /* call 0x10165f64 */
            ii(0x1013_89b7, 6); mov(memd[ss, ebp - 928], eax);          /* mov [ebp-0x3a0], eax */
            ii(0x1013_89bd, 2); jmp(0x1013_89c9, 0xa); goto l_0x1013_89c9; /* jmp 0x101389c9 */
        l_0x1013_89bf:
            ii(0x1013_89bf, 10); mov(memd[ss, ebp - 928], 0);           /* mov dword [ebp-0x3a0], 0x0 */
        l_0x1013_89c9:
            ii(0x1013_89c9, 2); jmp(0x1013_896e, -0x5d); goto l_0x1013_896e; /* jmp 0x1013896e */
        l_0x1013_89cb:
            ii(0x1013_89cb, 10); mov(memd[ss, ebp - 908], 0);           /* mov dword [ebp-0x38c], 0x0 */
            ii(0x1013_89d5, 2); jmp(0x1013_89e3, 0xc); goto l_0x1013_89e3; /* jmp 0x101389e3 */
        l_0x1013_89d7:
            ii(0x1013_89d7, 6); mov(eax, memd[ss, ebp - 908]);          /* mov eax, [ebp-0x38c] */
            ii(0x1013_89dd, 6); inc(memd[ss, ebp - 908]);               /* inc dword [ebp-0x38c] */
        l_0x1013_89e3:
            ii(0x1013_89e3, 7); cmp(memd[ss, ebp - 908], 0xa);          /* cmp dword [ebp-0x38c], 0xa */
            ii(0x1013_89ea, 2); if(jge(0x1013_8a02, 0x16)) goto l_0x1013_8a02; /* jge 0x10138a02 */
            ii(0x1013_89ec, 7); imul(eax, memd[ss, ebp - 908], 0x53);   /* imul eax, [ebp-0x38c], 0x53 */
            ii(0x1013_89f3, 6); lea(edx, memd[ss, ebp - 884]);          /* lea edx, [ebp-0x374] */
            ii(0x1013_89f9, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_89fb, 5); call(0x1013_6ad6, -0x1f2a);             /* call 0x10136ad6 */
            ii(0x1013_8a00, 2); jmp(0x1013_89d7, -0x2b); goto l_0x1013_89d7; /* jmp 0x101389d7 */
        l_0x1013_8a02:
            ii(0x1013_8a02, 10); cmp(memd[ss, ebp - 896], 0x13b);       /* cmp dword [ebp-0x380], 0x13b */
            ii(0x1013_8a0c, 2); if(jz(0x1013_8a1e, 0x10)) goto l_0x1013_8a1e; /* jz 0x10138a1e */
            ii(0x1013_8a0e, 10); cmp(memd[ss, ebp - 896], 0x13c);       /* cmp dword [ebp-0x380], 0x13c */
            ii(0x1013_8a18, 6); if(jnz(0x1013_8a9b, 0x7d)) goto l_0x1013_8a9b; /* jnz 0x10138a9b */
        l_0x1013_8a1e:
            ii(0x1013_8a1e, 10); cmp(memd[ss, ebp - 896], 0x13b);       /* cmp dword [ebp-0x380], 0x13b */
            ii(0x1013_8a28, 2); if(jnz(0x1013_8a36, 0xc)) goto l_0x1013_8a36; /* jnz 0x10138a36 */
            ii(0x1013_8a2a, 10); mov(memd[ss, ebp - 932], 1);           /* mov dword [ebp-0x3a4], 0x1 */
            ii(0x1013_8a34, 2); jmp(0x1013_8a40, 0xa); goto l_0x1013_8a40; /* jmp 0x10138a40 */
        l_0x1013_8a36:
            ii(0x1013_8a36, 10); mov(memd[ss, ebp - 932], 0xffff_ffff); /* mov dword [ebp-0x3a4], 0xffffffff */
        l_0x1013_8a40:
            ii(0x1013_8a40, 4); movsx(eax, memb[ss, ebp - 24]);         /* movsx eax, byte [ebp-0x18] */
            ii(0x1013_8a44, 6); add(eax, memd[ss, ebp - 932]);          /* add eax, [ebp-0x3a4] */
            ii(0x1013_8a4a, 3); mov(memb[ss, ebp - 24], al);            /* mov [ebp-0x18], al */
            ii(0x1013_8a4d, 4); cmp(memb[ss, ebp - 24], 0xa);           /* cmp byte [ebp-0x18], 0xa */
            ii(0x1013_8a51, 2); if(jnz(0x1013_8a59, 6)) goto l_0x1013_8a59; /* jnz 0x10138a59 */
            ii(0x1013_8a53, 4); mov(memb[ss, ebp - 24], 0);             /* mov byte [ebp-0x18], 0x0 */
            ii(0x1013_8a57, 2); jmp(0x1013_8a63, 0xa); goto l_0x1013_8a63; /* jmp 0x10138a63 */
        l_0x1013_8a59:
            ii(0x1013_8a59, 4); cmp(memb[ss, ebp - 24], 0);             /* cmp byte [ebp-0x18], 0x0 */
            ii(0x1013_8a5d, 2); if(jge(0x1013_8a63, 4)) goto l_0x1013_8a63; /* jge 0x10138a63 */
            ii(0x1013_8a5f, 4); mov(memb[ss, ebp - 24], 9);             /* mov byte [ebp-0x18], 0x9 */
        l_0x1013_8a63:
            ii(0x1013_8a63, 4); movsx(edx, memb[ss, ebp - 24]);         /* movsx edx, byte [ebp-0x18] */
            ii(0x1013_8a67, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x1013_8a6c, 5); call(0x100c_aafc, -0x6_df75);           /* call 0x100caafc */
            ii(0x1013_8a71, 4); cmp(memb[ss, ebp - 24], 7);             /* cmp byte [ebp-0x18], 0x7 */
            ii(0x1013_8a75, 2); if(jnz(0x1013_8a80, 9)) goto l_0x1013_8a80; /* jnz 0x10138a80 */
            ii(0x1013_8a77, 7); mov(memb[ss, ebp - 936], 1);            /* mov byte [ebp-0x3a8], 0x1 */
            ii(0x1013_8a7e, 2); jmp(0x1013_8a87, 7); goto l_0x1013_8a87; /* jmp 0x10138a87 */
        l_0x1013_8a80:
            ii(0x1013_8a80, 7); mov(memb[ss, ebp - 936], 0);            /* mov byte [ebp-0x3a8], 0x0 */
        l_0x1013_8a87:
            ii(0x1013_8a87, 6); mov(al, memb[ss, ebp - 936]);           /* mov al, [ebp-0x3a8] */
            ii(0x1013_8a8d, 3); mov(memb[ss, ebp - 4], al);             /* mov [ebp-0x4], al */
            ii(0x1013_8a90, 9); mov(memw[ds, 0x101b_d368], 1);          /* mov word [0x101bd368], 0x1 */
            ii(0x1013_8a99, 2); jmp(0x1013_8ac6, 0x2b); goto l_0x1013_8ac6; /* jmp 0x10138ac6 */
        l_0x1013_8a9b:
            ii(0x1013_8a9b, 10); cmp(memd[ss, ebp - 896], 0x149);       /* cmp dword [ebp-0x380], 0x149 */
            ii(0x1013_8aa5, 2); if(jnz(0x1013_8abe, 0x17)) goto l_0x1013_8abe; /* jnz 0x10138abe */
            ii(0x1013_8aa7, 5); mov(eax, memd[ds, 0x101b_d366]);        /* mov eax, [0x101bd366] */
            ii(0x1013_8aac, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_8aaf, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x1013_8ab2, 2); if(jle(0x1013_8abc, 8)) goto l_0x1013_8abc; /* jle 0x10138abc */
            ii(0x1013_8ab4, 8); sub(memw[ds, 0x101b_d368], 0xa);        /* sub word [0x101bd368], 0xa */
        l_0x1013_8abc:
            ii(0x1013_8abc, 2); jmp(0x1013_8ac6, 8); goto l_0x1013_8ac6; /* jmp 0x10138ac6 */
        l_0x1013_8abe:
            ii(0x1013_8abe, 8); add(memw[ds, 0x101b_d368], 0xa);        /* add word [0x101bd368], 0xa */
        l_0x1013_8ac6:
            ii(0x1013_8ac6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_8ac8, 1); push(eax);                              /* push eax */
            ii(0x1013_8ac9, 5); mov(eax, memd[ds, 0x101b_d366]);        /* mov eax, [0x101bd366] */
            ii(0x1013_8ace, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_8ad1, 1); push(eax);                              /* push eax */
            ii(0x1013_8ad2, 4); movsx(eax, memb[ss, ebp - 24]);         /* movsx eax, byte [ebp-0x18] */
            ii(0x1013_8ad6, 1); push(eax);                              /* push eax */
            ii(0x1013_8ad7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_8ad9, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x1013_8adc, 1); push(eax);                              /* push eax */
            ii(0x1013_8add, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_8adf, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1013_8ae2, 1); push(eax);                              /* push eax */
            ii(0x1013_8ae3, 3); lea(ecx, memd[ss, ebp - 16]);           /* lea ecx, [ebp-0x10] */
            ii(0x1013_8ae6, 3); lea(ebx, memd[ss, ebp - 52]);           /* lea ebx, [ebp-0x34] */
            ii(0x1013_8ae9, 5); mov(edx, 0xa);                          /* mov edx, 0xa */
            ii(0x1013_8aee, 6); lea(eax, memd[ss, ebp - 884]);          /* lea eax, [ebp-0x374] */
            ii(0x1013_8af4, 5); call(0x1013_7a19, -0x10e0);             /* call 0x10137a19 */
            ii(0x1013_8af9, 7); mov(memd[ss, ebp - 20], 0xffff_ffff);   /* mov dword [ebp-0x14], 0xffffffff */
            ii(0x1013_8b00, 5); jmp(0x1013_8bfe, 0xf9); goto l_0x1013_8bfe; /* jmp 0x10138bfe */
        l_0x1013_8b05:
            ii(0x1013_8b05, 5); jmp(0x1013_8bfe, 0xf4); goto l_0x1013_8bfe; /* jmp 0x10138bfe */
        l_0x1013_8b0a:
            ii(0x1013_8b0a, 10); cmp(memd[ss, ebp - 900], 0x151);       /* cmp dword [ebp-0x384], 0x151 */
            ii(0x1013_8b14, 6); if(jb(0x1013_8ba0, 0x86)) goto l_0x1013_8ba0; /* jb 0x10138ba0 */
            ii(0x1013_8b1a, 10); cmp(memd[ss, ebp - 900], 0x151);       /* cmp dword [ebp-0x384], 0x151 */
            ii(0x1013_8b24, 6); if(jbe(0x1013_88f0, -0x23a)) goto l_0x1013_88f0; /* jbe 0x101388f0 */
            ii(0x1013_8b2a, 10); cmp(memd[ss, ebp - 900], 0x3fe);       /* cmp dword [ebp-0x384], 0x3fe */
            ii(0x1013_8b34, 2); if(jb(0x1013_8b6a, 0x34)) goto l_0x1013_8b6a; /* jb 0x10138b6a */
            ii(0x1013_8b36, 10); cmp(memd[ss, ebp - 900], 0x3fe);       /* cmp dword [ebp-0x384], 0x3fe */
            ii(0x1013_8b40, 6); if(jbe(0x1013_86a7, -0x49f)) goto l_0x1013_86a7; /* jbe 0x101386a7 */
            ii(0x1013_8b46, 10); cmp(memd[ss, ebp - 900], 0x3ff);       /* cmp dword [ebp-0x384], 0x3ff */
            ii(0x1013_8b50, 6); if(jbe(0x1013_860d, -0x549)) goto l_0x1013_860d; /* jbe 0x1013860d */
            ii(0x1013_8b56, 10); cmp(memd[ss, ebp - 900], 0x400);       /* cmp dword [ebp-0x384], 0x400 */
            ii(0x1013_8b60, 6); if(jz(0x1013_88d0, -0x296)) goto l_0x1013_88d0; /* jz 0x101388d0 */
            ii(0x1013_8b66, 2); jmp(0x1013_8b05, -0x63); goto l_0x1013_8b05; /* jmp 0x10138b05 */
        //  ii(0x1013_8b68, 2); jmp(0x1013_8b05, -0x65); goto l_0x1013_8b05; /* jmp 0x10138b05 */
        l_0x1013_8b6a:
            ii(0x1013_8b6a, 10); cmp(memd[ss, ebp - 900], 0x3e8);       /* cmp dword [ebp-0x384], 0x3e8 */
            ii(0x1013_8b74, 2); if(jb(0x1013_8b9b, 0x25)) goto l_0x1013_8b9b; /* jb 0x10138b9b */
            ii(0x1013_8b76, 10); cmp(memd[ss, ebp - 900], 0x3e8);       /* cmp dword [ebp-0x384], 0x3e8 */
            ii(0x1013_8b80, 6); if(jbe(0x1013_88b7, -0x2cf)) goto l_0x1013_88b7; /* jbe 0x101388b7 */
            ii(0x1013_8b86, 10); cmp(memd[ss, ebp - 900], 0x3fd);       /* cmp dword [ebp-0x384], 0x3fd */
            ii(0x1013_8b90, 6); if(jz(0x1013_885e, -0x338)) goto l_0x1013_885e; /* jz 0x1013885e */
            ii(0x1013_8b96, 5); jmp(0x1013_8b05, -0x96); goto l_0x1013_8b05; /* jmp 0x10138b05 */
        l_0x1013_8b9b:
            ii(0x1013_8b9b, 5); jmp(0x1013_8b05, -0x9b); goto l_0x1013_8b05; /* jmp 0x10138b05 */
        l_0x1013_8ba0:
            ii(0x1013_8ba0, 7); cmp(memd[ss, ebp - 900], 0x3f);         /* cmp dword [ebp-0x384], 0x3f */
            ii(0x1013_8ba7, 2); if(jb(0x1013_8bec, 0x43)) goto l_0x1013_8bec; /* jb 0x10138bec */
            ii(0x1013_8ba9, 7); cmp(memd[ss, ebp - 900], 0x3f);         /* cmp dword [ebp-0x384], 0x3f */
            ii(0x1013_8bb0, 6); if(jbe(0x1013_8868, -0x34e)) goto l_0x1013_8868; /* jbe 0x10138868 */
            ii(0x1013_8bb6, 10); cmp(memd[ss, ebp - 900], 0x119);       /* cmp dword [ebp-0x384], 0x119 */
            ii(0x1013_8bc0, 2); if(jb(0x1013_8be7, 0x25)) goto l_0x1013_8be7; /* jb 0x10138be7 */
            ii(0x1013_8bc2, 10); cmp(memd[ss, ebp - 900], 0x119);       /* cmp dword [ebp-0x384], 0x119 */
            ii(0x1013_8bcc, 6); if(jbe(0x1013_8854, -0x37e)) goto l_0x1013_8854; /* jbe 0x10138854 */
            ii(0x1013_8bd2, 10); cmp(memd[ss, ebp - 900], 0x149);       /* cmp dword [ebp-0x384], 0x149 */
            ii(0x1013_8bdc, 6); if(jz(0x1013_88f0, -0x2f2)) goto l_0x1013_88f0; /* jz 0x101388f0 */
            ii(0x1013_8be2, 5); jmp(0x1013_8b05, -0xe2); goto l_0x1013_8b05; /* jmp 0x10138b05 */
        l_0x1013_8be7:
            ii(0x1013_8be7, 5); jmp(0x1013_8b05, -0xe7); goto l_0x1013_8b05; /* jmp 0x10138b05 */
        l_0x1013_8bec:
            ii(0x1013_8bec, 7); cmp(memd[ss, ebp - 900], 0x1b);         /* cmp dword [ebp-0x384], 0x1b */
            ii(0x1013_8bf3, 6); if(jz(0x1013_88c1, -0x338)) goto l_0x1013_88c1; /* jz 0x101388c1 */
            ii(0x1013_8bf9, 5); jmp(0x1013_8b05, -0xf9); goto l_0x1013_8b05; /* jmp 0x10138b05 */
        l_0x1013_8bfe:
            ii(0x1013_8bfe, 4); cmp(memd[ss, ebp - 16], 0);             /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1013_8c02, 2); if(jz(0x1013_8c14, 0x10)) goto l_0x1013_8c14; /* jz 0x10138c14 */
            ii(0x1013_8c04, 6); mov(eax, memd[ss, ebp - 888]);          /* mov eax, [ebp-0x378] */
            ii(0x1013_8c0a, 5); call(0x1014_85ad, 0xf99e);              /* call 0x101485ad */
            ii(0x1013_8c0f, 3); cmp(eax, 0x50);                         /* cmp eax, 0x50 */
            ii(0x1013_8c12, 2); if(jae(0x1013_8c16, 2)) goto l_0x1013_8c16; /* jae 0x10138c16 */
        l_0x1013_8c14:
            ii(0x1013_8c14, 2); jmp(0x1013_8c29, 0x13); goto l_0x1013_8c29; /* jmp 0x10138c29 */
        l_0x1013_8c16:
            ii(0x1013_8c16, 5); call(0x1014_82f4, 0xf6d9);              /* call 0x101482f4 */
            ii(0x1013_8c1b, 6); mov(memd[ss, ebp - 888], eax);          /* mov [ebp-0x378], eax */
            ii(0x1013_8c21, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1013_8c24, 5); call(0x100f_066e, -0x4_85bb);           /* call 0x100f066e */
        l_0x1013_8c29:
            ii(0x1013_8c29, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x1013_8c30, 2); if(jz(0x1013_8c44, 0x12)) goto l_0x1013_8c44; /* jz 0x10138c44 */
            ii(0x1013_8c32, 5); call(0x100d_5094, -0x6_3ba3);           /* call 0x100d5094 */
            ii(0x1013_8c37, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_8c39, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1013_8c3b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_8c3d, 5); call(0x1010_0e32, -0x3_7e10);           /* call 0x10100e32 */
            ii(0x1013_8c42, 2); jmp(0x1013_8c75, 0x31); goto l_0x1013_8c75; /* jmp 0x10138c75 */
        l_0x1013_8c44:
            ii(0x1013_8c44, 7); cmp(memb[ds, 0x101c_391e], 3);          /* cmp byte [0x101c391e], 0x3 */
            ii(0x1013_8c4b, 2); if(jz(0x1013_8c56, 9)) goto l_0x1013_8c56; /* jz 0x10138c56 */
            ii(0x1013_8c4d, 7); cmp(memb[ds, 0x101c_391e], 6);          /* cmp byte [0x101c391e], 0x6 */
            ii(0x1013_8c54, 2); if(jnz(0x1013_8c58, 2)) goto l_0x1013_8c58; /* jnz 0x10138c58 */
        l_0x1013_8c56:
            ii(0x1013_8c56, 2); jmp(0x1013_8c61, 9); goto l_0x1013_8c61; /* jmp 0x10138c61 */
        l_0x1013_8c58:
            ii(0x1013_8c58, 7); cmp(memb[ds, 0x101c_391e], 0xa);        /* cmp byte [0x101c391e], 0xa */
            ii(0x1013_8c5f, 2); if(jnz(0x1013_8c63, 2)) goto l_0x1013_8c63; /* jnz 0x10138c63 */
        l_0x1013_8c61:
            ii(0x1013_8c61, 2); jmp(0x1013_8c75, 0x12); goto l_0x1013_8c75; /* jmp 0x10138c75 */
        l_0x1013_8c63:
            ii(0x1013_8c63, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_8c68, 5); mov(eax, memd[ds, 0x101c_3960]);        /* mov eax, [0x101c3960] */
            ii(0x1013_8c6d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_8c70, 5); call(0x100f_334b, -0x4_592a);           /* call 0x100f334b */
        l_0x1013_8c75:
            ii(0x1013_8c75, 7); cmp(memd[ss, ebp - 892], 0);            /* cmp dword [ebp-0x37c], 0x0 */
            ii(0x1013_8c7c, 6); if(jz(0x1013_84d6, -0x7ac)) goto l_0x1013_84d6; /* jz 0x101384d6 */
            ii(0x1013_8c82, 4); cmp(memb[ss, ebp - 8], 0);              /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1013_8c86, 2); if(jz(0x1013_8c94, 0xc)) goto l_0x1013_8c94; /* jz 0x10138c94 */
            ii(0x1013_8c88, 10); mov(memd[ss, ebp - 940], 7);           /* mov dword [ebp-0x3ac], 0x7 */
            ii(0x1013_8c92, 2); jmp(0x1013_8c9e, 0xa); goto l_0x1013_8c9e; /* jmp 0x10138c9e */
        l_0x1013_8c94:
            ii(0x1013_8c94, 10); mov(memd[ss, ebp - 940], 5);           /* mov dword [ebp-0x3ac], 0x5 */
        l_0x1013_8c9e:
            ii(0x1013_8c9e, 6); mov(eax, memd[ss, ebp - 940]);          /* mov eax, [ebp-0x3ac] */
            ii(0x1013_8ca4, 6); mov(memd[ss, ebp - 944], eax);          /* mov [ebp-0x3b0], eax */
            ii(0x1013_8caa, 10); mov(memd[ss, ebp - 908], 0);           /* mov dword [ebp-0x38c], 0x0 */
            ii(0x1013_8cb4, 2); jmp(0x1013_8cc2, 0xc); goto l_0x1013_8cc2; /* jmp 0x10138cc2 */
        l_0x1013_8cb6:
            ii(0x1013_8cb6, 6); mov(eax, memd[ss, ebp - 908]);          /* mov eax, [ebp-0x38c] */
            ii(0x1013_8cbc, 6); inc(memd[ss, ebp - 908]);               /* inc dword [ebp-0x38c] */
        l_0x1013_8cc2:
            ii(0x1013_8cc2, 7); movsx(eax, memw[ss, ebp - 944]);        /* movsx eax, word [ebp-0x3b0] */
            ii(0x1013_8cc9, 6); cmp(eax, memd[ss, ebp - 908]);          /* cmp eax, [ebp-0x38c] */
            ii(0x1013_8ccf, 2); if(jle(0x1013_8d13, 0x42)) goto l_0x1013_8d13; /* jle 0x10138d13 */
            ii(0x1013_8cd1, 6); mov(eax, memd[ss, ebp - 908]);          /* mov eax, [ebp-0x38c] */
            ii(0x1013_8cd7, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1013_8cda, 4); mov(eax, memd[ds, eax + ebp - 52]);     /* mov eax, [eax+ebp-0x34] */
            ii(0x1013_8cde, 6); mov(memd[ss, ebp - 948], eax);          /* mov [ebp-0x3b4], eax */
            ii(0x1013_8ce4, 7); cmp(memd[ss, ebp - 948], 0);            /* cmp dword [ebp-0x3b4], 0x0 */
            ii(0x1013_8ceb, 2); if(jz(0x1013_8d07, 0x1a)) goto l_0x1013_8d07; /* jz 0x10138d07 */
            ii(0x1013_8ced, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_8cef, 6); mov(eax, memd[ss, ebp - 948]);          /* mov eax, [ebp-0x3b4] */
            ii(0x1013_8cf5, 5); call(Definitions.my_dtor_d2, -0x6_a7c2); /* call 0x100ce538 */
            ii(0x1013_8cfa, 5); call(Definitions.sys_delete, 0x2_d265); /* call 0x10165f64 */
            ii(0x1013_8cff, 6); mov(memd[ss, ebp - 952], eax);          /* mov [ebp-0x3b8], eax */
            ii(0x1013_8d05, 2); jmp(0x1013_8d11, 0xa); goto l_0x1013_8d11; /* jmp 0x10138d11 */
        l_0x1013_8d07:
            ii(0x1013_8d07, 10); mov(memd[ss, ebp - 952], 0);           /* mov dword [ebp-0x3b8], 0x0 */
        l_0x1013_8d11:
            ii(0x1013_8d11, 2); jmp(0x1013_8cb6, -0x5d); goto l_0x1013_8cb6; /* jmp 0x10138cb6 */
        l_0x1013_8d13:
            ii(0x1013_8d13, 4); cmp(memd[ss, ebp - 16], 0);             /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1013_8d17, 2); if(jz(0x1013_8d29, 0x10)) goto l_0x1013_8d29; /* jz 0x10138d29 */
            ii(0x1013_8d19, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1013_8d1c, 5); call(0x100f_0748, -0x4_85d9);           /* call 0x100f0748 */
            ii(0x1013_8d21, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1013_8d24, 5); call(Definitions.sys_free, 0x3_2398);   /* call 0x1016b0c1 */
        l_0x1013_8d29:
            ii(0x1013_8d29, 5); call(0x100e_a903, -0x4_e42b);           /* call 0x100ea903 */
            ii(0x1013_8d2e, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x1013_8d35, 2); if(jnz(0x1013_8d41, 0xa)) goto l_0x1013_8d41; /* jnz 0x10138d41 */
            ii(0x1013_8d37, 5); call(0x1014_82f4, 0xf5b8);              /* call 0x101482f4 */
            ii(0x1013_8d3c, 5); mov(memd[ds, 0x101c_396c], eax);        /* mov [0x101c396c], eax */
        l_0x1013_8d41:
            ii(0x1013_8d41, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_8d44, 6); mov(memd[ss, ebp - 956], eax);          /* mov [ebp-0x3bc], eax */
            ii(0x1013_8d4a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_8d4c, 6); lea(eax, memd[ss, ebp - 884]);          /* lea eax, [ebp-0x374] */
            ii(0x1013_8d52, 5); call(0x1013_9c8c, 0xf35);               /* call 0x10139c8c */
            ii(0x1013_8d57, 2); jmp(0x1013_8d66, 0xd); goto l_0x1013_8d66; /* jmp 0x10138d66 */
        //  ii(0x1013_8d59, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1013_8d5b, 6); lea(eax, memd[ss, ebp - 884]);          /* lea eax, [ebp-0x374] */
        //  ii(0x1013_8d61, 5); call(0x1013_9c8c, 0xf26);               /* call 0x10139c8c */
        l_0x1013_8d66:
            ii(0x1013_8d66, 6); mov(eax, memd[ss, ebp - 956]);          /* mov eax, [ebp-0x3bc] */
            ii(0x1013_8d6c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_8d6e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_8d6f, 1); pop(edi);                               /* pop edi */
            ii(0x1013_8d70, 1); pop(esi);                               /* pop esi */
            ii(0x1013_8d71, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_8d72, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_8d73, 1); ret();                                  /* ret */
        }
    }
}
