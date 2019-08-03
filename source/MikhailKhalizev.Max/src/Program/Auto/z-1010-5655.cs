using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9492bbb3-a383-440d-afaa-331dd2896a66")]
        public void Method_1010_5655()
        {
            ii(0x1010_5655, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1010_565a, 5); calld(Definitions.sys_check_available_stack_size, 0x606f3); /* call 0x10165d52 */
            ii(0x1010_565f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_5660, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_5661, 1); pushd(esi);                             /* push esi */
            ii(0x1010_5662, 1); pushd(edi);                             /* push edi */
            ii(0x1010_5663, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_5664, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_5666, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1010_566c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_566f, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_5672, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1010_5676, 2); if(jled(0x1010_5681, 0x9)) goto l_0x1010_5681; /* jle 0x10105681 */
            ii(0x1010_5678, 7); cmp(memd_a32[ss, ebp - 0x4], 0x7000);   /* cmp dword [ebp-0x4], 0x7000 */
            ii(0x1010_567f, 2); if(jld(0x1010_5683, 0x2)) goto l_0x1010_5683; /* jl 0x10105683 */
        l_0x1010_5681:
            ii(0x1010_5681, 2); jmpd(0x1010_568d, 0xa); goto l_0x1010_568d; /* jmp 0x1010568d */
        l_0x1010_5683:
            ii(0x1010_5683, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5686, 7); mov(memb_a32[ds, eax + 0x461], 0);      /* mov byte [eax+0x461], 0x0 */
        l_0x1010_568d:
            ii(0x1010_568d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_5690, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_5693, 5); jmpd(0x1010_5830, 0x198); goto l_0x1010_5830; /* jmp 0x10105830 */
        l_0x1010_5698:
            ii(0x1010_5698, 5); calld(0x1011_6ba6, 0x11509);            /* call 0x10116ba6 */
            ii(0x1010_569d, 5); jmpd(0x1010_58e3, 0x241); goto l_0x1010_58e3; /* jmp 0x101058e3 */
        l_0x1010_56a2:
            ii(0x1010_56a2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_56a5, 4); mov(memb_a32[ds, eax + 0x32], 0x1);     /* mov byte [eax+0x32], 0x1 */
        l_0x1010_56a9:
            ii(0x1010_56a9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_56ac, 4); mov(memb_a32[ds, eax + 0x31], 0x1);     /* mov byte [eax+0x31], 0x1 */
            ii(0x1010_56b0, 5); jmpd(0x1010_58e3, 0x22e); goto l_0x1010_58e3; /* jmp 0x101058e3 */
        l_0x1010_56b5:
            ii(0x1010_56b5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_56b8, 7); xor(memb_a32[ds, eax + 0x470], 0x1);    /* xor byte [eax+0x470], 0x1 */
            ii(0x1010_56bf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_56c2, 3); mov(eax, memd_a32[ds, eax + 0x33]);     /* mov eax, [eax+0x33] */
            ii(0x1010_56c5, 5); calld(0x100c_fbbe, -0x35b0c);           /* call 0x100cfbbe */
            ii(0x1010_56ca, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_56cd, 9); mov(memw_a32[ds, eax + 0x46a], 0);      /* mov word [eax+0x46a], 0x0 */
            ii(0x1010_56d6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_56d9, 7); cmp(memb_a32[ds, eax + 0x470], 0);      /* cmp byte [eax+0x470], 0x0 */
            ii(0x1010_56e0, 2); if(jzd(0x1010_56f1, 0xf)) goto l_0x1010_56f1; /* jz 0x101056f1 */
            ii(0x1010_56e2, 5); mov(edx, 0x101a_32f5);                  /* mov edx, 0x101a32f5 */ /* "Enter: End Turn\n\nF: Find Selected Unit. Currently selected unit will be centered on screen.\n\n-,+: Zoom In, Out\n\nG: Turns on Grid Display\n\nF1: Centers on Tagged Unit\n\nArrow Keys: Scrolls the map\n\nALT-P: Pause the game\n\nALT-F: Opens the Load/Save Game Menu\n\nALT-L: Use to quick load a game\n\nALT-S: Use to quick save a game\n\nALT-X: Exits the Game to the Main Menu\n\nALT-F5, ALT-F6, ALT-F7, ALT-F8: Saves the current window position\n\nF5, F6, F7, F8: Jumps to a previously saved window position\n\n?: Initiates HELP mode.  The cursor changes to a question mark, clicking on screen items will display help text.\n\nALT-C: Saves a screen shot of the game in PCX format.\n\nShift: Hold the Shift key while selecting units to create groups.\n\nShift-Done: Holding the Shift key while clicking on the Done button will start in motion all units that are waiting to move along a path.\n\nHot keys for unit commands:\n\nPress 1 for these functions:\n...Activate\n...Allocate\n...Auto-Survey\n...Build\n...Buy Upgrade\n...Disable\n...Place Mines\n...Reload\n...Repair\n...Research\n\nPress 2 for these functions:\n...Load\n...Start\n...Steal\n\nPress 3 for these functions:\n...Attack\n...Transfer\n\nPress 4 for the Manual function.\n\nPress 5 for these functions:\n...Enter\n...Upgrade\n\nPress 6 for the Upgrade All function.\n\nPress 7 for the Stop function.\n\nPress 8 for the Sentry function.\n\nPress 9 for the Done function.\n\nPress 0 for the Remove function.\n" */
            ii(0x1010_56e7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_56ea, 5); calld(0x1010_53e9, -0x306);             /* call 0x101053e9 */
            ii(0x1010_56ef, 2); jmpd(0x1010_570d, 0x1c); goto l_0x1010_570d; /* jmp 0x1010570d */
        l_0x1010_56f1:
            ii(0x1010_56f1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_56f4, 3); mov(eax, memd_a32[ds, eax + 0x41]);     /* mov eax, [eax+0x41] */
            ii(0x1010_56f7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_56fa, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_56fd, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_5700, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_5702, 3); mov(edx, memd_a32[ds, edx + 0x47]);     /* mov edx, [edx+0x47] */
            ii(0x1010_5705, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5708, 5); calld(0x1010_53e9, -0x324);             /* call 0x101053e9 */
        l_0x1010_570d:
            ii(0x1010_570d, 5); jmpd(0x1010_58e3, 0x1d1); goto l_0x1010_58e3; /* jmp 0x101058e3 */
        l_0x1010_5712:
            ii(0x1010_5712, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5715, 6); mov(eax, memd_a32[ds, eax + 0x468]);    /* mov eax, [eax+0x468] */
            ii(0x1010_571b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_571e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_5720, 2); if(jzd(0x1010_5781, 0x5f)) goto l_0x1010_5781; /* jz 0x10105781 */
            ii(0x1010_5722, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5725, 7); mov(ax, memw_a32[ds, eax + 0x46a]);     /* mov ax, [eax+0x46a] */
            ii(0x1010_572c, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_572f, 7); sub(ax, memw_a32[ds, edx + 0x466]);     /* sub ax, [edx+0x466] */
            ii(0x1010_5736, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1010_5739, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1010_573d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_573f, 2); if(jged(0x1010_5748, 0x7)) goto l_0x1010_5748; /* jge 0x10105748 */
            ii(0x1010_5741, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
        l_0x1010_5748:
            ii(0x1010_5748, 5); calld(0x1014_82f4, 0x42ba7);            /* call 0x101482f4 */
            ii(0x1010_574d, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1010_5750, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5753, 7); dec(memw_a32[ds, eax + 0x46a]);         /* dec word [eax+0x46a] */
            ii(0x1010_575a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_575d, 5); calld(0x1010_5281, -0x4e1);             /* call 0x10105281 */
        l_0x1010_5762:
            ii(0x1010_5762, 5); calld(0x1014_82f4, 0x42b8d);            /* call 0x101482f4 */
            ii(0x1010_5767, 3); sub(eax, memd_a32[ss, ebp - 0x18]);     /* sub eax, [ebp-0x18] */
            ii(0x1010_576a, 5); cmp(eax, 0x308c);                       /* cmp eax, 0x308c */
            ii(0x1010_576f, 2); if(jbd(0x1010_5762, -0xf)) goto l_0x1010_5762; /* jb 0x10105762 */
            ii(0x1010_5771, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5774, 7); mov(ax, memw_a32[ds, eax + 0x46a]);     /* mov ax, [eax+0x46a] */
            ii(0x1010_577b, 4); cmp(ax, memw_a32[ss, ebp - 0x14]);      /* cmp ax, [ebp-0x14] */
            ii(0x1010_577f, 2); if(jnzd(0x1010_5748, -0x39)) goto l_0x1010_5748; /* jnz 0x10105748 */
        l_0x1010_5781:
            ii(0x1010_5781, 5); jmpd(0x1010_58e3, 0x15d); goto l_0x1010_58e3; /* jmp 0x101058e3 */
        l_0x1010_5786:
            ii(0x1010_5786, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5789, 6); mov(edx, memd_a32[ds, eax + 0x468]);    /* mov edx, [eax+0x468] */
            ii(0x1010_578f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_5792, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5795, 6); mov(eax, memd_a32[ds, eax + 0x464]);    /* mov eax, [eax+0x464] */
            ii(0x1010_579b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_579e, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_57a0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_57a3, 6); mov(eax, memd_a32[ds, eax + 0x466]);    /* mov eax, [eax+0x466] */
            ii(0x1010_57a9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_57ac, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1010_57ae, 2); if(jged(0x1010_5800, 0x50)) goto l_0x1010_5800; /* jge 0x10105800 */
            ii(0x1010_57b0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_57b3, 7); mov(ax, memw_a32[ds, eax + 0x46a]);     /* mov ax, [eax+0x46a] */
            ii(0x1010_57ba, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_57bd, 7); add(ax, memw_a32[ds, edx + 0x466]);     /* add ax, [edx+0x466] */
            ii(0x1010_57c4, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x1010_57c7:
            ii(0x1010_57c7, 5); calld(0x1014_82f4, 0x42b28);            /* call 0x101482f4 */
            ii(0x1010_57cc, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1010_57cf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_57d2, 7); inc(memw_a32[ds, eax + 0x46a]);         /* inc word [eax+0x46a] */
            ii(0x1010_57d9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_57dc, 5); calld(0x1010_5281, -0x560);             /* call 0x10105281 */
        l_0x1010_57e1:
            ii(0x1010_57e1, 5); calld(0x1014_82f4, 0x42b0e);            /* call 0x101482f4 */
            ii(0x1010_57e6, 3); sub(eax, memd_a32[ss, ebp - 0x20]);     /* sub eax, [ebp-0x20] */
            ii(0x1010_57e9, 5); cmp(eax, 0x308c);                       /* cmp eax, 0x308c */
            ii(0x1010_57ee, 2); if(jbd(0x1010_57e1, -0xf)) goto l_0x1010_57e1; /* jb 0x101057e1 */
            ii(0x1010_57f0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_57f3, 7); mov(ax, memw_a32[ds, eax + 0x46a]);     /* mov ax, [eax+0x46a] */
            ii(0x1010_57fa, 4); cmp(ax, memw_a32[ss, ebp - 0x1c]);      /* cmp ax, [ebp-0x1c] */
            ii(0x1010_57fe, 2); if(jnzd(0x1010_57c7, -0x39)) goto l_0x1010_57c7; /* jnz 0x101057c7 */
        l_0x1010_5800:
            ii(0x1010_5800, 5); jmpd(0x1010_58e3, 0xde); goto l_0x1010_58e3; /* jmp 0x101058e3 */
        l_0x1010_5805:
            ii(0x1010_5805, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5808, 7); cmp(memb_a32[ds, eax + 0x461], 0);      /* cmp byte [eax+0x461], 0x0 */
            ii(0x1010_580f, 2); if(jnzd(0x1010_581c, 0xb)) goto l_0x1010_581c; /* jnz 0x1010581c */
            ii(0x1010_5811, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5814, 3); mov(eax, memd_a32[ds, eax + 0x33]);     /* mov eax, [eax+0x33] */
            ii(0x1010_5817, 5); calld(0x100c_fbbe, -0x35c5e);           /* call 0x100cfbbe */
        l_0x1010_581c:
            ii(0x1010_581c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_581f, 7); mov(memb_a32[ds, eax + 0x461], 0x1);    /* mov byte [eax+0x461], 0x1 */
            ii(0x1010_5826, 5); jmpd(0x1010_58e3, 0xb8); goto l_0x1010_58e3; /* jmp 0x101058e3 */
        l_0x1010_582b:
            ii(0x1010_582b, 5); jmpd(0x1010_58e3, 0xb3); goto l_0x1010_58e3; /* jmp 0x101058e3 */
        l_0x1010_5830:
            ii(0x1010_5830, 7); cmp(memd_a32[ss, ebp - 0x10], 0x149);   /* cmp dword [ebp-0x10], 0x149 */
            ii(0x1010_5837, 2); if(jbd(0x1010_589d, 0x64)) goto l_0x1010_589d; /* jb 0x1010589d */
            ii(0x1010_5839, 7); cmp(memd_a32[ss, ebp - 0x10], 0x149);   /* cmp dword [ebp-0x10], 0x149 */
            ii(0x1010_5840, 6); if(jbed(0x1010_5712, -0x134)) goto l_0x1010_5712; /* jbe 0x10105712 */
            ii(0x1010_5846, 7); cmp(memd_a32[ss, ebp - 0x10], 0x3e9);   /* cmp dword [ebp-0x10], 0x3e9 */
            ii(0x1010_584d, 2); if(jbd(0x1010_5876, 0x27)) goto l_0x1010_5876; /* jb 0x10105876 */
            ii(0x1010_584f, 7); cmp(memd_a32[ss, ebp - 0x10], 0x3e9);   /* cmp dword [ebp-0x10], 0x3e9 */
            ii(0x1010_5856, 6); if(jbed(0x1010_5712, -0x14a)) goto l_0x1010_5712; /* jbe 0x10105712 */
            ii(0x1010_585c, 7); cmp(memd_a32[ss, ebp - 0x10], 0x3ea);   /* cmp dword [ebp-0x10], 0x3ea */
            ii(0x1010_5863, 6); if(jbed(0x1010_5786, -0xe3)) goto l_0x1010_5786; /* jbe 0x10105786 */
            ii(0x1010_5869, 7); cmp(memd_a32[ss, ebp - 0x10], 0x7000);  /* cmp dword [ebp-0x10], 0x7000 */
            ii(0x1010_5870, 2); if(jzd(0x1010_5805, -0x6d)) goto l_0x1010_5805; /* jz 0x10105805 */
            ii(0x1010_5872, 2); jmpd(0x1010_582b, -0x49); goto l_0x1010_582b; /* jmp 0x1010582b */
        //  ii(0x1010_5874, 2); Недостижимый код.
l_0x1010_5876:
            ii(0x1010_5876, 7); cmp(memd_a32[ss, ebp - 0x10], 0x151);   /* cmp dword [ebp-0x10], 0x151 */
            ii(0x1010_587d, 2); if(jbd(0x1010_589b, 0x1c)) goto l_0x1010_589b; /* jb 0x1010589b */
            ii(0x1010_587f, 7); cmp(memd_a32[ss, ebp - 0x10], 0x151);   /* cmp dword [ebp-0x10], 0x151 */
            ii(0x1010_5886, 6); if(jbed(0x1010_5786, -0x106)) goto l_0x1010_5786; /* jbe 0x10105786 */
            ii(0x1010_588c, 7); cmp(memd_a32[ss, ebp - 0x10], 0x3e8);   /* cmp dword [ebp-0x10], 0x3e8 */
            ii(0x1010_5893, 6); if(jzd(0x1010_56b5, -0x1e4)) goto l_0x1010_56b5; /* jz 0x101056b5 */
            ii(0x1010_5899, 2); jmpd(0x1010_582b, -0x70); goto l_0x1010_582b; /* jmp 0x1010582b */
        l_0x1010_589b:
            ii(0x1010_589b, 2); jmpd(0x1010_582b, -0x72); goto l_0x1010_582b; /* jmp 0x1010582b */
        l_0x1010_589d:
            ii(0x1010_589d, 4); cmp(memd_a32[ss, ebp - 0x10], 0x1b);    /* cmp dword [ebp-0x10], 0x1b */
            ii(0x1010_58a1, 2); if(jbd(0x1010_58d4, 0x31)) goto l_0x1010_58d4; /* jb 0x101058d4 */
            ii(0x1010_58a3, 4); cmp(memd_a32[ss, ebp - 0x10], 0x1b);    /* cmp dword [ebp-0x10], 0x1b */
            ii(0x1010_58a7, 6); if(jbed(0x1010_56a9, -0x204)) goto l_0x1010_56a9; /* jbe 0x101056a9 */
            ii(0x1010_58ad, 4); cmp(memd_a32[ss, ebp - 0x10], 0x3f);    /* cmp dword [ebp-0x10], 0x3f */
            ii(0x1010_58b1, 2); if(jbd(0x1010_58cf, 0x1c)) goto l_0x1010_58cf; /* jb 0x101058cf */
            ii(0x1010_58b3, 4); cmp(memd_a32[ss, ebp - 0x10], 0x3f);    /* cmp dword [ebp-0x10], 0x3f */
            ii(0x1010_58b7, 6); if(jbed(0x1010_56a2, -0x21b)) goto l_0x1010_56a2; /* jbe 0x101056a2 */
            ii(0x1010_58bd, 7); cmp(memd_a32[ss, ebp - 0x10], 0x119);   /* cmp dword [ebp-0x10], 0x119 */
            ii(0x1010_58c4, 6); if(jzd(0x1010_5698, -0x232)) goto l_0x1010_5698; /* jz 0x10105698 */
            ii(0x1010_58ca, 5); jmpd(0x1010_582b, -0xa4); goto l_0x1010_582b; /* jmp 0x1010582b */
        l_0x1010_58cf:
            ii(0x1010_58cf, 5); jmpd(0x1010_582b, -0xa9); goto l_0x1010_582b; /* jmp 0x1010582b */
        l_0x1010_58d4:
            ii(0x1010_58d4, 4); cmp(memd_a32[ss, ebp - 0x10], 0xd);     /* cmp dword [ebp-0x10], 0xd */
            ii(0x1010_58d8, 6); if(jzd(0x1010_56a9, -0x235)) goto l_0x1010_56a9; /* jz 0x101056a9 */
            ii(0x1010_58de, 5); jmpd(0x1010_582b, -0xb8); goto l_0x1010_582b; /* jmp 0x1010582b */
        l_0x1010_58e3:
            ii(0x1010_58e3, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1010_58e7, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1010_58ea, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_58ec, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_58ed, 1); popd(edi);                              /* pop edi */
            ii(0x1010_58ee, 1); popd(esi);                              /* pop esi */
            ii(0x1010_58ef, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_58f0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_58f1, 1); retd(); return;                         /* ret */
        }
    }
}
