using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c4fe1fc3-4900-49ad-b24f-c10489c18c28")]
        public void Method_100e_b283()
        {
            ii(0x100e_b283, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100e_b288, 5); calld(Definitions.sys_check_available_stack_size, 0x7_aac5); /* call 0x10165d52 */
            ii(0x100e_b28d, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_b28e, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_b28f, 1); pushd(esi);                             /* push esi */
            ii(0x100e_b290, 1); pushd(edi);                             /* push edi */
            ii(0x100e_b291, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_b292, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_b294, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100e_b29a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_b29d, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_b2a0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b2a3, 4); cmp(memb_a32[ds, eax + 0x1a], 0);       /* cmp byte [eax+0x1a], 0x0 */
            ii(0x100e_b2a7, 2); if(jnzd(0x100e_b2b2, 0x9)) goto l_0x100e_b2b2; /* jnz 0x100eb2b2 */
            ii(0x100e_b2a9, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100e_b2ad, 5); jmpd(0x100e_b51d, 0x26b); goto l_0x100e_b51d; /* jmp 0x100eb51d */
        l_0x100e_b2b2:
            ii(0x100e_b2b2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b2b5, 3); mov(eax, memd_a32[ds, eax + 0x36]);     /* mov eax, [eax+0x36] */
            ii(0x100e_b2b8, 5); calld(0x1014_85ad, 0x5_d2f0);           /* call 0x101485ad */
            ii(0x100e_b2bd, 5); cmp(eax, 0x1f4);                        /* cmp eax, 0x1f4 */
            ii(0x100e_b2c2, 2); if(jbd(0x100e_b2f5, 0x31)) goto l_0x100e_b2f5; /* jb 0x100eb2f5 */
            ii(0x100e_b2c4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b2c7, 4); cmp(memb_a32[ds, eax + 0x2b], 0);       /* cmp byte [eax+0x2b], 0x0 */
            ii(0x100e_b2cb, 2); if(jnzd(0x100e_b2d3, 0x6)) goto l_0x100e_b2d3; /* jnz 0x100eb2d3 */
            ii(0x100e_b2cd, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x100e_b2d1, 2); jmpd(0x100e_b2d7, 0x4); goto l_0x100e_b2d7; /* jmp 0x100eb2d7 */
        l_0x100e_b2d3:
            ii(0x100e_b2d3, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
        l_0x100e_b2d7:
            ii(0x100e_b2d7, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x100e_b2da, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_b2dd, 3); mov(memb_a32[ds, edx + 0x2b], al);      /* mov [edx+0x2b], al */
            ii(0x100e_b2e0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b2e3, 5); calld(0x100e_b6bf, 0x3d7);              /* call 0x100eb6bf */
            ii(0x100e_b2e8, 5); calld(0x1014_82f4, 0x5_d007);           /* call 0x101482f4 */
            ii(0x100e_b2ed, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_b2ef, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b2f2, 3); mov(memd_a32[ds, eax + 0x36], edx);     /* mov [eax+0x36], edx */
        l_0x100e_b2f5:
            ii(0x100e_b2f5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b2f8, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100e_b2fb, 5); jmpd(0x100e_b424, 0x124); goto l_0x100e_b424; /* jmp 0x100eb424 */
        l_0x100e_b300:
            ii(0x100e_b300, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b303, 5); calld(0x100e_b84d, 0x545);              /* call 0x100eb84d */
            ii(0x100e_b308, 5); jmpd(0x100e_b519, 0x20c); goto l_0x100e_b519; /* jmp 0x100eb519 */
        l_0x100e_b30d:
            ii(0x100e_b30d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b310, 5); calld(0x100e_b92a, 0x615);              /* call 0x100eb92a */
            ii(0x100e_b315, 5); jmpd(0x100e_b519, 0x1ff); goto l_0x100e_b519; /* jmp 0x100eb519 */
        l_0x100e_b31a:
            ii(0x100e_b31a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b31d, 3); mov(edx, memd_a32[ds, eax + 0x23]);     /* mov edx, [eax+0x23] */
            ii(0x100e_b320, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b323, 3); mov(eax, memd_a32[ds, eax + 0x1f]);     /* mov eax, [eax+0x1f] */
            ii(0x100e_b326, 5); calld(Definitions.sys_strcpy, 0x7_aba4); /* call 0x10165ecf */
            ii(0x100e_b32b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b32e, 5); calld(0x100e_b226, -0x10d);             /* call 0x100eb226 */
            ii(0x100e_b333, 5); jmpd(0x100e_b519, 0x1e1); goto l_0x100e_b519; /* jmp 0x100eb519 */
        l_0x100e_b338:
            ii(0x100e_b338, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b33b, 5); calld(0x100e_b58f, 0x24f);              /* call 0x100eb58f */
            ii(0x100e_b340, 5); jmpd(0x100e_b519, 0x1d4); goto l_0x100e_b519; /* jmp 0x100eb519 */
        l_0x100e_b345:
            ii(0x100e_b345, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b348, 3); mov(edx, memd_a32[ds, eax + 0x1f]);     /* mov edx, [eax+0x1f] */
            ii(0x100e_b34b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b34e, 3); mov(eax, memd_a32[ds, eax + 0x23]);     /* mov eax, [eax+0x23] */
            ii(0x100e_b351, 5); calld(Definitions.sys_strcpy, 0x7_ab79); /* call 0x10165ecf */
            ii(0x100e_b356, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b359, 5); calld(0x100e_b226, -0x138);             /* call 0x100eb226 */
            ii(0x100e_b35e, 5); jmpd(0x100e_b519, 0x1b6); goto l_0x100e_b519; /* jmp 0x100eb519 */
        l_0x100e_b363:
            ii(0x100e_b363, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_b365, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b368, 5); calld(0x100e_b7c9, 0x45c);              /* call 0x100eb7c9 */
            ii(0x100e_b36d, 5); jmpd(0x100e_b519, 0x1a7); goto l_0x100e_b519; /* jmp 0x100eb519 */
        l_0x100e_b372:
            ii(0x100e_b372, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b375, 3); mov(eax, memd_a32[ds, eax + 0x23]);     /* mov eax, [eax+0x23] */
            ii(0x100e_b378, 5); calld(Definitions.sys_strlen, 0x8_6b4a); /* call 0x10171ec7 */
            ii(0x100e_b37d, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_b380, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b383, 5); calld(0x100e_b7c9, 0x441);              /* call 0x100eb7c9 */
            ii(0x100e_b388, 5); jmpd(0x100e_b519, 0x18c); goto l_0x100e_b519; /* jmp 0x100eb519 */
        l_0x100e_b38d:
            ii(0x100e_b38d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b390, 4); mov(ax, memw_a32[ds, eax + 0x2c]);      /* mov ax, [eax+0x2c] */
            ii(0x100e_b394, 1); dec(eax);                               /* dec eax */
            ii(0x100e_b395, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_b398, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b39b, 5); calld(0x100e_b7c9, 0x429);              /* call 0x100eb7c9 */
            ii(0x100e_b3a0, 5); jmpd(0x100e_b519, 0x174); goto l_0x100e_b519; /* jmp 0x100eb519 */
        l_0x100e_b3a5:
            ii(0x100e_b3a5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b3a8, 4); mov(ax, memw_a32[ds, eax + 0x2c]);      /* mov ax, [eax+0x2c] */
            ii(0x100e_b3ac, 1); inc(eax);                               /* inc eax */
            ii(0x100e_b3ad, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_b3b0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b3b3, 5); calld(0x100e_b7c9, 0x411);              /* call 0x100eb7c9 */
            ii(0x100e_b3b8, 5); jmpd(0x100e_b519, 0x15c); goto l_0x100e_b519; /* jmp 0x100eb519 */
        l_0x100e_b3bd:
            ii(0x100e_b3bd, 5); jmpd(0x100e_b519, 0x157); goto l_0x100e_b519; /* jmp 0x100eb519 */
        l_0x100e_b3c2:
            ii(0x100e_b3c2, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100e_b3c6, 2); if(jged(0x100e_b3d1, 0x9)) goto l_0x100e_b3d1; /* jge 0x100eb3d1 */
            ii(0x100e_b3c8, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100e_b3cc, 5); jmpd(0x100e_b51d, 0x14c); goto l_0x100e_b51d; /* jmp 0x100eb51d */
        l_0x100e_b3d1:
            ii(0x100e_b3d1, 7); cmp(memd_a32[ss, ebp - 0x4], 0x80);     /* cmp dword [ebp-0x4], 0x80 */
            ii(0x100e_b3d8, 2); if(jld(0x100e_b3e3, 0x9)) goto l_0x100e_b3e3; /* jl 0x100eb3e3 */
            ii(0x100e_b3da, 7); cmp(memd_a32[ss, ebp - 0x4], 0xff);     /* cmp dword [ebp-0x4], 0xff */
            ii(0x100e_b3e1, 2); if(jled(0x100e_b3e5, 0x2)) goto l_0x100e_b3e5; /* jle 0x100eb3e5 */
        l_0x100e_b3e3:
            ii(0x100e_b3e3, 2); jmpd(0x100e_b3f6, 0x11); goto l_0x100e_b3f6; /* jmp 0x100eb3f6 */
        l_0x100e_b3e5:
            ii(0x100e_b3e5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b3e8, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100e_b3ea, 6); mov(eax, memd_a32[ds, eax + 0x101b_845e]); /* mov eax, [eax+0x101b845e] */
            ii(0x100e_b3f0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_b3f3, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
        l_0x100e_b3f6:
            ii(0x100e_b3f6, 4); cmp(memd_a32[ss, ebp - 0x4], 0x20);     /* cmp dword [ebp-0x4], 0x20 */
            ii(0x100e_b3fa, 2); if(jld(0x100e_b405, 0x9)) goto l_0x100e_b405; /* jl 0x100eb405 */
            ii(0x100e_b3fc, 7); cmp(memd_a32[ss, ebp - 0x4], 0xff);     /* cmp dword [ebp-0x4], 0xff */
            ii(0x100e_b403, 2); if(jled(0x100e_b407, 0x2)) goto l_0x100e_b407; /* jle 0x100eb407 */
        l_0x100e_b405:
            ii(0x100e_b405, 2); jmpd(0x100e_b41b, 0x14); goto l_0x100e_b41b; /* jmp 0x100eb41b */
        l_0x100e_b407:
            ii(0x100e_b407, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100e_b40a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b40d, 5); calld(0x100e_b97d, 0x56b);              /* call 0x100eb97d */
            ii(0x100e_b412, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_b416, 5); jmpd(0x100e_b51d, 0x102); goto l_0x100e_b51d; /* jmp 0x100eb51d */
        l_0x100e_b41b:
            ii(0x100e_b41b, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100e_b41f, 5); jmpd(0x100e_b51d, 0xf9); goto l_0x100e_b51d; /* jmp 0x100eb51d */
        l_0x100e_b424:
            ii(0x100e_b424, 7); cmp(memd_a32[ss, ebp - 0x14], 0x149);   /* cmp dword [ebp-0x14], 0x149 */
            ii(0x100e_b42b, 6); if(jbd(0x100e_b4bb, 0x8a)) goto l_0x100e_b4bb; /* jb 0x100eb4bb */
            ii(0x100e_b431, 7); cmp(memd_a32[ss, ebp - 0x14], 0x149);   /* cmp dword [ebp-0x14], 0x149 */
            ii(0x100e_b438, 6); if(jbed(0x100e_b363, -0xdb)) goto l_0x100e_b363; /* jbe 0x100eb363 */
            ii(0x100e_b43e, 7); cmp(memd_a32[ss, ebp - 0x14], 0x150);   /* cmp dword [ebp-0x14], 0x150 */
            ii(0x100e_b445, 2); if(jbd(0x100e_b481, 0x3a)) goto l_0x100e_b481; /* jb 0x100eb481 */
            ii(0x100e_b447, 7); cmp(memd_a32[ss, ebp - 0x14], 0x150);   /* cmp dword [ebp-0x14], 0x150 */
            ii(0x100e_b44e, 6); if(jbed(0x100e_b3a5, -0xaf)) goto l_0x100e_b3a5; /* jbe 0x100eb3a5 */
            ii(0x100e_b454, 7); cmp(memd_a32[ss, ebp - 0x14], 0x152);   /* cmp dword [ebp-0x14], 0x152 */
            ii(0x100e_b45b, 2); if(jbd(0x100e_b47c, 0x1f)) goto l_0x100e_b47c; /* jb 0x100eb47c */
            ii(0x100e_b45d, 7); cmp(memd_a32[ss, ebp - 0x14], 0x152);   /* cmp dword [ebp-0x14], 0x152 */
            ii(0x100e_b464, 6); if(jbed(0x100e_b3bd, -0xad)) goto l_0x100e_b3bd; /* jbe 0x100eb3bd */
            ii(0x100e_b46a, 7); cmp(memd_a32[ss, ebp - 0x14], 0x153);   /* cmp dword [ebp-0x14], 0x153 */
            ii(0x100e_b471, 6); if(jzd(0x100e_b300, -0x177)) goto l_0x100e_b300; /* jz 0x100eb300 */
            ii(0x100e_b477, 5); jmpd(0x100e_b3c2, -0xba); goto l_0x100e_b3c2; /* jmp 0x100eb3c2 */
        l_0x100e_b47c:
            ii(0x100e_b47c, 5); jmpd(0x100e_b372, -0x10f); goto l_0x100e_b372; /* jmp 0x100eb372 */
        l_0x100e_b481:
            ii(0x100e_b481, 7); cmp(memd_a32[ss, ebp - 0x14], 0x14d);   /* cmp dword [ebp-0x14], 0x14d */
            ii(0x100e_b488, 2); if(jbd(0x100e_b4a9, 0x1f)) goto l_0x100e_b4a9; /* jb 0x100eb4a9 */
            ii(0x100e_b48a, 7); cmp(memd_a32[ss, ebp - 0x14], 0x14d);   /* cmp dword [ebp-0x14], 0x14d */
            ii(0x100e_b491, 6); if(jbed(0x100e_b3a5, -0xf2)) goto l_0x100e_b3a5; /* jbe 0x100eb3a5 */
            ii(0x100e_b497, 7); cmp(memd_a32[ss, ebp - 0x14], 0x14f);   /* cmp dword [ebp-0x14], 0x14f */
            ii(0x100e_b49e, 6); if(jzd(0x100e_b372, -0x132)) goto l_0x100e_b372; /* jz 0x100eb372 */
            ii(0x100e_b4a4, 5); jmpd(0x100e_b3c2, -0xe7); goto l_0x100e_b3c2; /* jmp 0x100eb3c2 */
        l_0x100e_b4a9:
            ii(0x100e_b4a9, 7); cmp(memd_a32[ss, ebp - 0x14], 0x14b);   /* cmp dword [ebp-0x14], 0x14b */
            ii(0x100e_b4b0, 6); if(jzd(0x100e_b38d, -0x129)) goto l_0x100e_b38d; /* jz 0x100eb38d */
            ii(0x100e_b4b6, 5); jmpd(0x100e_b3c2, -0xf9); goto l_0x100e_b3c2; /* jmp 0x100eb3c2 */
        l_0x100e_b4bb:
            ii(0x100e_b4bb, 4); cmp(memd_a32[ss, ebp - 0x14], 0x18);    /* cmp dword [ebp-0x14], 0x18 */
            ii(0x100e_b4bf, 2); if(jbd(0x100e_b4f5, 0x34)) goto l_0x100e_b4f5; /* jb 0x100eb4f5 */
            ii(0x100e_b4c1, 4); cmp(memd_a32[ss, ebp - 0x14], 0x18);    /* cmp dword [ebp-0x14], 0x18 */
            ii(0x100e_b4c5, 6); if(jbed(0x100e_b338, -0x193)) goto l_0x100e_b338; /* jbe 0x100eb338 */
            ii(0x100e_b4cb, 7); cmp(memd_a32[ss, ebp - 0x14], 0x147);   /* cmp dword [ebp-0x14], 0x147 */
            ii(0x100e_b4d2, 2); if(jbd(0x100e_b4e6, 0x12)) goto l_0x100e_b4e6; /* jb 0x100eb4e6 */
            ii(0x100e_b4d4, 7); cmp(memd_a32[ss, ebp - 0x14], 0x147);   /* cmp dword [ebp-0x14], 0x147 */
            ii(0x100e_b4db, 6); if(jbed(0x100e_b363, -0x17e)) goto l_0x100e_b363; /* jbe 0x100eb363 */
            ii(0x100e_b4e1, 5); jmpd(0x100e_b38d, -0x159); goto l_0x100e_b38d; /* jmp 0x100eb38d */
        l_0x100e_b4e6:
            ii(0x100e_b4e6, 4); cmp(memd_a32[ss, ebp - 0x14], 0x1b);    /* cmp dword [ebp-0x14], 0x1b */
            ii(0x100e_b4ea, 6); if(jzd(0x100e_b345, -0x1ab)) goto l_0x100e_b345; /* jz 0x100eb345 */
            ii(0x100e_b4f0, 5); jmpd(0x100e_b3c2, -0x133); goto l_0x100e_b3c2; /* jmp 0x100eb3c2 */
        l_0x100e_b4f5:
            ii(0x100e_b4f5, 4); cmp(memd_a32[ss, ebp - 0x14], 0x8);     /* cmp dword [ebp-0x14], 0x8 */
            ii(0x100e_b4f9, 2); if(jbd(0x100e_b514, 0x19)) goto l_0x100e_b514; /* jb 0x100eb514 */
            ii(0x100e_b4fb, 4); cmp(memd_a32[ss, ebp - 0x14], 0x8);     /* cmp dword [ebp-0x14], 0x8 */
            ii(0x100e_b4ff, 6); if(jbed(0x100e_b30d, -0x1f8)) goto l_0x100e_b30d; /* jbe 0x100eb30d */
            ii(0x100e_b505, 4); cmp(memd_a32[ss, ebp - 0x14], 0xd);     /* cmp dword [ebp-0x14], 0xd */
            ii(0x100e_b509, 6); if(jzd(0x100e_b31a, -0x1f5)) goto l_0x100e_b31a; /* jz 0x100eb31a */
            ii(0x100e_b50f, 5); jmpd(0x100e_b3c2, -0x152); goto l_0x100e_b3c2; /* jmp 0x100eb3c2 */
        l_0x100e_b514:
            ii(0x100e_b514, 5); jmpd(0x100e_b3c2, -0x157); goto l_0x100e_b3c2; /* jmp 0x100eb3c2 */
        l_0x100e_b519:
            ii(0x100e_b519, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
        l_0x100e_b51d:
            ii(0x100e_b51d, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100e_b520, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_b522, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_b523, 1); popd(edi);                              /* pop edi */
            ii(0x100e_b524, 1); popd(esi);                              /* pop esi */
            ii(0x100e_b525, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_b526, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_b527, 1); retd(); return;                         /* ret */
        }
    }
}
