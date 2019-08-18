using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b74478c7-4b15-4546-a2e0-2e874e6628e0")]
        public void Method_100d_6541()
        {
            ii(0x100d_6541, 4); movsx(eax, memw_a32[ss, ebp - 0x5c]);   /* movsx eax, word [ebp-0x5c] */
            ii(0x100d_6545, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_6547, 2); if(jld(0x100d_6552, 0x9)) goto l_0x100d_6552; /* jl 0x100d6552 */
            ii(0x100d_6549, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x100d_654c, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x100d_6550, 2); if(jld(0x100d_6554, 0x2)) goto l_0x100d_6554; /* jl 0x100d6554 */
        l_0x100d_6552:
            ii(0x100d_6552, 2); jmpd(0x100d_655c, 0x8); goto l_0x100d_655c; /* jmp 0x100d655c */
        l_0x100d_6554:
            ii(0x100d_6554, 4); movsx(eax, memw_a32[ss, ebp - 0x60]);   /* movsx eax, word [ebp-0x60] */
            ii(0x100d_6558, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_655a, 2); if(jged(0x100d_655e, 0x2)) goto l_0x100d_655e; /* jge 0x100d655e */
        l_0x100d_655c:
            ii(0x100d_655c, 2); jmpd(0x100d_6567, 0x9); goto l_0x100d_6567; /* jmp 0x100d6567 */
        l_0x100d_655e:
            ii(0x100d_655e, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x100d_6561, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x100d_6565, 2); if(jld(0x100d_656c, 0x5)) goto l_0x100d_656c; /* jl 0x100d656c */
        l_0x100d_6567:
            ii(0x100d_6567, 5); jmpd(0x100d_669f, 0x133); goto l_0x100d_669f; /* jmp 0x100d669f */
        l_0x100d_656c:
            ii(0x100d_656c, 4); movsx(eax, memw_a32[ss, ebp - 0x54]);   /* movsx eax, word [ebp-0x54] */
            ii(0x100d_6570, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_6572, 2); if(jld(0x100d_657d, 0x9)) goto l_0x100d_657d; /* jl 0x100d657d */
            ii(0x100d_6574, 3); mov(eax, memd_a32[ss, ebp - 0x5c]);     /* mov eax, [ebp-0x5c] */
            ii(0x100d_6577, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x100d_657b, 2); if(jld(0x100d_657f, 0x2)) goto l_0x100d_657f; /* jl 0x100d657f */
        l_0x100d_657d:
            ii(0x100d_657d, 2); jmpd(0x100d_6587, 0x8); goto l_0x100d_6587; /* jmp 0x100d6587 */
        l_0x100d_657f:
            ii(0x100d_657f, 4); movsx(eax, memw_a32[ss, ebp - 0x58]);   /* movsx eax, word [ebp-0x58] */
            ii(0x100d_6583, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_6585, 2); if(jged(0x100d_6589, 0x2)) goto l_0x100d_6589; /* jge 0x100d6589 */
        l_0x100d_6587:
            ii(0x100d_6587, 2); jmpd(0x100d_6592, 0x9); goto l_0x100d_6592; /* jmp 0x100d6592 */
        l_0x100d_6589:
            ii(0x100d_6589, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x100d_658c, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x100d_6590, 2); if(jld(0x100d_65df, 0x4d)) goto l_0x100d_65df; /* jl 0x100d65df */
        l_0x100d_6592:
            ii(0x100d_6592, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100d_6595, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_6598, 3); mov(memd_a32[ss, ebp - 0x70], eax);     /* mov [ebp-0x70], eax */
            ii(0x100d_659b, 4); movsx(eax, memw_a32[ss, ebp - 0x70]);   /* movsx eax, word [ebp-0x70] */
            ii(0x100d_659f, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100d_65a1, 7); mov(ax, memw_a32[ds, eax + 0x101b_7e6c]); /* mov ax, [eax+0x101b7e6c] */
            ii(0x100d_65a8, 3); mov(memd_a32[ss, ebp - 0x74], eax);     /* mov [ebp-0x74], eax */
            ii(0x100d_65ab, 4); movsx(eax, memw_a32[ss, ebp - 0x70]);   /* movsx eax, word [ebp-0x70] */
            ii(0x100d_65af, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100d_65b1, 7); mov(ax, memw_a32[ds, eax + 0x101b_7e6e]); /* mov ax, [eax+0x101b7e6e] */
            ii(0x100d_65b8, 3); mov(memd_a32[ss, ebp - 0x78], eax);     /* mov [ebp-0x78], eax */
            ii(0x100d_65bb, 4); movsx(eax, memw_a32[ss, ebp - 0x70]);   /* movsx eax, word [ebp-0x70] */
            ii(0x100d_65bf, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100d_65c1, 7); mov(ax, memw_a32[ds, eax + 0x101b_7e70]); /* mov ax, [eax+0x101b7e70] */
            ii(0x100d_65c8, 3); mov(memd_a32[ss, ebp - 0x7c], eax);     /* mov [ebp-0x7c], eax */
            ii(0x100d_65cb, 4); movsx(eax, memw_a32[ss, ebp - 0x70]);   /* movsx eax, word [ebp-0x70] */
            ii(0x100d_65cf, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100d_65d1, 7); mov(ax, memw_a32[ds, eax + 0x101b_7e72]); /* mov ax, [eax+0x101b7e72] */
            ii(0x100d_65d8, 3); mov(memd_a32[ss, ebp - 0x80], eax);     /* mov [ebp-0x80], eax */
            ii(0x100d_65db, 4); mov(memb_a32[ss, ebp - 0x40], 0x1);     /* mov byte [ebp-0x40], 0x1 */
        l_0x100d_65df:
            ii(0x100d_65df, 4); movsx(edx, memw_a32[ss, ebp - 0x50]);   /* movsx edx, word [ebp-0x50] */
            ii(0x100d_65e3, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100d_65e7, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100d_65ea, 4); movsx(eax, memw_a32[ss, ebp - 0x4c]);   /* movsx eax, word [ebp-0x4c] */
            ii(0x100d_65ee, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_65f0, 3); add(memd_a32[ss, ebp - 0x44], eax);     /* add [ebp-0x44], eax */
            ii(0x100d_65f3, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100d_65f6, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
        l_0x100d_65f9:
            ii(0x100d_65f9, 3); dec(memd_a32[ss, ebp - 0x3c]);          /* dec dword [ebp-0x3c] */
            ii(0x100d_65fc, 5); cmp(memw_a32[ss, ebp - 0x3c], -0x1 /* 0xff */); /* cmp word [ebp-0x3c], 0xffff */
            ii(0x100d_6601, 6); if(jzd(0x100d_669f, 0x98)) goto l_0x100d_669f; /* jz 0x100d669f */
            ii(0x100d_6607, 4); cmp(memb_a32[ss, ebp - 0x40], 0);       /* cmp byte [ebp-0x40], 0x0 */
            ii(0x100d_660b, 2); if(jnzd(0x100d_6636, 0x29)) goto l_0x100d_6636; /* jnz 0x100d6636 */
            ii(0x100d_660d, 3); mov(al, memb_a32[ss, ebp + 0x1c]);      /* mov al, [ebp+0x1c] */
            ii(0x100d_6610, 3); mov(edx, memd_a32[ss, ebp - 0x44]);     /* mov edx, [ebp-0x44] */
            ii(0x100d_6613, 2); mov(memb_a32[ds, edx], al);             /* mov [edx], al */
            ii(0x100d_6615, 4); movsx(eax, memw_a32[ss, ebp - 0x64]);   /* movsx eax, word [ebp-0x64] */
            ii(0x100d_6619, 3); add(memd_a32[ss, ebp - 0x44], eax);     /* add [ebp-0x44], eax */
            ii(0x100d_661c, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100d_661f, 3); inc(memd_a32[ss, ebp - 0x34]);          /* inc dword [ebp-0x34] */
            ii(0x100d_6622, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100d_6625, 3); cmp(memb_a32[ds, eax], 0);              /* cmp byte [eax], 0x0 */
            ii(0x100d_6628, 2); if(jzd(0x100d_6631, 0x7)) goto l_0x100d_6631; /* jz 0x100d6631 */
            ii(0x100d_662a, 4); movsx(eax, memw_a32[ss, ebp - 0x68]);   /* movsx eax, word [ebp-0x68] */
            ii(0x100d_662e, 3); add(memd_a32[ss, ebp - 0x44], eax);     /* add [ebp-0x44], eax */
        l_0x100d_6631:
            ii(0x100d_6631, 5); jmpd(0x100d_669a, 0x64); goto l_0x100d_669a; /* jmp 0x100d669a */
        l_0x100d_6636:
            ii(0x100d_6636, 4); movsx(eax, memw_a32[ss, ebp - 0x4c]);   /* movsx eax, word [ebp-0x4c] */
            ii(0x100d_663a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_663c, 2); if(jld(0x100d_6647, 0x9)) goto l_0x100d_6647; /* jl 0x100d6647 */
            ii(0x100d_663e, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x100d_6641, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x100d_6645, 2); if(jld(0x100d_6649, 0x2)) goto l_0x100d_6649; /* jl 0x100d6649 */
        l_0x100d_6647:
            ii(0x100d_6647, 2); jmpd(0x100d_6651, 0x8); goto l_0x100d_6651; /* jmp 0x100d6651 */
        l_0x100d_6649:
            ii(0x100d_6649, 4); movsx(eax, memw_a32[ss, ebp - 0x50]);   /* movsx eax, word [ebp-0x50] */
            ii(0x100d_664d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_664f, 2); if(jged(0x100d_6653, 0x2)) goto l_0x100d_6653; /* jge 0x100d6653 */
        l_0x100d_6651:
            ii(0x100d_6651, 2); jmpd(0x100d_665c, 0x9); goto l_0x100d_665c; /* jmp 0x100d665c */
        l_0x100d_6653:
            ii(0x100d_6653, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x100d_6656, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x100d_665a, 2); if(jld(0x100d_665e, 0x2)) goto l_0x100d_665e; /* jl 0x100d665e */
        l_0x100d_665c:
            ii(0x100d_665c, 2); jmpd(0x100d_6666, 0x8); goto l_0x100d_6666; /* jmp 0x100d6666 */
        l_0x100d_665e:
            ii(0x100d_665e, 3); mov(al, memb_a32[ss, ebp + 0x1c]);      /* mov al, [ebp+0x1c] */
            ii(0x100d_6661, 3); mov(edx, memd_a32[ss, ebp - 0x44]);     /* mov edx, [ebp-0x44] */
            ii(0x100d_6664, 2); mov(memb_a32[ds, edx], al);             /* mov [edx], al */
        l_0x100d_6666:
            ii(0x100d_6666, 4); movsx(eax, memw_a32[ss, ebp - 0x64]);   /* movsx eax, word [ebp-0x64] */
            ii(0x100d_666a, 3); add(memd_a32[ss, ebp - 0x44], eax);     /* add [ebp-0x44], eax */
            ii(0x100d_666d, 3); mov(eax, memd_a32[ss, ebp - 0x74]);     /* mov eax, [ebp-0x74] */
            ii(0x100d_6670, 3); add(memd_a32[ss, ebp - 0x4c], eax);     /* add [ebp-0x4c], eax */
            ii(0x100d_6673, 3); mov(eax, memd_a32[ss, ebp - 0x78]);     /* mov eax, [ebp-0x78] */
            ii(0x100d_6676, 3); add(memd_a32[ss, ebp - 0x50], eax);     /* add [ebp-0x50], eax */
            ii(0x100d_6679, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100d_667c, 3); inc(memd_a32[ss, ebp - 0x34]);          /* inc dword [ebp-0x34] */
            ii(0x100d_667f, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100d_6682, 3); cmp(memb_a32[ds, eax], 0);              /* cmp byte [eax], 0x0 */
            ii(0x100d_6685, 2); if(jzd(0x100d_669a, 0x13)) goto l_0x100d_669a; /* jz 0x100d669a */
            ii(0x100d_6687, 4); movsx(eax, memw_a32[ss, ebp - 0x68]);   /* movsx eax, word [ebp-0x68] */
            ii(0x100d_668b, 3); add(memd_a32[ss, ebp - 0x44], eax);     /* add [ebp-0x44], eax */
            ii(0x100d_668e, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x100d_6691, 3); add(memd_a32[ss, ebp - 0x4c], eax);     /* add [ebp-0x4c], eax */
            ii(0x100d_6694, 3); mov(eax, memd_a32[ss, ebp - 0x80]);     /* mov eax, [ebp-0x80] */
            ii(0x100d_6697, 3); add(memd_a32[ss, ebp - 0x50], eax);     /* add [ebp-0x50], eax */
        l_0x100d_669a:
            ii(0x100d_669a, 5); jmpd(0x100d_65f9, -0xa6); goto l_0x100d_65f9; /* jmp 0x100d65f9 */
        l_0x100d_669f:
            ii(0x100d_669f, 5); if(jmpd_func(0x100d_62d1, -0x3d3)) return; /* jmp 0x100d62d1 */
        }
    }
}
