using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_0346-9faddf65")]
        public void Method_1013_0346()
        {
            ii(0x1013_0346, 5); push(0xc8);                             /* push 0xc8 */
            ii(0x1013_034b, 5); call(Definitions.sys_check_available_stack_size, 0x3_5a02); /* call 0x10165d52 */
            ii(0x1013_0350, 1); push(ebx);                              /* push ebx */
            ii(0x1013_0351, 1); push(ecx);                              /* push ecx */
            ii(0x1013_0352, 1); push(edx);                              /* push edx */
            ii(0x1013_0353, 1); push(esi);                              /* push esi */
            ii(0x1013_0354, 1); push(edi);                              /* push edi */
            ii(0x1013_0355, 1); push(ebp);                              /* push ebp */
            ii(0x1013_0356, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_0358, 6); sub(esp, 0x90);                         /* sub esp, 0x90 */
            ii(0x1013_035e, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1013_0361, 4); or(memb[ss, ebp - 0x8], 0x1);           /* or byte [ebp-0x8], 0x1 */
            ii(0x1013_0365, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1013_0368, 5); call(Definitions.my_string_ctor, 0x1_177b); /* call 0x10141ae8 */
            ii(0x1013_036d, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
            ii(0x1013_0370, 4); and(memb[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1013_0374, 7); mov(memd[ss, ebp - 0x1c], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1013_037b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_037e, 6); mov(eax, memd[ds, eax + 0xde]);         /* mov eax, [eax+0xde] */
            ii(0x1013_0384, 5); call(0x100d_4ef0, -0x5_b499);           /* call 0x100d4ef0 */
            ii(0x1013_0389, 1); cwde();                                 /* cwde */
            ii(0x1013_038a, 3); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x1013_038d, 3); mov(memd[ss, ebp - 0x60], eax);         /* mov [ebp-0x60], eax */
            ii(0x1013_0390, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_0393, 6); mov(eax, memd[ds, eax + 0xde]);         /* mov eax, [eax+0xde] */
            ii(0x1013_0399, 5); call(0x100d_4ebc, -0x5_b4e2);           /* call 0x100d4ebc */
            ii(0x1013_039e, 1); cwde();                                 /* cwde */
            ii(0x1013_039f, 3); add(eax, 0x3c);                         /* add eax, 0x3c */
            ii(0x1013_03a2, 3); mov(memd[ss, ebp - 0x5c], eax);         /* mov [ebp-0x5c], eax */
            ii(0x1013_03a5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_03a8, 6); mov(eax, memd[ds, eax + 0xde]);         /* mov eax, [eax+0xde] */
            ii(0x1013_03ae, 5); call(0x100d_4ef0, -0x5_b4c3);           /* call 0x100d4ef0 */
            ii(0x1013_03b3, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1013_03b6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_03b9, 6); mov(eax, memd[ds, eax + 0xde]);         /* mov eax, [eax+0xde] */
            ii(0x1013_03bf, 5); call(0x100d_4f58, -0x5_b46c);           /* call 0x100d4f58 */
            ii(0x1013_03c4, 1); cwde();                                 /* cwde */
            ii(0x1013_03c5, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_03c7, 3); mov(memd[ss, ebp - 0x58], edx);         /* mov [ebp-0x58], edx */
            ii(0x1013_03ca, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_03cd, 6); mov(eax, memd[ds, eax + 0xde]);         /* mov eax, [eax+0xde] */
            ii(0x1013_03d3, 5); call(0x100d_4ebc, -0x5_b51c);           /* call 0x100d4ebc */
            ii(0x1013_03d8, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1013_03db, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_03de, 6); mov(eax, memd[ds, eax + 0xde]);         /* mov eax, [eax+0xde] */
            ii(0x1013_03e4, 5); call(0x100d_4f24, -0x5_b4c5);           /* call 0x100d4f24 */
            ii(0x1013_03e9, 1); cwde();                                 /* cwde */
            ii(0x1013_03ea, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_03ec, 3); sub(eax, 0x16);                         /* sub eax, 0x16 */
            ii(0x1013_03ef, 3); mov(memd[ss, ebp - 0x54], eax);         /* mov [ebp-0x54], eax */
            ii(0x1013_03f2, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1013_03f7, 5); call(/* sys */ 0x1016_a24c, 0x3_9e50);  /* call 0x1016a24c */
            ii(0x1013_03fc, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_03ff, 6); mov(eax, memd[ds, eax + 0xde]);         /* mov eax, [eax+0xde] */
            ii(0x1013_0405, 5); call(0x100d_4ef0, -0x5_b51a);           /* call 0x100d4ef0 */
            ii(0x1013_040a, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1013_040d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_0410, 6); mov(eax, memd[ds, eax + 0xde]);         /* mov eax, [eax+0xde] */
            ii(0x1013_0416, 5); call(0x100d_4ebc, -0x5_b55f);           /* call 0x100d4ebc */
            ii(0x1013_041b, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1013_041e, 3); lea(edx, ebp - 0x7c);                   /* lea edx, [ebp-0x7c] */
            ii(0x1013_0421, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_0424, 5); call(0x100d_6a11, -0x5_9a18);           /* call 0x100d6a11 */
            ii(0x1013_0429, 7); mov(memd[ss, ebp - 0x34], 0);           /* mov dword [ebp-0x34], 0x0 */
            ii(0x1013_0430, 2); jmp(0x1013_0438, 0x6); goto l_0x1013_0438; /* jmp 0x10130438 */
        l_0x1013_0432:
            ii(0x1013_0432, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1013_0435, 3); inc(memd[ss, ebp - 0x34]);              /* inc dword [ebp-0x34] */
        l_0x1013_0438:
            ii(0x1013_0438, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1013_043c, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1013_043f, 6); if(jge(0x1013_05c8, 0x183)) goto l_0x1013_05c8; /* jge 0x101305c8 */
            ii(0x1013_0445, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1013_0449, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_044f, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1013_0455, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_045a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_045c, 6); if(jz(0x1013_05c3, 0x161)) goto l_0x1013_05c3; /* jz 0x101305c3 */
            ii(0x1013_0462, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1013_0466, 5); call(0x1013_0262, -0x209);              /* call 0x10130262 */
            ii(0x1013_046b, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x1013_046f, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1013_0471, 8); mov(memw[ds, edx + ebp - 0x84], ax);    /* mov [edx+ebp-0x84], ax */
            ii(0x1013_0479, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1013_047d, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1013_047f, 9); imul(dx, memw[ds, eax + ebp - 0x84], 0xa); /* imul dx, [eax+ebp-0x84], 0xa */
            ii(0x1013_0488, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1013_048c, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_0492, 7); mov(ax, memw[ds, eax + 0x101c_a550]);   /* mov ax, [eax+0x101ca550] */
            ii(0x1013_0499, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_049b, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x1013_049e, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1013_04a1, 4); cmp(ax, memw[ss, ebp - 0x1c]);          /* cmp ax, [ebp-0x1c] */
            ii(0x1013_04a5, 2); if(jle(0x1013_04ad, 0x6)) goto l_0x1013_04ad; /* jle 0x101304ad */
            ii(0x1013_04a7, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1013_04aa, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
        l_0x1013_04ad:
            ii(0x1013_04ad, 7); mov(memd[ss, ebp - 0x28], 0);           /* mov dword [ebp-0x28], 0x0 */
            ii(0x1013_04b4, 2); jmp(0x1013_04bc, 0x6); goto l_0x1013_04bc; /* jmp 0x101304bc */
        l_0x1013_04b6:
            ii(0x1013_04b6, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1013_04b9, 3); inc(memd[ss, ebp - 0x28]);              /* inc dword [ebp-0x28] */
        l_0x1013_04bc:
            ii(0x1013_04bc, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1013_04c0, 3); cmp(eax, 0x32);                         /* cmp eax, 0x32 */
            ii(0x1013_04c3, 2); if(jge(0x1013_0502, 0x3d)) goto l_0x1013_0502; /* jge 0x10130502 */
            ii(0x1013_04c5, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1013_04c9, 6); imul(edx, eax, 0x247);                  /* imul edx, eax, 0x247 */
            ii(0x1013_04cf, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1013_04d3, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1013_04d5, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_04d7, 7); mov(ax, memw[ds, eax + 0x101c_a585]);   /* mov ax, [eax+0x101ca585] */
            ii(0x1013_04de, 4); cmp(ax, memw[ss, ebp - 0x1c]);          /* cmp ax, [ebp-0x1c] */
            ii(0x1013_04e2, 2); if(jle(0x1013_0500, 0x1c)) goto l_0x1013_0500; /* jle 0x10130500 */
            ii(0x1013_04e4, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1013_04e8, 6); imul(edx, eax, 0x247);                  /* imul edx, eax, 0x247 */
            ii(0x1013_04ee, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1013_04f2, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1013_04f4, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_04f6, 7); mov(ax, memw[ds, eax + 0x101c_a585]);   /* mov ax, [eax+0x101ca585] */
            ii(0x1013_04fd, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
        l_0x1013_0500:
            ii(0x1013_0500, 2); jmp(0x1013_04b6, -0x4c); goto l_0x1013_04b6; /* jmp 0x101304b6 */
        l_0x1013_0502:
            ii(0x1013_0502, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1013_0506, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1013_0508, 7); mov(eax, memd[ds, eax + ebp - 0x86]);   /* mov eax, [eax+ebp-0x86] */
            ii(0x1013_050f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_0512, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1013_0515, 2); if(jnz(0x1013_0523, 0xc)) goto l_0x1013_0523; /* jnz 0x10130523 */
            ii(0x1013_0517, 10); mov(memd[ss, ebp - 0x88], StringDefinitions.EcoSphere); /* mov dword [ebp-0x88], 0x101a88a2 */
            ii(0x1013_0521, 2); jmp(0x1013_052d, 0xa); goto l_0x1013_052d; /* jmp 0x1013052d */
        l_0x1013_0523:
            ii(0x1013_0523, 10); mov(memd[ss, ebp - 0x88], StringDefinitions.EcoSpheres); /* mov dword [ebp-0x88], 0x101a88ad */
        l_0x1013_052d:
            ii(0x1013_052d, 6); push(memd[ss, ebp - 0x88]);             /* push dword [ebp-0x88] */
            ii(0x1013_0533, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1013_0537, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1013_0539, 7); mov(eax, memd[ds, eax + ebp - 0x86]);   /* mov eax, [eax+ebp-0x86] */
            ii(0x1013_0540, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_0543, 1); push(eax);                              /* push eax */
            ii(0x1013_0544, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1013_0548, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_054e, 6); push(memd[ds, eax + 0x101c_a550]);      /* push dword [eax+0x101ca550] */
            ii(0x1013_0554, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1013_0558, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_055b, 6); push(memd[ds, eax + 0x101b_b490]);      /* push dword [eax+0x101bb490] */
            ii(0x1013_0561, 5); mov(eax, StringDefinitions.SIPointsIS); /* mov eax, 0x101a88b9 */
            ii(0x1013_0566, 1); push(eax);                              /* push eax */
            ii(0x1013_0567, 5); mov(eax, 0x46);                         /* mov eax, 0x46 */
            ii(0x1013_056c, 1); push(eax);                              /* push eax */
            ii(0x1013_056d, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1013_0570, 1); push(eax);                              /* push eax */
            ii(0x1013_0571, 5); call(0x1014_2037, 0x1_1ac1);            /* call 0x10142037 */
            ii(0x1013_0576, 3); add(esp, 0x1c);                         /* add esp, 0x1c */
            ii(0x1013_0579, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1013_057d, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_0580, 6); push(memd[ds, eax + 0x101b_b4a0]);      /* push dword [eax+0x101bb4a0] */
            ii(0x1013_0586, 4); movsx(ecx, memw[ss, ebp - 0x6c]);       /* movsx ecx, word [ebp-0x6c] */
            ii(0x1013_058a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_058d, 6); mov(eax, memd[ds, eax + 0xde]);         /* mov eax, [eax+0xde] */
            ii(0x1013_0593, 5); call(0x100d_4f58, -0x5_b640);           /* call 0x100d4f58 */
            ii(0x1013_0598, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1013_059b, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1013_059e, 5); call(Definitions.my_strobj_c_str_v2, -0xa_6ddb); /* call 0x100897c8 */
            ii(0x1013_05a3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_05a5, 4); movsx(esi, memw[ss, ebp - 0x6c]);       /* movsx esi, word [ebp-0x6c] */
            ii(0x1013_05a9, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1013_05ad, 3); imul(esi, eax);                         /* imul esi, eax */
            ii(0x1013_05b0, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1013_05b4, 3); add(eax, memd[ss, ebp - 0x66]);         /* add eax, [ebp-0x66] */
            ii(0x1013_05b7, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1013_05b9, 6); call_abs(memd[ds, 0x101b_ddec]);        /* call dword [0x101bddec] */
            ii(0x1013_05bf, 4); add(memd[ss, ebp - 0x24], 0xc);         /* add dword [ebp-0x24], 0xc */
        l_0x1013_05c3:
            ii(0x1013_05c3, 5); jmp(0x1013_0432, -0x196); goto l_0x1013_0432; /* jmp 0x10130432 */
        l_0x1013_05c8:
            ii(0x1013_05c8, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_05cc, 3); cmp(eax, 0x14);                         /* cmp eax, 0x14 */
            ii(0x1013_05cf, 2); if(jge(0x1013_05d8, 0x7)) goto l_0x1013_05d8; /* jge 0x101305d8 */
            ii(0x1013_05d1, 7); mov(memd[ss, ebp - 0x1c], 0x14);        /* mov dword [ebp-0x1c], 0x14 */
        l_0x1013_05d8:
            ii(0x1013_05d8, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1013_05dc, 3); add(edx, 0x9);                          /* add edx, 0x9 */
            ii(0x1013_05df, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1013_05e4, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_05e6, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_05e9, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_05eb, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x1013_05ee, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1013_05f1, 2); push(0x4);                              /* push 0x4 */
            ii(0x1013_05f3, 3); mov(eax, memd[ss, ebp - 0x54]);         /* mov eax, [ebp-0x54] */
            ii(0x1013_05f6, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1013_05f9, 1); push(eax);                              /* push eax */
            ii(0x1013_05fa, 3); mov(eax, memd[ss, ebp - 0x60]);         /* mov eax, [ebp-0x60] */
            ii(0x1013_05fd, 3); sub(eax, 0x2);                          /* sub eax, 0x2 */
            ii(0x1013_0600, 1); push(eax);                              /* push eax */
            ii(0x1013_0601, 3); mov(ecx, memd[ss, ebp - 0x5c]);         /* mov ecx, [ebp-0x5c] */
            ii(0x1013_0604, 3); mov(ebx, memd[ss, ebp - 0x60]);         /* mov ebx, [ebp-0x60] */
            ii(0x1013_0607, 3); sub(ebx, 0x2);                          /* sub ebx, 0x2 */
            ii(0x1013_060a, 4); movsx(edx, memw[ss, ebp - 0x6c]);       /* movsx edx, word [ebp-0x6c] */
            ii(0x1013_060e, 3); mov(eax, memd[ss, ebp - 0x66]);         /* mov eax, [ebp-0x66] */
            ii(0x1013_0611, 5); call(/* sys */ 0x1016_a5a0, 0x3_9f8a);  /* call 0x1016a5a0 */
            ii(0x1013_0616, 2); push(0x4);                              /* push 0x4 */
            ii(0x1013_0618, 3); mov(eax, memd[ss, ebp - 0x54]);         /* mov eax, [ebp-0x54] */
            ii(0x1013_061b, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1013_061e, 1); push(eax);                              /* push eax */
            ii(0x1013_061f, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x1013_0622, 1); dec(eax);                               /* dec eax */
            ii(0x1013_0623, 1); push(eax);                              /* push eax */
            ii(0x1013_0624, 3); mov(ecx, memd[ss, ebp - 0x54]);         /* mov ecx, [ebp-0x54] */
            ii(0x1013_0627, 3); add(ecx, 0x2);                          /* add ecx, 0x2 */
            ii(0x1013_062a, 3); mov(ebx, memd[ss, ebp - 0x60]);         /* mov ebx, [ebp-0x60] */
            ii(0x1013_062d, 3); sub(ebx, 0x2);                          /* sub ebx, 0x2 */
            ii(0x1013_0630, 4); movsx(edx, memw[ss, ebp - 0x6c]);       /* movsx edx, word [ebp-0x6c] */
            ii(0x1013_0634, 3); mov(eax, memd[ss, ebp - 0x66]);         /* mov eax, [ebp-0x66] */
            ii(0x1013_0637, 5); call(/* sys */ 0x1016_a5a0, 0x3_9f64);  /* call 0x1016a5a0 */
            ii(0x1013_063c, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x1013_063f, 3); sub(eax, memd[ss, ebp - 0x60]);         /* sub eax, [ebp-0x60] */
            ii(0x1013_0642, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x1013_0645, 3); mov(eax, memd[ss, ebp - 0x54]);         /* mov eax, [ebp-0x54] */
            ii(0x1013_0648, 3); sub(eax, memd[ss, ebp - 0x5c]);         /* sub eax, [ebp-0x5c] */
            ii(0x1013_064b, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_064e, 7); mov(memd[ss, ebp - 0x34], 0);           /* mov dword [ebp-0x34], 0x0 */
            ii(0x1013_0655, 2); jmp(0x1013_065d, 0x6); goto l_0x1013_065d; /* jmp 0x1013065d */
        l_0x1013_0657:
            ii(0x1013_0657, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1013_065a, 3); inc(memd[ss, ebp - 0x34]);              /* inc dword [ebp-0x34] */
        l_0x1013_065d:
            ii(0x1013_065d, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1013_0661, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x1013_0664, 2); if(jg(0x1013_06dc, 0x76)) goto l_0x1013_06dc; /* jg 0x101306dc */
            ii(0x1013_0666, 2); push(0x4);                              /* push 0x4 */
            ii(0x1013_0668, 4); movsx(ecx, memw[ss, ebp - 0x6c]);       /* movsx ecx, word [ebp-0x6c] */
            ii(0x1013_066c, 5); mov(ebx, 0x22);                         /* mov ebx, 0x22 */
            ii(0x1013_0671, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1013_0675, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1013_0679, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1013_067c, 5); mov(esi, 0xa);                          /* mov esi, 0xa */
            ii(0x1013_0681, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_0683, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_0686, 2); idiv(esi);                              /* idiv esi */
            ii(0x1013_0688, 3); movsx(esi, ax);                         /* movsx esi, ax */
            ii(0x1013_068b, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x1013_068f, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_0693, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1013_0696, 5); mov(edi, 0xa);                          /* mov edi, 0xa */
            ii(0x1013_069b, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_069d, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_06a0, 2); idiv(edi);                              /* idiv edi */
            ii(0x1013_06a2, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1013_06a6, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1013_06a9, 4); movsx(edi, memw[ss, ebp - 0x1c]);       /* movsx edi, word [ebp-0x1c] */
            ii(0x1013_06ad, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_06af, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_06b2, 2); idiv(edi);                              /* idiv edi */
            ii(0x1013_06b4, 3); mov(edx, memd[ss, ebp - 0x54]);         /* mov edx, [ebp-0x54] */
            ii(0x1013_06b7, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1013_06b9, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_06bb, 4); movsx(edx, memw[ss, ebp - 0x6c]);       /* movsx edx, word [ebp-0x6c] */
            ii(0x1013_06bf, 3); sub(eax, 0xa);                          /* sub eax, 0xa */
            ii(0x1013_06c2, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1013_06c5, 3); mov(eax, memd[ss, ebp - 0x66]);         /* mov eax, [ebp-0x66] */
            ii(0x1013_06c8, 3); add(eax, memd[ss, ebp - 0x60]);         /* add eax, [ebp-0x60] */
            ii(0x1013_06cb, 3); sub(eax, 0x4);                          /* sub eax, 0x4 */
            ii(0x1013_06ce, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_06d0, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1013_06d2, 5); call(0x1012_b658, -0x507f);             /* call 0x1012b658 */
            ii(0x1013_06d7, 5); jmp(0x1013_0657, -0x85); goto l_0x1013_0657; /* jmp 0x10130657 */
        l_0x1013_06dc:
            ii(0x1013_06dc, 6); mov(ax, memw[ds, 0x101c_37dc]);         /* mov ax, [0x101c37dc] */
            ii(0x1013_06e2, 3); sub(eax, 0x31);                         /* sub eax, 0x31 */
            ii(0x1013_06e5, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1013_06e8, 6); mov(ax, memw[ds, 0x101c_37dc]);         /* mov ax, [0x101c37dc] */
            ii(0x1013_06ee, 5); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1013_06f3, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_06f6, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1013_06fa, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1013_06fd, 2); if(jge(0x1013_0706, 0x7)) goto l_0x1013_0706; /* jge 0x10130706 */
            ii(0x1013_06ff, 7); mov(memd[ss, ebp - 0x18], 0x1);         /* mov dword [ebp-0x18], 0x1 */
        l_0x1013_0706:
            ii(0x1013_0706, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x1013_070a, 6); sub(edx, memd[ds, 0x101c_37dc]);        /* sub edx, [0x101c37dc] */
            ii(0x1013_0710, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1013_0715, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_0717, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_071a, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_071c, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1013_071f, 4); imul(eax, memd[ss, ebp - 0x28], 0xa);   /* imul eax, [ebp-0x28], 0xa */
            ii(0x1013_0723, 7); mov(dx, memw[ds, 0x101c_37dc]);         /* mov dx, [0x101c37dc] */
            ii(0x1013_072a, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_072c, 3); mov(memd[ss, ebp - 0x28], edx);         /* mov [ebp-0x28], edx */
            ii(0x1013_072f, 3); mov(eax, memd[ss, ebp - 0x54]);         /* mov eax, [ebp-0x54] */
            ii(0x1013_0732, 5); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1013_0737, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
        l_0x1013_073a:
            ii(0x1013_073a, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1013_073d, 4); cmp(ax, memw[ss, ebp - 0x14]);          /* cmp ax, [ebp-0x14] */
            ii(0x1013_0741, 2); if(jg(0x1013_079b, 0x58)) goto l_0x1013_079b; /* jg 0x1013079b */
            ii(0x1013_0743, 2); push(0x4);                              /* push 0x4 */
            ii(0x1013_0745, 4); movsx(ecx, memw[ss, ebp - 0x6c]);       /* movsx ecx, word [ebp-0x6c] */
            ii(0x1013_0749, 5); mov(ebx, 0x22);                         /* mov ebx, 0x22 */
            ii(0x1013_074e, 4); movsx(esi, memw[ss, ebp - 0x28]);       /* movsx esi, word [ebp-0x28] */
            ii(0x1013_0752, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1013_0756, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1013_075a, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1013_075c, 4); movsx(eax, memw[ss, ebp - 0x38]);       /* movsx eax, word [ebp-0x38] */
            ii(0x1013_0760, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1013_0763, 5); mov(edi, 0x3c);                         /* mov edi, 0x3c */
            ii(0x1013_0768, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_076a, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_076d, 2); idiv(edi);                              /* idiv edi */
            ii(0x1013_076f, 3); mov(edx, memd[ss, ebp - 0x66]);         /* mov edx, [ebp-0x66] */
            ii(0x1013_0772, 3); add(edx, memd[ss, ebp - 0x60]);         /* add edx, [ebp-0x60] */
            ii(0x1013_0775, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_0777, 4); movsx(eax, memw[ss, ebp - 0x6c]);       /* movsx eax, word [ebp-0x6c] */
            ii(0x1013_077b, 4); movsx(edi, memw[ss, ebp - 0x24]);       /* movsx edi, word [ebp-0x24] */
            ii(0x1013_077f, 6); mov(memd[ss, ebp - 0x8c], edi);         /* mov [ebp-0x8c], edi */
            ii(0x1013_0785, 7); imul(eax, memd[ss, ebp - 0x8c]);        /* imul eax, [ebp-0x8c] */
            ii(0x1013_078c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_078e, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1013_0790, 5); call(0x1012_b658, -0x513d);             /* call 0x1012b658 */
            ii(0x1013_0795, 4); add(memd[ss, ebp - 0x28], 0xa);         /* add dword [ebp-0x28], 0xa */
            ii(0x1013_0799, 2); jmp(0x1013_073a, -0x61); goto l_0x1013_073a; /* jmp 0x1013073a */
        l_0x1013_079b:
            ii(0x1013_079b, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1013_079f, 6); cmp(eax, memd[ds, 0x101c_37dc]);        /* cmp eax, [0x101c37dc] */
            ii(0x1013_07a5, 2); if(jz(0x1013_07ee, 0x47)) goto l_0x1013_07ee; /* jz 0x101307ee */
            ii(0x1013_07a7, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x1013_07ab, 5); mov(eax, memd[ds, 0x101c_37dc]);        /* mov eax, [0x101c37dc] */
            ii(0x1013_07b0, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1013_07b2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_07b4, 4); movsx(eax, memw[ss, ebp - 0x38]);       /* movsx eax, word [ebp-0x38] */
            ii(0x1013_07b8, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1013_07bb, 5); mov(ebx, 0x3c);                         /* mov ebx, 0x3c */
            ii(0x1013_07c0, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_07c2, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_07c5, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_07c7, 3); add(eax, memd[ss, ebp - 0x60]);         /* add eax, [ebp-0x60] */
            ii(0x1013_07ca, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1013_07cd, 5); push(0xd7);                             /* push 0xd7 */
            ii(0x1013_07d2, 3); mov(eax, memd[ss, ebp - 0x54]);         /* mov eax, [ebp-0x54] */
            ii(0x1013_07d5, 1); push(eax);                              /* push eax */
            ii(0x1013_07d6, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1013_07da, 1); push(eax);                              /* push eax */
            ii(0x1013_07db, 3); mov(ecx, memd[ss, ebp - 0x5c]);         /* mov ecx, [ebp-0x5c] */
            ii(0x1013_07de, 4); movsx(ebx, memw[ss, ebp - 0x2c]);       /* movsx ebx, word [ebp-0x2c] */
            ii(0x1013_07e2, 4); movsx(edx, memw[ss, ebp - 0x6c]);       /* movsx edx, word [ebp-0x6c] */
            ii(0x1013_07e6, 3); mov(eax, memd[ss, ebp - 0x66]);         /* mov eax, [ebp-0x66] */
            ii(0x1013_07e9, 5); call(/* sys */ 0x1016_a5a0, 0x3_9db2);  /* call 0x1016a5a0 */
        l_0x1013_07ee:
            ii(0x1013_07ee, 5); mov(eax, memd[ds, 0x101c_3964]);        /* mov eax, [0x101c3964] */
            ii(0x1013_07f3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_07f6, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1013_07f9, 2); if(jnz(0x1013_0809, 0xe)) goto l_0x1013_0809; /* jnz 0x10130809 */
            ii(0x1013_07fb, 6); mov(ax, memw[ds, 0x101c_3968]);         /* mov ax, [0x101c3968] */
            ii(0x1013_0801, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1013_0804, 5); jmp(0x1013_088d, 0x84); goto l_0x1013_088d; /* jmp 0x1013088d */
        l_0x1013_0809:
            ii(0x1013_0809, 7); mov(memd[ss, ebp - 0x24], 0xa);         /* mov dword [ebp-0x24], 0xa */
            ii(0x1013_0810, 7); mov(memd[ss, ebp - 0x34], 0);           /* mov dword [ebp-0x34], 0x0 */
            ii(0x1013_0817, 2); jmp(0x1013_081f, 0x6); goto l_0x1013_081f; /* jmp 0x1013081f */
        l_0x1013_0819:
            ii(0x1013_0819, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1013_081c, 3); inc(memd[ss, ebp - 0x34]);              /* inc dword [ebp-0x34] */
        l_0x1013_081f:
            ii(0x1013_081f, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1013_0823, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1013_0826, 2); if(jge(0x1013_088d, 0x65)) goto l_0x1013_088d; /* jge 0x1013088d */
            ii(0x1013_0828, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1013_082c, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_0832, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1013_0838, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_083d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_083f, 2); if(jz(0x1013_088b, 0x4a)) goto l_0x1013_088b; /* jz 0x1013088b */
            ii(0x1013_0841, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x1013_0845, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1013_0847, 6); mov(ax, memw[ds, 0x101c_3968]);         /* mov ax, [0x101c3968] */
            ii(0x1013_084d, 7); sub(ax, memw[ds, 0x101c_37dc]);         /* sub ax, [0x101c37dc] */
            ii(0x1013_0854, 8); mov(dx, memw[ds, edx + ebp - 0x84]);    /* mov dx, [edx+ebp-0x84] */
            ii(0x1013_085c, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1013_085f, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1013_0863, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_0869, 7); mov(ax, memw[ds, eax + 0x101c_a550]);   /* mov ax, [eax+0x101ca550] */
            ii(0x1013_0870, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_0872, 6); mov(memd[ss, ebp - 0x90], eax);         /* mov [ebp-0x90], eax */
            ii(0x1013_0878, 7); movsx(edx, memw[ss, ebp - 0x90]);       /* movsx edx, word [ebp-0x90] */
            ii(0x1013_087f, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1013_0883, 5); call(0x1007_6e7c, -0xb_9a0c);           /* call 0x10076e7c */
            ii(0x1013_0888, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
        l_0x1013_088b:
            ii(0x1013_088b, 2); jmp(0x1013_0819, -0x74); goto l_0x1013_0819; /* jmp 0x10130819 */
        l_0x1013_088d:
            ii(0x1013_088d, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1013_0890, 4); cmp(ax, memw[ss, ebp - 0x1c]);          /* cmp ax, [ebp-0x1c] */
            ii(0x1013_0894, 2); if(jg(0x1013_08d8, 0x42)) goto l_0x1013_08d8; /* jg 0x101308d8 */
            ii(0x1013_0896, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1013_089a, 4); movsx(edx, memw[ss, ebp - 0x24]);       /* movsx edx, word [ebp-0x24] */
            ii(0x1013_089e, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1013_08a1, 4); movsx(ebx, memw[ss, ebp - 0x1c]);       /* movsx ebx, word [ebp-0x1c] */
            ii(0x1013_08a5, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_08a7, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_08aa, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_08ac, 3); mov(edx, memd[ss, ebp - 0x54]);         /* mov edx, [ebp-0x54] */
            ii(0x1013_08af, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1013_08b1, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_08b3, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1013_08b6, 5); push(0xd7);                             /* push 0xd7 */
            ii(0x1013_08bb, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1013_08bf, 1); push(eax);                              /* push eax */
            ii(0x1013_08c0, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x1013_08c3, 1); dec(eax);                               /* dec eax */
            ii(0x1013_08c4, 1); push(eax);                              /* push eax */
            ii(0x1013_08c5, 4); movsx(ecx, memw[ss, ebp - 0x24]);       /* movsx ecx, word [ebp-0x24] */
            ii(0x1013_08c9, 3); mov(ebx, memd[ss, ebp - 0x60]);         /* mov ebx, [ebp-0x60] */
            ii(0x1013_08cc, 4); movsx(edx, memw[ss, ebp - 0x6c]);       /* movsx edx, word [ebp-0x6c] */
            ii(0x1013_08d0, 3); mov(eax, memd[ss, ebp - 0x66]);         /* mov eax, [ebp-0x66] */
            ii(0x1013_08d3, 5); call(/* sys */ 0x1016_a5a0, 0x3_9cc8);  /* call 0x1016a5a0 */
        l_0x1013_08d8:
            ii(0x1013_08d8, 7); mov(memd[ss, ebp - 0x34], 0);           /* mov dword [ebp-0x34], 0x0 */
            ii(0x1013_08df, 2); jmp(0x1013_08e7, 0x6); goto l_0x1013_08e7; /* jmp 0x101308e7 */
        l_0x1013_08e1:
            ii(0x1013_08e1, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1013_08e4, 3); inc(memd[ss, ebp - 0x34]);              /* inc dword [ebp-0x34] */
        l_0x1013_08e7:
            ii(0x1013_08e7, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1013_08eb, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1013_08ee, 6); if(jge(0x1013_0bd1, 0x2dd)) goto l_0x1013_0bd1; /* jge 0x10130bd1 */
            ii(0x1013_08f4, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1013_08f8, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_08fe, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1013_0904, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_0909, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_090b, 6); if(jz(0x1013_0bcc, 0x2bb)) goto l_0x1013_0bcc; /* jz 0x10130bcc */
            ii(0x1013_0911, 3); mov(eax, memd[ss, ebp - 0x60]);         /* mov eax, [ebp-0x60] */
            ii(0x1013_0914, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_0917, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1013_091b, 6); cmp(eax, memd[ds, 0x101c_37dc]);        /* cmp eax, [0x101c37dc] */
            ii(0x1013_0921, 2); if(jnz(0x1013_0939, 0x16)) goto l_0x1013_0939; /* jnz 0x10130939 */
            ii(0x1013_0923, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1013_0927, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_092d, 7); mov(ax, memw[ds, eax + 0x101c_a550]);   /* mov ax, [eax+0x101ca550] */
            ii(0x1013_0934, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_0937, 2); jmp(0x1013_095e, 0x25); goto l_0x1013_095e; /* jmp 0x1013095e */
        l_0x1013_0939:
            ii(0x1013_0939, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1013_093d, 3); add(eax, 0x31);                         /* add eax, 0x31 */
            ii(0x1013_0940, 6); sub(eax, memd[ds, 0x101c_37dc]);        /* sub eax, [0x101c37dc] */
            ii(0x1013_0946, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1013_0948, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x1013_094c, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x1013_0952, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_0954, 7); mov(ax, memw[ds, eax + 0x101c_a585]);   /* mov ax, [eax+0x101ca585] */
            ii(0x1013_095b, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
        l_0x1013_095e:
            ii(0x1013_095e, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1013_0962, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1013_0966, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1013_0969, 4); movsx(ebx, memw[ss, ebp - 0x1c]);       /* movsx ebx, word [ebp-0x1c] */
            ii(0x1013_096d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_096f, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_0972, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_0974, 3); mov(edx, memd[ss, ebp - 0x54]);         /* mov edx, [ebp-0x54] */
            ii(0x1013_0977, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1013_0979, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_097b, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_097e, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_0981, 1); inc(eax);                               /* inc eax */
            ii(0x1013_0982, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1013_0985, 2); jmp(0x1013_098d, 0x6); goto l_0x1013_098d; /* jmp 0x1013098d */
        l_0x1013_0987:
            ii(0x1013_0987, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1013_098a, 3); inc(memd[ss, ebp - 0x28]);              /* inc dword [ebp-0x28] */
        l_0x1013_098d:
            ii(0x1013_098d, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1013_0991, 6); cmp(eax, memd[ds, 0x101c_37dc]);        /* cmp eax, [0x101c37dc] */
            ii(0x1013_0997, 6); if(jge(0x1013_0a5b, 0xbe)) goto l_0x1013_0a5b; /* jge 0x10130a5b */
            ii(0x1013_099d, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_09a0, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1013_09a3, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1013_09a6, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1013_09a9, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1013_09ad, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1013_09b1, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1013_09b3, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_09b5, 4); movsx(edx, memw[ss, ebp - 0x38]);       /* movsx edx, word [ebp-0x38] */
            ii(0x1013_09b9, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1013_09bc, 5); mov(ebx, 0x3c);                         /* mov ebx, 0x3c */
            ii(0x1013_09c1, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_09c3, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_09c6, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_09c8, 3); add(eax, memd[ss, ebp - 0x60]);         /* add eax, [ebp-0x60] */
            ii(0x1013_09cb, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_09ce, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1013_09d2, 3); add(eax, 0x31);                         /* add eax, 0x31 */
            ii(0x1013_09d5, 6); sub(eax, memd[ds, 0x101c_37dc]);        /* sub eax, [0x101c37dc] */
            ii(0x1013_09db, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1013_09dd, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x1013_09e1, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x1013_09e7, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_09e9, 7); mov(ax, memw[ds, eax + 0x101c_a585]);   /* mov ax, [eax+0x101ca585] */
            ii(0x1013_09f0, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_09f3, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1013_09f7, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1013_09fb, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1013_09fe, 4); movsx(ebx, memw[ss, ebp - 0x1c]);       /* movsx ebx, word [ebp-0x1c] */
            ii(0x1013_0a02, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_0a04, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_0a07, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_0a09, 3); mov(edx, memd[ss, ebp - 0x54]);         /* mov edx, [ebp-0x54] */
            ii(0x1013_0a0c, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1013_0a0e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_0a10, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_0a13, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1013_0a17, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_0a1a, 6); push(memd[ds, eax + 0x101b_b4a0]);      /* push dword [eax+0x101bb4a0] */
            ii(0x1013_0a20, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1013_0a24, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1013_0a28, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_0a2a, 1); push(eax);                              /* push eax */
            ii(0x1013_0a2b, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1013_0a2f, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1013_0a33, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_0a35, 1); push(eax);                              /* push eax */
            ii(0x1013_0a36, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1013_0a3a, 4); movsx(ecx, memw[ss, ebp - 0x34]);       /* movsx ecx, word [ebp-0x34] */
            ii(0x1013_0a3e, 2); add(ecx, eax);                          /* add ecx, eax */
            ii(0x1013_0a40, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1013_0a44, 4); movsx(ebx, memw[ss, ebp - 0x34]);       /* movsx ebx, word [ebp-0x34] */
            ii(0x1013_0a48, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1013_0a4a, 4); movsx(edx, memw[ss, ebp - 0x6c]);       /* movsx edx, word [ebp-0x6c] */
            ii(0x1013_0a4e, 3); mov(eax, memd[ss, ebp - 0x66]);         /* mov eax, [ebp-0x66] */
            ii(0x1013_0a51, 5); call(/* sys */ 0x1016_a5a0, 0x3_9b4a);  /* call 0x1016a5a0 */
            ii(0x1013_0a56, 5); jmp(0x1013_0987, -0xd4); goto l_0x1013_0987; /* jmp 0x10130987 */
        l_0x1013_0a5b:
            ii(0x1013_0a5b, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1013_0a5f, 6); cmp(eax, memd[ds, 0x101c_37dc]);        /* cmp eax, [0x101c37dc] */
            ii(0x1013_0a65, 6); if(jge(0x1013_0b15, 0xaa)) goto l_0x1013_0b15; /* jge 0x10130b15 */
            ii(0x1013_0a6b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_0a6e, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1013_0a71, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1013_0a74, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1013_0a77, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1013_0a7b, 6); mov(edx, memd[ds, 0x101c_37dc]);        /* mov edx, [0x101c37dc] */
            ii(0x1013_0a81, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1013_0a83, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_0a85, 4); movsx(edx, memw[ss, ebp - 0x38]);       /* movsx edx, word [ebp-0x38] */
            ii(0x1013_0a89, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1013_0a8c, 5); mov(ebx, 0x3c);                         /* mov ebx, 0x3c */
            ii(0x1013_0a91, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_0a93, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_0a96, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_0a98, 3); add(eax, memd[ss, ebp - 0x60]);         /* add eax, [ebp-0x60] */
            ii(0x1013_0a9b, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_0a9e, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1013_0aa2, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_0aa8, 7); mov(ax, memw[ds, eax + 0x101c_a550]);   /* mov ax, [eax+0x101ca550] */
            ii(0x1013_0aaf, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_0ab2, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1013_0ab6, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1013_0aba, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1013_0abd, 4); movsx(ebx, memw[ss, ebp - 0x1c]);       /* movsx ebx, word [ebp-0x1c] */
            ii(0x1013_0ac1, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_0ac3, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_0ac6, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_0ac8, 3); mov(edx, memd[ss, ebp - 0x54]);         /* mov edx, [ebp-0x54] */
            ii(0x1013_0acb, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1013_0acd, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_0acf, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_0ad2, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x1013_0ad6, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1013_0ad9, 6); push(memd[ds, edx + 0x101b_b4a0]);      /* push dword [edx+0x101bb4a0] */
            ii(0x1013_0adf, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1013_0ae3, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1013_0ae7, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_0ae9, 1); push(eax);                              /* push eax */
            ii(0x1013_0aea, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1013_0aee, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x1013_0af2, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_0af4, 1); push(eax);                              /* push eax */
            ii(0x1013_0af5, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1013_0af9, 4); movsx(ecx, memw[ss, ebp - 0x34]);       /* movsx ecx, word [ebp-0x34] */
            ii(0x1013_0afd, 2); add(ecx, eax);                          /* add ecx, eax */
            ii(0x1013_0aff, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1013_0b03, 4); movsx(ebx, memw[ss, ebp - 0x34]);       /* movsx ebx, word [ebp-0x34] */
            ii(0x1013_0b07, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1013_0b09, 4); movsx(edx, memw[ss, ebp - 0x6c]);       /* movsx edx, word [ebp-0x6c] */
            ii(0x1013_0b0d, 3); mov(eax, memd[ss, ebp - 0x66]);         /* mov eax, [ebp-0x66] */
            ii(0x1013_0b10, 5); call(/* sys */ 0x1016_a5a0, 0x3_9a8b);  /* call 0x1016a5a0 */
        l_0x1013_0b15:
            ii(0x1013_0b15, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_0b18, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1013_0b1b, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1013_0b1e, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1013_0b21, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1013_0b25, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x1013_0b29, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1013_0b2b, 4); movsx(edx, memw[ss, ebp - 0x38]);       /* movsx edx, word [ebp-0x38] */
            ii(0x1013_0b2f, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1013_0b32, 5); mov(ebx, 0x3c);                         /* mov ebx, 0x3c */
            ii(0x1013_0b37, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_0b39, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_0b3c, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_0b3e, 3); add(eax, memd[ss, ebp - 0x60]);         /* add eax, [ebp-0x60] */
            ii(0x1013_0b41, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_0b44, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1013_0b48, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1013_0b4a, 9); imul(dx, memw[ds, eax + ebp - 0x84], 0xa); /* imul dx, [eax+ebp-0x84], 0xa */
            ii(0x1013_0b53, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1013_0b57, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_0b5d, 7); mov(ax, memw[ds, eax + 0x101c_a550]);   /* mov ax, [eax+0x101ca550] */
            ii(0x1013_0b64, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_0b66, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_0b69, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1013_0b6d, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1013_0b71, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1013_0b74, 4); movsx(ebx, memw[ss, ebp - 0x1c]);       /* movsx ebx, word [ebp-0x1c] */
            ii(0x1013_0b78, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_0b7a, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_0b7d, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_0b7f, 3); mov(edx, memd[ss, ebp - 0x54]);         /* mov edx, [ebp-0x54] */
            ii(0x1013_0b82, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1013_0b84, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_0b86, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_0b89, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1013_0b8d, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_0b90, 6); push(memd[ds, eax + 0x101b_b4a0]);      /* push dword [eax+0x101bb4a0] */
            ii(0x1013_0b96, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1013_0b9a, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1013_0b9e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_0ba0, 1); push(eax);                              /* push eax */
            ii(0x1013_0ba1, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1013_0ba5, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x1013_0ba9, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_0bab, 1); push(eax);                              /* push eax */
            ii(0x1013_0bac, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1013_0bb0, 4); movsx(ecx, memw[ss, ebp - 0x34]);       /* movsx ecx, word [ebp-0x34] */
            ii(0x1013_0bb4, 2); add(ecx, eax);                          /* add ecx, eax */
            ii(0x1013_0bb6, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1013_0bba, 4); movsx(ebx, memw[ss, ebp - 0x34]);       /* movsx ebx, word [ebp-0x34] */
            ii(0x1013_0bbe, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1013_0bc0, 4); movsx(edx, memw[ss, ebp - 0x6c]);       /* movsx edx, word [ebp-0x6c] */
            ii(0x1013_0bc4, 3); mov(eax, memd[ss, ebp - 0x66]);         /* mov eax, [ebp-0x66] */
            ii(0x1013_0bc7, 5); call(/* sys */ 0x1016_a5a0, 0x3_99d4);  /* call 0x1016a5a0 */
        l_0x1013_0bcc:
            ii(0x1013_0bcc, 5); jmp(0x1013_08e1, -0x2f0); goto l_0x1013_08e1; /* jmp 0x101308e1 */
        l_0x1013_0bd1:
            ii(0x1013_0bd1, 5); call(0x100d_51e4, -0x5_b9f2);           /* call 0x100d51e4 */
            ii(0x1013_0bd6, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_0bd8, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1013_0bda, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_0bdc, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_0bdf, 6); mov(eax, memd[ds, eax + 0xce]);         /* mov eax, [eax+0xce] */
            ii(0x1013_0be5, 5); call(0x100c_fa7c, -0x6_116e);           /* call 0x100cfa7c */
            ii(0x1013_0bea, 5); call(0x100d_51e4, -0x5_ba0b);           /* call 0x100d51e4 */
            ii(0x1013_0bef, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_0bf1, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1013_0bf3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_0bf5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_0bf8, 6); mov(eax, memd[ds, eax + 0xd2]);         /* mov eax, [eax+0xd2] */
            ii(0x1013_0bfe, 5); call(0x100c_fa7c, -0x6_1187);           /* call 0x100cfa7c */
            ii(0x1013_0c03, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_0c05, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1013_0c08, 5); call(Definitions.my_string_dtor, 0x1_0f1d); /* call 0x10141b2a */
            ii(0x1013_0c0d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_0c0f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_0c10, 1); pop(edi);                               /* pop edi */
            ii(0x1013_0c11, 1); pop(esi);                               /* pop esi */
            ii(0x1013_0c12, 1); pop(edx);                               /* pop edx */
            ii(0x1013_0c13, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_0c14, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_0c15, 1); ret();                                  /* ret */
        }
    }
}
