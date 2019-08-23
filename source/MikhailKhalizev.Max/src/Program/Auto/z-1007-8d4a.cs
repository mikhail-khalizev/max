using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_8d4a-d295e8a7")]
        public void Method_1007_8d4a()
        {
            ii(0x1007_8d4a, 5); push(0xc0);                             /* push 0xc0 */
            ii(0x1007_8d4f, 5); call(Definitions.sys_check_available_stack_size, 0xe_cffe); /* call 0x10165d52 */
            ii(0x1007_8d54, 1); push(ecx);                              /* push ecx */
            ii(0x1007_8d55, 1); push(esi);                              /* push esi */
            ii(0x1007_8d56, 1); push(edi);                              /* push edi */
            ii(0x1007_8d57, 1); push(ebp);                              /* push ebp */
            ii(0x1007_8d58, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_8d5a, 6); sub(esp, 0xa0);                         /* sub esp, 0xa0 */
            ii(0x1007_8d60, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1007_8d63, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1007_8d66, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1007_8d69, 4); or(memb[ss, ebp - 0x10], 0x1);          /* or byte [ebp-0x10], 0x1 */
            ii(0x1007_8d6d, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
            ii(0x1007_8d70, 5); call(0x1008_a330, 0x1_15bb);            /* call 0x1008a330 */
            ii(0x1007_8d75, 3); mov(memd[ss, ebp - 0x60], eax);         /* mov [ebp-0x60], eax */
            ii(0x1007_8d78, 4); and(memb[ss, ebp - 0x10], -0x2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x1007_8d7c, 3); lea(eax, memd[ss, ebp - 0x54]);         /* lea eax, [ebp-0x54] */
            ii(0x1007_8d7f, 5); call(Definitions.my_ctor_0x101b_4184, -0x2294); /* call 0x10076af0 */
            ii(0x1007_8d84, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_8d86, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1007_8d89, 3); mov(al, memb[ds, edx + 0x26]);          /* mov al, [edx+0x26] */
            ii(0x1007_8d8c, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x1007_8d8f, 4); mov(memb[ss, ebp - 0x18], 0x1);         /* mov byte [ebp-0x18], 0x1 */
            ii(0x1007_8d93, 4); cmp(memd[ss, ebp - 0xc], 0);            /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1007_8d97, 2); if(jz(0x1007_8da8, 0xf)) goto l_0x1007_8da8; /* jz 0x10078da8 */
            ii(0x1007_8d99, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_8d9c, 3); mov(al, memb[ds, eax + 0x50]);          /* mov al, [eax+0x50] */
            ii(0x1007_8d9f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_8da4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_8da6, 2); if(jnz(0x1007_8daa, 0x2)) goto l_0x1007_8daa; /* jnz 0x10078daa */
        l_0x1007_8da8:
            ii(0x1007_8da8, 2); jmp(0x1007_8db9, 0xf); goto l_0x1007_8db9; /* jmp 0x10078db9 */
        l_0x1007_8daa:
            ii(0x1007_8daa, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_8dad, 3); mov(al, memb[ds, eax + 0x4e]);          /* mov al, [eax+0x4e] */
            ii(0x1007_8db0, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_8db5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_8db7, 2); if(jnz(0x1007_8dbb, 0x2)) goto l_0x1007_8dbb; /* jnz 0x10078dbb */
        l_0x1007_8db9:
            ii(0x1007_8db9, 2); jmp(0x1007_8dca, 0xf); goto l_0x1007_8dca; /* jmp 0x10078dca */
        l_0x1007_8dbb:
            ii(0x1007_8dbb, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_8dbe, 3); mov(al, memb[ds, eax + 0x4d]);          /* mov al, [eax+0x4d] */
            ii(0x1007_8dc1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_8dc6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_8dc8, 2); if(jg(0x1007_8ddd, 0x13)) goto l_0x1007_8ddd; /* jg 0x10078ddd */
        l_0x1007_8dca:
            ii(0x1007_8dca, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x1007_8dce, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_8dd0, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
            ii(0x1007_8dd3, 5); call(0x1008_8e0c, 0x1_0034);            /* call 0x10088e0c */
            ii(0x1007_8dd8, 5); jmp(0x1007_9631, 0x854); goto l_0x1007_9631; /* jmp 0x10079631 */
        l_0x1007_8ddd:
            ii(0x1007_8ddd, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_8de0, 5); call(0x100a_2edb, 0x2_a0f6);            /* call 0x100a2edb */
            ii(0x1007_8de5, 2); test(al, al);                           /* test al, al */
            ii(0x1007_8de7, 2); if(jnz(0x1007_8dfc, 0x13)) goto l_0x1007_8dfc; /* jnz 0x10078dfc */
            ii(0x1007_8de9, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x1007_8ded, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_8def, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
            ii(0x1007_8df2, 5); call(0x1008_8e0c, 0x1_0015);            /* call 0x10088e0c */
            ii(0x1007_8df7, 5); jmp(0x1007_9631, 0x835); goto l_0x1007_9631; /* jmp 0x10079631 */
        l_0x1007_8dfc:
            ii(0x1007_8dfc, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_8dff, 5); call(0x1007_623c, -0x2bc8);             /* call 0x1007623c */
            ii(0x1007_8e04, 3); mov(memd[ss, ebp - 0x58], eax);         /* mov [ebp-0x58], eax */
            ii(0x1007_8e07, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_8e0a, 5); cmp(memw[ds, eax + 0x8], 0x42);         /* cmp word [eax+0x8], 0x42 */
            ii(0x1007_8e0f, 2); if(jnz(0x1007_8e1a, 0x9)) goto l_0x1007_8e1a; /* jnz 0x10078e1a */
            ii(0x1007_8e11, 7); mov(memd[ss, ebp - 0x38], 0x1);         /* mov dword [ebp-0x38], 0x1 */
            ii(0x1007_8e18, 2); jmp(0x1007_8e24, 0xa); goto l_0x1007_8e24; /* jmp 0x10078e24 */
        l_0x1007_8e1a:
            ii(0x1007_8e1a, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x1007_8e1d, 4); mov(ax, memw[ds, eax + 0x12]);          /* mov ax, [eax+0x12] */
            ii(0x1007_8e21, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
        l_0x1007_8e24:
            ii(0x1007_8e24, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_8e26, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1007_8e29, 3); mov(al, memb[ds, edx + 0x4e]);          /* mov al, [edx+0x4e] */
            ii(0x1007_8e2c, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x1007_8e2f, 4); movsx(edx, memw[ss, ebp - 0x30]);       /* movsx edx, word [ebp-0x30] */
            ii(0x1007_8e33, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1007_8e36, 2); if(jge(0x1007_8e4b, 0x13)) goto l_0x1007_8e4b; /* jge 0x10078e4b */
            ii(0x1007_8e38, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x1007_8e3c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_8e3e, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
            ii(0x1007_8e41, 5); call(0x1008_8e0c, 0xffc6);              /* call 0x10088e0c */
            ii(0x1007_8e46, 5); jmp(0x1007_9631, 0x7e6); goto l_0x1007_9631; /* jmp 0x10079631 */
        l_0x1007_8e4b:
            ii(0x1007_8e4b, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x1007_8e4e, 4); cmp(memb[ds, eax + 0x16], 0);           /* cmp byte [eax+0x16], 0x0 */
            ii(0x1007_8e52, 2); if(jz(0x1007_8e63, 0xf)) goto l_0x1007_8e63; /* jz 0x10078e63 */
            ii(0x1007_8e54, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x1007_8e59, 5); call(0x1007_5fdc, -0x2e82);             /* call 0x10075fdc */
            ii(0x1007_8e5e, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1007_8e61, 2); if(jge(0x1007_8e67, 0x4)) goto l_0x1007_8e67; /* jge 0x10078e67 */
        l_0x1007_8e63:
            ii(0x1007_8e63, 4); mov(memb[ss, ebp - 0x18], 0x2);         /* mov byte [ebp-0x18], 0x2 */
        l_0x1007_8e67:
            ii(0x1007_8e67, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1007_8e6c, 1); push(eax);                              /* push eax */
            ii(0x1007_8e6d, 4); movsx(ecx, memb[ss, ebp - 0x18]);       /* movsx ecx, byte [ebp-0x18] */
            ii(0x1007_8e71, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x1007_8e74, 4); mov(ax, memw[ds, eax + 0x17]);          /* mov ax, [eax+0x17] */
            ii(0x1007_8e78, 3); add(eax, memd[ss, ebp - 0x30]);         /* add eax, [ebp-0x30] */
            ii(0x1007_8e7b, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1007_8e7e, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x1007_8e81, 3); add(eax, memd[ss, ebp - 0x30]);         /* add eax, [ebp-0x30] */
            ii(0x1007_8e84, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_8e87, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_8e8a, 5); call(0x1007_8266, -0xc29);              /* call 0x10078266 */
            ii(0x1007_8e8f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_8e91, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
            ii(0x1007_8e94, 5); call(0x1008_a2b4, 0x1_141b);            /* call 0x1008a2b4 */
            ii(0x1007_8e99, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_8e9b, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
            ii(0x1007_8e9e, 5); call(0x1013_ad11, 0xc_1e6e);            /* call 0x1013ad11 */
            ii(0x1007_8ea3, 2); test(al, al);                           /* test al, al */
            ii(0x1007_8ea5, 2); if(jz(0x1007_8eba, 0x13)) goto l_0x1007_8eba; /* jz 0x10078eba */
            ii(0x1007_8ea7, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x1007_8eab, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_8ead, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
            ii(0x1007_8eb0, 5); call(0x1008_8e0c, 0xff57);              /* call 0x10088e0c */
            ii(0x1007_8eb5, 5); jmp(0x1007_9631, 0x777); goto l_0x1007_9631; /* jmp 0x10079631 */
        l_0x1007_8eba:
            ii(0x1007_8eba, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
            ii(0x1007_8ebd, 5); call(0x1008_a228, 0x1_1366);            /* call 0x1008a228 */
            ii(0x1007_8ec2, 5); call(0x1008_a370, 0x1_14a9);            /* call 0x1008a370 */
            ii(0x1007_8ec7, 3); mov(memd[ss, ebp - 0x5c], eax);         /* mov [ebp-0x5c], eax */
            ii(0x1007_8eca, 3); mov(edx, memd[ss, ebp - 0x5c]);         /* mov edx, [ebp-0x5c] */
            ii(0x1007_8ecd, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_8ed0, 5); call(0x1007_0d01, -0x81d4);             /* call 0x10070d01 */
            ii(0x1007_8ed5, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1007_8ed8, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_8edb, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1007_8ede, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1007_8ee0, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_8ee3, 3); mov(eax, memd[ss, ebp - 0x5c]);         /* mov eax, [ebp-0x5c] */
            ii(0x1007_8ee6, 5); call(0x1007_6074, -0x2e77);             /* call 0x10076074 */
            ii(0x1007_8eeb, 2); test(al, al);                           /* test al, al */
            ii(0x1007_8eed, 2); if(jnz(0x1007_8f04, 0x15)) goto l_0x1007_8f04; /* jnz 0x10078f04 */
            ii(0x1007_8eef, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x1007_8ef2, 3); mov(edx, memd[ds, eax + 0x15]);         /* mov edx, [eax+0x15] */
            ii(0x1007_8ef5, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_8ef8, 4); movsx(eax, memw[ss, ebp - 0x38]);       /* movsx eax, word [ebp-0x38] */
            ii(0x1007_8efc, 5); call(Definitions.my_min, 0x1_0883);     /* call 0x10089784 */
            ii(0x1007_8f01, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
        l_0x1007_8f04:
            ii(0x1007_8f04, 4); movsx(edx, memw[ss, ebp - 0x38]);       /* movsx edx, word [ebp-0x38] */
            ii(0x1007_8f08, 4); movsx(eax, memw[ss, ebp - 0x38]);       /* movsx eax, word [ebp-0x38] */
            ii(0x1007_8f0c, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1007_8f0f, 4); movsx(edx, memw[ss, ebp - 0x24]);       /* movsx edx, word [ebp-0x24] */
            ii(0x1007_8f13, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_8f15, 2); if(jle(0x1007_8f32, 0x1b)) goto l_0x1007_8f32; /* jle 0x10078f32 */
            ii(0x1007_8f17, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_8f1a, 5); cmp(memw[ds, eax + 0x8], 0x42);         /* cmp word [eax+0x8], 0x42 */
            ii(0x1007_8f1f, 2); if(jnz(0x1007_8f30, 0xf)) goto l_0x1007_8f30; /* jnz 0x10078f30 */
            ii(0x1007_8f21, 3); mov(edx, memd[ss, ebp - 0x5c]);         /* mov edx, [ebp-0x5c] */
            ii(0x1007_8f24, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_8f27, 5); call(0x1007_7c9d, -0x128f);             /* call 0x10077c9d */
            ii(0x1007_8f2c, 2); test(al, al);                           /* test al, al */
            ii(0x1007_8f2e, 2); if(jnz(0x1007_8f32, 0x2)) goto l_0x1007_8f32; /* jnz 0x10078f32 */
        l_0x1007_8f30:
            ii(0x1007_8f30, 2); jmp(0x1007_8f55, 0x23); goto l_0x1007_8f55; /* jmp 0x10078f55 */
        l_0x1007_8f32:
            ii(0x1007_8f32, 5); call(0x1008_9aac, 0x1_0b75);            /* call 0x10089aac */
            ii(0x1007_8f37, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_8f39, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1007_8f3b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_8f3e, 5); call(0x1007_8840, -0x703);              /* call 0x10078840 */
            ii(0x1007_8f43, 3); mov(memb[ss, ebp - 0x14], al);          /* mov [ebp-0x14], al */
            ii(0x1007_8f46, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_8f48, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
            ii(0x1007_8f4b, 5); call(0x1008_8e0c, 0xfebc);              /* call 0x10088e0c */
            ii(0x1007_8f50, 5); jmp(0x1007_9631, 0x6dc); goto l_0x1007_9631; /* jmp 0x10079631 */
        l_0x1007_8f55:
            ii(0x1007_8f55, 3); mov(eax, memd[ss, ebp - 0x5c]);         /* mov eax, [ebp-0x5c] */
            ii(0x1007_8f58, 4); cmp(memb[ds, eax + 0x3d], 0x1a);        /* cmp byte [eax+0x3d], 0x1a */
            ii(0x1007_8f5c, 2); if(jnz(0x1007_8f6d, 0xf)) goto l_0x1007_8f6d; /* jnz 0x10078f6d */
            ii(0x1007_8f5e, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x1007_8f63, 5); call(0x1007_5fdc, -0x2f8c);             /* call 0x10075fdc */
            ii(0x1007_8f68, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1007_8f6b, 2); if(jge(0x1007_8fb4, 0x47)) goto l_0x1007_8fb4; /* jge 0x10078fb4 */
        l_0x1007_8f6d:
            ii(0x1007_8f6d, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x1007_8f72, 4); movsx(ebx, memw[ss, ebp - 0x34]);       /* movsx ebx, word [ebp-0x34] */
            ii(0x1007_8f76, 5); mov(edx, 0x101c_81a8);                  /* mov edx, 0x101c81a8 */
            ii(0x1007_8f7b, 3); mov(eax, memd[ss, ebp - 0x5c]);         /* mov eax, [ebp-0x5c] */
            ii(0x1007_8f7e, 5); call(0x1007_7d8b, -0x11f8);             /* call 0x10077d8b */
            ii(0x1007_8f83, 2); test(al, al);                           /* test al, al */
            ii(0x1007_8f85, 2); if(jnz(0x1007_8fa1, 0x1a)) goto l_0x1007_8fa1; /* jnz 0x10078fa1 */
            ii(0x1007_8f87, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x1007_8f8c, 4); movsx(ebx, memw[ss, ebp - 0x34]);       /* movsx ebx, word [ebp-0x34] */
            ii(0x1007_8f90, 5); mov(edx, 0x101c_8184);                  /* mov edx, 0x101c8184 */
            ii(0x1007_8f95, 3); mov(eax, memd[ss, ebp - 0x5c]);         /* mov eax, [ebp-0x5c] */
            ii(0x1007_8f98, 5); call(0x1007_7d8b, -0x1212);             /* call 0x10077d8b */
            ii(0x1007_8f9d, 2); test(al, al);                           /* test al, al */
            ii(0x1007_8f9f, 2); if(jz(0x1007_8fb4, 0x13)) goto l_0x1007_8fb4; /* jz 0x10078fb4 */
        l_0x1007_8fa1:
            ii(0x1007_8fa1, 4); mov(memb[ss, ebp - 0x14], 0x1);         /* mov byte [ebp-0x14], 0x1 */
            ii(0x1007_8fa5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_8fa7, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
            ii(0x1007_8faa, 5); call(0x1008_8e0c, 0xfe5d);              /* call 0x10088e0c */
            ii(0x1007_8faf, 5); jmp(0x1007_9631, 0x67d); goto l_0x1007_9631; /* jmp 0x10079631 */
        l_0x1007_8fb4:
            ii(0x1007_8fb4, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x1007_8fb7, 4); cmp(memb[ds, eax + 0x16], 0);           /* cmp byte [eax+0x16], 0x0 */
            ii(0x1007_8fbb, 6); if(jnz(0x1007_9069, 0xa8)) goto l_0x1007_9069; /* jnz 0x10079069 */
            ii(0x1007_8fc1, 3); mov(eax, memd[ss, ebp - 0x5c]);         /* mov eax, [ebp-0x5c] */
            ii(0x1007_8fc4, 5); call(0x1015_2aa9, 0xd_9ae0);            /* call 0x10152aa9 */
            ii(0x1007_8fc9, 3); mov(edx, memd[ss, ebp - 0x30]);         /* mov edx, [ebp-0x30] */
            ii(0x1007_8fcc, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1007_8fce, 3); mov(memd[ss, ebp - 0x70], edx);         /* mov [ebp-0x70], edx */
            ii(0x1007_8fd1, 4); movsx(edx, memw[ss, ebp - 0x70]);       /* movsx edx, word [ebp-0x70] */
            ii(0x1007_8fd5, 4); movsx(eax, memw[ss, ebp - 0x70]);       /* movsx eax, word [ebp-0x70] */
            ii(0x1007_8fd9, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1007_8fdc, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1007_8fe0, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_8fe2, 2); if(jg(0x1007_8fed, 0x9)) goto l_0x1007_8fed; /* jg 0x10078fed */
            ii(0x1007_8fe4, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_8fe7, 4); cmp(memb[ds, eax + 0x50], 0);           /* cmp byte [eax+0x50], 0x0 */
            ii(0x1007_8feb, 2); if(jnz(0x1007_8fef, 0x2)) goto l_0x1007_8fef; /* jnz 0x10078fef */
        l_0x1007_8fed:
            ii(0x1007_8fed, 2); jmp(0x1007_900a, 0x1b); goto l_0x1007_900a; /* jmp 0x1007900a */
        l_0x1007_8fef:
            ii(0x1007_8fef, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_8ff2, 3); mov(edx, memd[ds, eax + 0x6]);          /* mov edx, [eax+0x6] */
            ii(0x1007_8ff5, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_8ff8, 3); mov(eax, memd[ss, ebp - 0x5c]);         /* mov eax, [ebp-0x5c] */
            ii(0x1007_8ffb, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1007_8ffe, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_9001, 5); call(0x1007_49d4, -0x4632);             /* call 0x100749d4 */
            ii(0x1007_9006, 2); test(al, al);                           /* test al, al */
            ii(0x1007_9008, 2); if(jnz(0x1007_900c, 0x2)) goto l_0x1007_900c; /* jnz 0x1007900c */
        l_0x1007_900a:
            ii(0x1007_900a, 2); jmp(0x1007_901b, 0xf); goto l_0x1007_901b; /* jmp 0x1007901b */
        l_0x1007_900c:
            ii(0x1007_900c, 3); mov(edx, memd[ss, ebp - 0x5c]);         /* mov edx, [ebp-0x5c] */
            ii(0x1007_900f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_9012, 5); call(0x1007_6f5d, -0x20ba);             /* call 0x10076f5d */
            ii(0x1007_9017, 2); test(al, al);                           /* test al, al */
            ii(0x1007_9019, 2); if(jz(0x1007_901d, 0x2)) goto l_0x1007_901d; /* jz 0x1007901d */
        l_0x1007_901b:
            ii(0x1007_901b, 2); jmp(0x1007_9069, 0x4c); goto l_0x1007_9069; /* jmp 0x10079069 */
        l_0x1007_901d:
            ii(0x1007_901d, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x1007_9020, 4); mov(ax, memw[ds, eax + 0x14]);          /* mov ax, [eax+0x14] */
            ii(0x1007_9024, 3); mov(memd[ss, ebp - 0x74], eax);         /* mov [ebp-0x74], eax */
            ii(0x1007_9027, 3); mov(edx, memd[ss, ebp - 0x58]);         /* mov edx, [ebp-0x58] */
            ii(0x1007_902a, 3); mov(edx, memd[ds, edx + 0xe]);          /* mov edx, [edx+0xe] */
            ii(0x1007_902d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_9030, 4); movsx(ebx, memw[ss, ebp - 0x74]);       /* movsx ebx, word [ebp-0x74] */
            ii(0x1007_9034, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_9036, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1007_9039, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1007_903b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_903d, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_9040, 3); mov(al, memb[ds, eax + 0x4e]);          /* mov al, [eax+0x4e] */
            ii(0x1007_9043, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_9048, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1007_904a, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x1007_904d, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1007_9051, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1007_9054, 2); if(jge(0x1007_9069, 0x13)) goto l_0x1007_9069; /* jge 0x10079069 */
            ii(0x1007_9056, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x1007_905a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_905c, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
            ii(0x1007_905f, 5); call(0x1008_8e0c, 0xfda8);              /* call 0x10088e0c */
            ii(0x1007_9064, 5); jmp(0x1007_9631, 0x5c8); goto l_0x1007_9631; /* jmp 0x10079631 */
        l_0x1007_9069:
            ii(0x1007_9069, 3); lea(eax, memd[ss, ebp - 0x50]);         /* lea eax, [ebp-0x50] */
            ii(0x1007_906c, 5); call(Definitions.my_ctor_0x101b_4184, -0x2581); /* call 0x10076af0 */
            ii(0x1007_9071, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_9073, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1007_9076, 3); mov(al, memb[ds, edx + 0x50]);          /* mov al, [edx+0x50] */
            ii(0x1007_9079, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1007_907c, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x1007_907f, 4); cmp(memb[ds, eax + 0x16], 0);           /* cmp byte [eax+0x16], 0x0 */
            ii(0x1007_9083, 2); if(jnz(0x1007_908c, 0x7)) goto l_0x1007_908c; /* jnz 0x1007908c */
            ii(0x1007_9085, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_9088, 4); mov(memb[ds, eax + 0x50], 0);           /* mov byte [eax+0x50], 0x0 */
        l_0x1007_908c:
            ii(0x1007_908c, 3); mov(edx, memd[ss, ebp - 0x5c]);         /* mov edx, [ebp-0x5c] */
            ii(0x1007_908f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_9092, 5); call(0x1007_78a5, -0x17f2);             /* call 0x100778a5 */
            ii(0x1007_9097, 2); test(al, al);                           /* test al, al */
            ii(0x1007_9099, 2); if(jz(0x1007_90b6, 0x1b)) goto l_0x1007_90b6; /* jz 0x100790b6 */
            ii(0x1007_909b, 4); movsx(eax, memb[ss, ebp - 0x18]);       /* movsx eax, byte [ebp-0x18] */
            ii(0x1007_909f, 1); push(eax);                              /* push eax */
            ii(0x1007_90a0, 3); lea(ecx, memd[ss, ebp - 0x28]);         /* lea ecx, [ebp-0x28] */
            ii(0x1007_90a3, 3); lea(ebx, memd[ss, ebp - 0x50]);         /* lea ebx, [ebp-0x50] */
            ii(0x1007_90a6, 3); mov(edx, memd[ss, ebp - 0x5c]);         /* mov edx, [ebp-0x5c] */
            ii(0x1007_90a9, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_90ac, 5); call(0x1007_70e1, -0x1fd0);             /* call 0x100770e1 */
            ii(0x1007_90b1, 3); mov(memb[ss, ebp - 0x1c], al);          /* mov [ebp-0x1c], al */
            ii(0x1007_90b4, 2); jmp(0x1007_90eb, 0x35); goto l_0x1007_90eb; /* jmp 0x100790eb */
        l_0x1007_90b6:
            ii(0x1007_90b6, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1007_90bb, 1); push(eax);                              /* push eax */
            ii(0x1007_90bc, 4); movsx(eax, memw[ss, ebp - 0x38]);       /* movsx eax, word [ebp-0x38] */
            ii(0x1007_90c0, 1); push(eax);                              /* push eax */
            ii(0x1007_90c1, 4); movsx(eax, memb[ss, ebp - 0x18]);       /* movsx eax, byte [ebp-0x18] */
            ii(0x1007_90c5, 1); push(eax);                              /* push eax */
            ii(0x1007_90c6, 3); lea(ecx, memd[ss, ebp - 0x28]);         /* lea ecx, [ebp-0x28] */
            ii(0x1007_90c9, 3); lea(ebx, memd[ss, ebp - 0x50]);         /* lea ebx, [ebp-0x50] */
            ii(0x1007_90cc, 3); lea(edx, memd[ss, ebp - 0x78]);         /* lea edx, [ebp-0x78] */
            ii(0x1007_90cf, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
            ii(0x1007_90d2, 5); call(0x1008_a228, 0x1_1151);            /* call 0x1008a228 */
            ii(0x1007_90d7, 5); call(0x100b_8e63, 0x3_fd87);            /* call 0x100b8e63 */
            ii(0x1007_90dc, 3); mov(esi, memd[ss, ebp - 0xc]);          /* mov esi, [ebp-0xc] */
            ii(0x1007_90df, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_90e1, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1007_90e3, 5); call(0x1007_7381, -0x1d67);             /* call 0x10077381 */
            ii(0x1007_90e8, 3); mov(memb[ss, ebp - 0x1c], al);          /* mov [ebp-0x1c], al */
        l_0x1007_90eb:
            ii(0x1007_90eb, 3); mov(al, memb[ss, ebp - 0x2c]);          /* mov al, [ebp-0x2c] */
            ii(0x1007_90ee, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1007_90f1, 3); mov(memb[ds, edx + 0x50], al);          /* mov [edx+0x50], al */
            ii(0x1007_90f4, 4); cmp(memb[ss, ebp - 0x1c], 0);           /* cmp byte [ebp-0x1c], 0x0 */
            ii(0x1007_90f8, 2); if(jnz(0x1007_9115, 0x1b)) goto l_0x1007_9115; /* jnz 0x10079115 */
            ii(0x1007_90fa, 3); mov(eax, memd[ss, ebp - 0x5c]);         /* mov eax, [ebp-0x5c] */
            ii(0x1007_90fd, 5); call(0x1007_87ff, -0x903);              /* call 0x100787ff */
            ii(0x1007_9102, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x1007_9106, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_9108, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
            ii(0x1007_910b, 5); call(0x1008_8e0c, 0xfcfc);              /* call 0x10088e0c */
            ii(0x1007_9110, 5); jmp(0x1007_9631, 0x51c); goto l_0x1007_9631; /* jmp 0x10079631 */
        l_0x1007_9115:
            ii(0x1007_9115, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_9118, 4); mov(ax, memw[ds, eax + 0x1c]);          /* mov ax, [eax+0x1c] */
            ii(0x1007_911c, 3); sub(eax, memd[ss, ebp - 0x4e]);         /* sub eax, [ebp-0x4e] */
            ii(0x1007_911f, 1); cwde();                                 /* cwde */
            ii(0x1007_9120, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1007_9123, 4); mov(dx, memw[ds, edx + 0x1a]);          /* mov dx, [edx+0x1a] */
            ii(0x1007_9127, 3); sub(edx, memd[ss, ebp - 0x50]);         /* sub edx, [ebp-0x50] */
            ii(0x1007_912a, 3); movsx(ebx, dx);                         /* movsx ebx, dx */
            ii(0x1007_912d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_912f, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_9131, 5); call(0x100a_5f65, 0x2_ce2f);            /* call 0x100a5f65 */
            ii(0x1007_9136, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_9139, 1); inc(edx);                               /* inc edx */
            ii(0x1007_913a, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_913c, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1007_913f, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1007_9141, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1007_9143, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1007_9146, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1007_9149, 3); mov(dl, memb[ds, edx + 0x4e]);          /* mov dl, [edx+0x4e] */
            ii(0x1007_914c, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1007_9152, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_9154, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1007_9157, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1007_9159, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1007_915b, 4); movsx(edx, memw[ss, ebp - 0x24]);       /* movsx edx, word [ebp-0x24] */
            ii(0x1007_915f, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_9161, 2); if(jle(0x1007_9169, 0x6)) goto l_0x1007_9169; /* jle 0x10079169 */
            ii(0x1007_9163, 4); cmp(memb[ss, ebp - 0x18], 0x2);         /* cmp byte [ebp-0x18], 0x2 */
            ii(0x1007_9167, 2); if(jl(0x1007_916b, 0x2)) goto l_0x1007_916b; /* jl 0x1007916b */
        l_0x1007_9169:
            ii(0x1007_9169, 2); jmp(0x1007_91a3, 0x38); goto l_0x1007_91a3; /* jmp 0x100791a3 */
        l_0x1007_916b:
            ii(0x1007_916b, 4); mov(memb[ss, ebp - 0x18], 0x2);         /* mov byte [ebp-0x18], 0x2 */
            ii(0x1007_916f, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1007_9174, 1); push(eax);                              /* push eax */
            ii(0x1007_9175, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x1007_917a, 3); lea(edx, memd[ss, ebp - 0x50]);         /* lea edx, [ebp-0x50] */
            ii(0x1007_917d, 3); lea(eax, memd[ss, ebp - 0x7c]);         /* lea eax, [ebp-0x7c] */
            ii(0x1007_9180, 5); call(0x1007_5e64, -0x3321);             /* call 0x10075e64 */
            ii(0x1007_9185, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1007_9187, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1007_918a, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1007_918e, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x1007_9194, 5); mov(esi, 0x101c_31c4);                  /* mov esi, 0x101c31c4 */
            ii(0x1007_9199, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1007_919b, 5); call(0x100c_20df, 0x4_8f3f);            /* call 0x100c20df */
            ii(0x1007_91a0, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
        l_0x1007_91a3:
            ii(0x1007_91a3, 3); mov(edx, memd[ss, ebp - 0x5c]);         /* mov edx, [ebp-0x5c] */
            ii(0x1007_91a6, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_91a9, 5); call(0x1007_8789, -0xa25);              /* call 0x10078789 */
            ii(0x1007_91ae, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1007_91b1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_91b4, 3); mov(al, memb[ds, eax + 0x4d]);          /* mov al, [eax+0x4d] */
            ii(0x1007_91b7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_91bc, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1007_91c0, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_91c2, 2); if(jl(0x1007_91ca, 0x6)) goto l_0x1007_91ca; /* jl 0x100791ca */
            ii(0x1007_91c4, 4); cmp(memb[ss, ebp - 0x18], 0x1);         /* cmp byte [ebp-0x18], 0x1 */
            ii(0x1007_91c8, 2); if(jnz(0x1007_91d2, 0x8)) goto l_0x1007_91d2; /* jnz 0x100791d2 */
        l_0x1007_91ca:
            ii(0x1007_91ca, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_91cd, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x1007_91d0, 2); jmp(0x1007_9206, 0x34); goto l_0x1007_9206; /* jmp 0x10079206 */
        l_0x1007_91d2:
            ii(0x1007_91d2, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1007_91d7, 1); push(eax);                              /* push eax */
            ii(0x1007_91d8, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1007_91dd, 3); lea(edx, memd[ss, ebp - 0x50]);         /* lea edx, [ebp-0x50] */
            ii(0x1007_91e0, 3); lea(eax, memd[ss, ebp - 0x80]);         /* lea eax, [ebp-0x80] */
            ii(0x1007_91e3, 5); call(0x1007_5e64, -0x3384);             /* call 0x10075e64 */
            ii(0x1007_91e8, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1007_91ea, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1007_91ed, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1007_91f1, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x1007_91f7, 5); mov(esi, 0x101c_31c4);                  /* mov esi, 0x101c31c4 */
            ii(0x1007_91fc, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1007_91fe, 5); call(0x100c_20df, 0x4_8edc);            /* call 0x100c20df */
            ii(0x1007_9203, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
        l_0x1007_9206:
            ii(0x1007_9206, 7); mov(memd[ss, ebp - 0x3c], 0);           /* mov dword [ebp-0x3c], 0x0 */
            ii(0x1007_920d, 6); mov(memw[ss, ebp - 0x2c], 0);           /* mov word [ebp-0x2c], 0x0 */
            ii(0x1007_9213, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_9216, 3); mov(al, memb[ds, eax + 0x4d]);          /* mov al, [eax+0x4d] */
            ii(0x1007_9219, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_921e, 4); movsx(edx, memw[ss, ebp - 0x40]);       /* movsx edx, word [ebp-0x40] */
            ii(0x1007_9222, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_9224, 2); if(jge(0x1007_9290, 0x6a)) goto l_0x1007_9290; /* jge 0x10079290 */
            ii(0x1007_9226, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x1007_9229, 4); cmp(memb[ds, eax + 0x16], 0);           /* cmp byte [eax+0x16], 0x0 */
            ii(0x1007_922d, 2); if(jz(0x1007_923d, 0xe)) goto l_0x1007_923d; /* jz 0x1007923d */
            ii(0x1007_922f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_9231, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1007_9234, 3); mov(al, memb[ds, edx + 0x50]);          /* mov al, [edx+0x50] */
            ii(0x1007_9237, 4); mov(memw[ss, ebp - 0x2c], ax);          /* mov [ebp-0x2c], ax */
            ii(0x1007_923b, 2); jmp(0x1007_9271, 0x34); goto l_0x1007_9271; /* jmp 0x10079271 */
        l_0x1007_923d:
            ii(0x1007_923d, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1007_9240, 3); mov(dl, memb[ds, edx + 0x4e]);          /* mov dl, [edx+0x4e] */
            ii(0x1007_9243, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1007_9249, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1007_924d, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1007_924f, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_9251, 3); mov(edx, memd[ss, ebp - 0x58]);         /* mov edx, [ebp-0x58] */
            ii(0x1007_9254, 3); mov(edx, memd[ds, edx + 0x12]);         /* mov edx, [edx+0x12] */
            ii(0x1007_9257, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_925a, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1007_925d, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x1007_9260, 3); mov(ebx, memd[ds, eax + 0xe]);          /* mov ebx, [eax+0xe] */
            ii(0x1007_9263, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1007_9266, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_9268, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1007_926b, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1007_926d, 4); mov(memw[ss, ebp - 0x2c], ax);          /* mov [ebp-0x2c], ax */
        l_0x1007_9271:
            ii(0x1007_9271, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_9274, 3); mov(al, memb[ds, eax + 0x50]);          /* mov al, [eax+0x50] */
            ii(0x1007_9277, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_927c, 4); movsx(edx, memw[ss, ebp - 0x2c]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x1007_9280, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_9282, 2); if(jle(0x1007_9290, 0xc)) goto l_0x1007_9290; /* jle 0x10079290 */
            ii(0x1007_9284, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_9286, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1007_9289, 3); mov(al, memb[ds, edx + 0x50]);          /* mov al, [edx+0x50] */
            ii(0x1007_928c, 4); mov(memw[ss, ebp - 0x2c], ax);          /* mov [ebp-0x2c], ax */
        l_0x1007_9290:
            ii(0x1007_9290, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1007_9293, 4); imul(eax, memd[ss, ebp - 0x20]);        /* imul eax, [ebp-0x20] */
            ii(0x1007_9297, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1007_929a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_929d, 3); mov(al, memb[ds, eax + 0x4d]);          /* mov al, [eax+0x4d] */
            ii(0x1007_92a0, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_92a5, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1007_92a9, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_92ab, 2); if(jge(0x1007_92b3, 0x6)) goto l_0x1007_92b3; /* jge 0x100792b3 */
            ii(0x1007_92ad, 4); cmp(memb[ss, ebp - 0x18], 0x1);         /* cmp byte [ebp-0x18], 0x1 */
            ii(0x1007_92b1, 2); if(jg(0x1007_92b5, 0x2)) goto l_0x1007_92b5; /* jg 0x100792b5 */
        l_0x1007_92b3:
            ii(0x1007_92b3, 2); jmp(0x1007_92da, 0x25); goto l_0x1007_92da; /* jmp 0x100792da */
        l_0x1007_92b5:
            ii(0x1007_92b5, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_92b8, 3); mov(al, memb[ds, eax + 0x54]);          /* mov al, [eax+0x54] */
            ii(0x1007_92bb, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_92c0, 4); movsx(edx, memw[ss, ebp - 0x2c]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x1007_92c4, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1007_92c6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_92c8, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x1007_92cb, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x1007_92ce, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_92d1, 5); call(Definitions.my_min, 0x1_04ae);     /* call 0x10089784 */
            ii(0x1007_92d6, 4); add(memw[ss, ebp - 0x2c], ax);          /* add [ebp-0x2c], ax */
        l_0x1007_92da:
            ii(0x1007_92da, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1007_92dd, 4); imul(eax, memd[ss, ebp - 0x2c]);        /* imul eax, [ebp-0x2c] */
            ii(0x1007_92e1, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1007_92e4, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_92e7, 4); cmp(ax, memw[ss, ebp - 0x20]);          /* cmp ax, [ebp-0x20] */
            ii(0x1007_92eb, 2); if(jg(0x1007_9304, 0x17)) goto l_0x1007_9304; /* jg 0x10079304 */
            ii(0x1007_92ed, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_92f0, 3); mov(al, memb[ds, eax + 0x4d]);          /* mov al, [eax+0x4d] */
            ii(0x1007_92f3, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_92f8, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1007_92fc, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_92fe, 6); if(jl(0x1007_9560, 0x25c)) goto l_0x1007_9560; /* jl 0x10079560 */
        l_0x1007_9304:
            ii(0x1007_9304, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x1007_9309, 5); call(0x1007_5fdc, -0x3332);             /* call 0x10075fdc */
            ii(0x1007_930e, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1007_9311, 2); if(jge(0x1007_9343, 0x30)) goto l_0x1007_9343; /* jge 0x10079343 */
            ii(0x1007_9313, 3); mov(eax, memd[ss, ebp - 0x5c]);         /* mov eax, [ebp-0x5c] */
            ii(0x1007_9316, 5); call(0x1007_87ff, -0xb1c);              /* call 0x100787ff */
            ii(0x1007_931b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_931e, 5); call(0x100a_9d1a, 0x3_09f7);            /* call 0x100a9d1a */
            ii(0x1007_9323, 3); movsx(ebx, al);                         /* movsx ebx, al */
            ii(0x1007_9326, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1007_9329, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_932c, 5); call(0x100a_346a, 0x2_a139);            /* call 0x100a346a */
            ii(0x1007_9331, 3); mov(memb[ss, ebp - 0x14], al);          /* mov [ebp-0x14], al */
            ii(0x1007_9334, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_9336, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
            ii(0x1007_9339, 5); call(0x1008_8e0c, 0xface);              /* call 0x10088e0c */
            ii(0x1007_933e, 5); jmp(0x1007_9631, 0x2ee); goto l_0x1007_9631; /* jmp 0x10079631 */
        l_0x1007_9343:
            ii(0x1007_9343, 3); mov(eax, memd[ss, ebp - 0x5c]);         /* mov eax, [ebp-0x5c] */
            ii(0x1007_9346, 5); call(0x1007_623c, -0x310f);             /* call 0x1007623c */
            ii(0x1007_934b, 4); mov(dx, memw[ds, eax + 0x8]);           /* mov dx, [eax+0x8] */
            ii(0x1007_934f, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x1007_9352, 4); cmp(dx, memw[ds, eax + 0x8]);           /* cmp dx, [eax+0x8] */
            ii(0x1007_9356, 2); if(jl(0x1007_936f, 0x17)) goto l_0x1007_936f; /* jl 0x1007936f */
            ii(0x1007_9358, 3); mov(eax, memd[ss, ebp - 0x5c]);         /* mov eax, [ebp-0x5c] */
            ii(0x1007_935b, 3); mov(al, memb[ds, eax + 0x4d]);          /* mov al, [eax+0x4d] */
            ii(0x1007_935e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_9363, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1007_9367, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_9369, 6); if(jge(0x1007_9443, 0xd4)) goto l_0x1007_9443; /* jge 0x10079443 */
        l_0x1007_936f:
            ii(0x1007_936f, 3); mov(edx, memd[ss, ebp - 0x5c]);         /* mov edx, [ebp-0x5c] */
            ii(0x1007_9372, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_9375, 5); call(0x1007_6f5d, -0x241d);             /* call 0x10076f5d */
            ii(0x1007_937a, 2); test(al, al);                           /* test al, al */
            ii(0x1007_937c, 6); if(jnz(0x1007_9443, 0xc1)) goto l_0x1007_9443; /* jnz 0x10079443 */
            ii(0x1007_9382, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_9384, 1); push(eax);                              /* push eax */
            ii(0x1007_9385, 4); movsx(ecx, memb[ss, ebp - 0x18]);       /* movsx ecx, byte [ebp-0x18] */
            ii(0x1007_9389, 4); movsx(ebx, memw[ss, ebp - 0x28]);       /* movsx ebx, word [ebp-0x28] */
            ii(0x1007_938d, 3); mov(edx, memd[ss, ebp - 0x5c]);         /* mov edx, [ebp-0x5c] */
            ii(0x1007_9390, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_9393, 5); call(0x1007_80c3, -0x12d5);             /* call 0x100780c3 */
            ii(0x1007_9398, 2); test(al, al);                           /* test al, al */
            ii(0x1007_939a, 6); if(jnz(0x1007_9443, 0xa3)) goto l_0x1007_9443; /* jnz 0x10079443 */
            ii(0x1007_93a0, 7); mov(memb[ss, ebp - 0x84], 0);           /* mov byte [ebp-0x84], 0x0 */
            ii(0x1007_93a7, 4); cmp(memb[ss, ebp - 0x18], 0x1);         /* cmp byte [ebp-0x18], 0x1 */
            ii(0x1007_93ab, 2); if(jnz(0x1007_940a, 0x5d)) goto l_0x1007_940a; /* jnz 0x1007940a */
            ii(0x1007_93ad, 4); mov(memb[ss, ebp - 0x18], 0x2);         /* mov byte [ebp-0x18], 0x2 */
            ii(0x1007_93b1, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1007_93b6, 1); push(eax);                              /* push eax */
            ii(0x1007_93b7, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x1007_93bc, 3); lea(edx, memd[ss, ebp - 0x50]);         /* lea edx, [ebp-0x50] */
            ii(0x1007_93bf, 6); lea(eax, memd[ss, ebp - 0x88]);         /* lea eax, [ebp-0x88] */
            ii(0x1007_93c5, 5); call(0x1007_5e64, -0x3566);             /* call 0x10075e64 */
            ii(0x1007_93ca, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1007_93cc, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1007_93cf, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1007_93d3, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x1007_93d9, 5); mov(esi, 0x101c_31c4);                  /* mov esi, 0x101c31c4 */
            ii(0x1007_93de, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1007_93e0, 5); call(0x100c_20df, 0x4_8cfa);            /* call 0x100c20df */
            ii(0x1007_93e5, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1007_93e8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_93ea, 1); push(eax);                              /* push eax */
            ii(0x1007_93eb, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x1007_93f0, 4); movsx(ebx, memw[ss, ebp - 0x28]);       /* movsx ebx, word [ebp-0x28] */
            ii(0x1007_93f4, 3); mov(edx, memd[ss, ebp - 0x5c]);         /* mov edx, [ebp-0x5c] */
            ii(0x1007_93f7, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_93fa, 5); call(0x1007_80c3, -0x133c);             /* call 0x100780c3 */
            ii(0x1007_93ff, 2); test(al, al);                           /* test al, al */
            ii(0x1007_9401, 2); if(jz(0x1007_940a, 0x7)) goto l_0x1007_940a; /* jz 0x1007940a */
            ii(0x1007_9403, 7); mov(memb[ss, ebp - 0x84], 0x1);         /* mov byte [ebp-0x84], 0x1 */
        l_0x1007_940a:
            ii(0x1007_940a, 7); cmp(memb[ss, ebp - 0x84], 0);           /* cmp byte [ebp-0x84], 0x0 */
            ii(0x1007_9411, 2); if(jnz(0x1007_9443, 0x30)) goto l_0x1007_9443; /* jnz 0x10079443 */
            ii(0x1007_9413, 3); mov(eax, memd[ss, ebp - 0x5c]);         /* mov eax, [ebp-0x5c] */
            ii(0x1007_9416, 5); call(0x1007_87ff, -0xc1c);              /* call 0x100787ff */
            ii(0x1007_941b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_941e, 5); call(0x100a_9d1a, 0x3_08f7);            /* call 0x100a9d1a */
            ii(0x1007_9423, 3); movsx(ebx, al);                         /* movsx ebx, al */
            ii(0x1007_9426, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1007_9429, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_942c, 5); call(0x100a_346a, 0x2_a039);            /* call 0x100a346a */
            ii(0x1007_9431, 3); mov(memb[ss, ebp - 0x14], al);          /* mov [ebp-0x14], al */
            ii(0x1007_9434, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_9436, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
            ii(0x1007_9439, 5); call(0x1008_8e0c, 0xf9ce);              /* call 0x10088e0c */
            ii(0x1007_943e, 5); jmp(0x1007_9631, 0x1ee); goto l_0x1007_9631; /* jmp 0x10079631 */
        l_0x1007_9443:
            ii(0x1007_9443, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_9446, 3); mov(al, memb[ds, eax + 0x4d]);          /* mov al, [eax+0x4d] */
            ii(0x1007_9449, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_944e, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1007_9452, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_9454, 6); if(jl(0x1007_9560, 0x106)) goto l_0x1007_9560; /* jl 0x10079560 */
            ii(0x1007_945a, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1007_945c, 4); movsx(ebx, memw[ss, ebp - 0x34]);       /* movsx ebx, word [ebp-0x34] */
            ii(0x1007_9460, 5); mov(edx, 0x101c_81a8);                  /* mov edx, 0x101c81a8 */
            ii(0x1007_9465, 3); mov(eax, memd[ss, ebp - 0x5c]);         /* mov eax, [ebp-0x5c] */
            ii(0x1007_9468, 5); call(0x1007_7d8b, -0x16e2);             /* call 0x10077d8b */
            ii(0x1007_946d, 2); test(al, al);                           /* test al, al */
            ii(0x1007_946f, 2); if(jnz(0x1007_9488, 0x17)) goto l_0x1007_9488; /* jnz 0x10079488 */
            ii(0x1007_9471, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1007_9473, 4); movsx(ebx, memw[ss, ebp - 0x34]);       /* movsx ebx, word [ebp-0x34] */
            ii(0x1007_9477, 5); mov(edx, 0x101c_8184);                  /* mov edx, 0x101c8184 */
            ii(0x1007_947c, 3); mov(eax, memd[ss, ebp - 0x5c]);         /* mov eax, [ebp-0x5c] */
            ii(0x1007_947f, 5); call(0x1007_7d8b, -0x16f9);             /* call 0x10077d8b */
            ii(0x1007_9484, 2); test(al, al);                           /* test al, al */
            ii(0x1007_9486, 2); if(jz(0x1007_949b, 0x13)) goto l_0x1007_949b; /* jz 0x1007949b */
        l_0x1007_9488:
            ii(0x1007_9488, 4); mov(memb[ss, ebp - 0x14], 0x1);         /* mov byte [ebp-0x14], 0x1 */
            ii(0x1007_948c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_948e, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
            ii(0x1007_9491, 5); call(0x1008_8e0c, 0xf976);              /* call 0x10088e0c */
            ii(0x1007_9496, 5); jmp(0x1007_9631, 0x196); goto l_0x1007_9631; /* jmp 0x10079631 */
        l_0x1007_949b:
            ii(0x1007_949b, 3); mov(eax, memd[ss, ebp - 0x5c]);         /* mov eax, [ebp-0x5c] */
            ii(0x1007_949e, 3); mov(al, memb[ds, eax + 0x4d]);          /* mov al, [eax+0x4d] */
            ii(0x1007_94a1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_94a6, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1007_94aa, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_94ac, 6); if(jge(0x1007_955c, 0xaa)) goto l_0x1007_955c; /* jge 0x1007955c */
            ii(0x1007_94b2, 5); mov(eax, 0x2d);                         /* mov eax, 0x2d */
            ii(0x1007_94b7, 5); call(Definitions.sys_new, 0xe_c944);    /* call 0x10165e00 */
            ii(0x1007_94bc, 6); mov(memd[ss, ebp - 0x8c], eax);         /* mov [ebp-0x8c], eax */
            ii(0x1007_94c2, 6); mov(eax, memd[ss, ebp - 0x8c]);         /* mov eax, [ebp-0x8c] */
            ii(0x1007_94c8, 6); mov(memd[ss, ebp - 0x90], eax);         /* mov [ebp-0x90], eax */
            ii(0x1007_94ce, 7); cmp(memd[ss, ebp - 0x90], 0);           /* cmp dword [ebp-0x90], 0x0 */
            ii(0x1007_94d5, 2); if(jz(0x1007_9508, 0x31)) goto l_0x1007_9508; /* jz 0x10079508 */
            ii(0x1007_94d7, 4); movsx(ecx, memb[ss, ebp - 0x18]);       /* movsx ecx, byte [ebp-0x18] */
            ii(0x1007_94db, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
            ii(0x1007_94de, 5); call(0x1008_a284, 0x1_0da1);            /* call 0x1008a284 */
            ii(0x1007_94e3, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1007_94e5, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x1007_94e9, 6); mov(eax, memd[ss, ebp - 0x8c]);         /* mov eax, [ebp-0x8c] */
            ii(0x1007_94ef, 5); call(0x1007_f279, 0x5d85);              /* call 0x1007f279 */
            ii(0x1007_94f4, 6); mov(memd[ss, ebp - 0x94], eax);         /* mov [ebp-0x94], eax */
            ii(0x1007_94fa, 6); mov(eax, memd[ss, ebp - 0x94]);         /* mov eax, [ebp-0x94] */
            ii(0x1007_9500, 6); mov(memd[ss, ebp - 0x98], eax);         /* mov [ebp-0x98], eax */
            ii(0x1007_9506, 2); jmp(0x1007_9514, 0xc); goto l_0x1007_9514; /* jmp 0x10079514 */
        l_0x1007_9508:
            ii(0x1007_9508, 6); mov(eax, memd[ss, ebp - 0x90]);         /* mov eax, [ebp-0x90] */
            ii(0x1007_950e, 6); mov(memd[ss, ebp - 0x98], eax);         /* mov [ebp-0x98], eax */
        l_0x1007_9514:
            ii(0x1007_9514, 6); mov(edx, memd[ss, ebp - 0x98]);         /* mov edx, [ebp-0x98] */
            ii(0x1007_951a, 6); lea(eax, memd[ss, ebp - 0x9c]);         /* lea eax, [ebp-0x9c] */
            ii(0x1007_9520, 5); call(0x1008_b060, 0x1_1b3b);            /* call 0x1008b060 */
            ii(0x1007_9525, 6); lea(eax, memd[ss, ebp - 0x9c]);         /* lea eax, [ebp-0x9c] */
            ii(0x1007_952b, 5); call(0x1008_af84, 0x1_1a54);            /* call 0x1008af84 */
            ii(0x1007_9530, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_9532, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1007_9537, 5); call(0x100a_4d50, 0x2_b814);            /* call 0x100a4d50 */
            ii(0x1007_953c, 4); mov(memb[ss, ebp - 0x14], 0x1);         /* mov byte [ebp-0x14], 0x1 */
            ii(0x1007_9540, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_9542, 6); lea(eax, memd[ss, ebp - 0x9c]);         /* lea eax, [ebp-0x9c] */
            ii(0x1007_9548, 5); call(0x1008_8b7c, 0xf62f);              /* call 0x10088b7c */
            ii(0x1007_954d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_954f, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
            ii(0x1007_9552, 5); call(0x1008_8e0c, 0xf8b5);              /* call 0x10088e0c */
            ii(0x1007_9557, 5); jmp(0x1007_9631, 0xd5); goto l_0x1007_9631; /* jmp 0x10079631 */
        l_0x1007_955c:
            ii(0x1007_955c, 4); mov(memb[ss, ebp - 0x18], 0);           /* mov byte [ebp-0x18], 0x0 */
        l_0x1007_9560:
            ii(0x1007_9560, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_9563, 5); call(0x1015_26ac, 0xd_9144);            /* call 0x101526ac */
            ii(0x1007_9568, 3); cmp(eax, memd[ss, ebp - 0x8]);          /* cmp eax, [ebp-0x8] */
            ii(0x1007_956b, 2); if(jz(0x1007_9578, 0xb)) goto l_0x1007_9578; /* jz 0x10079578 */
            ii(0x1007_956d, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1007_9570, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_9573, 5); call(0x1015_27ed, 0xd_9275);            /* call 0x101527ed */
        l_0x1007_9578:
            ii(0x1007_9578, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x1007_957d, 5); call(Definitions.sys_new, 0xe_c87e);    /* call 0x10165e00 */
            ii(0x1007_9582, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x1007_9585, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x1007_9588, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
            ii(0x1007_958b, 4); cmp(memd[ss, ebp - 0x48], 0);           /* cmp dword [ebp-0x48], 0x0 */
            ii(0x1007_958f, 2); if(jz(0x1007_95c4, 0x33)) goto l_0x1007_95c4; /* jz 0x100795c4 */
            ii(0x1007_9591, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_9594, 1); push(eax);                              /* push eax */
            ii(0x1007_9595, 3); lea(edx, memd[ss, ebp - 0x50]);         /* lea edx, [ebp-0x50] */
            ii(0x1007_9598, 3); lea(eax, memd[ss, ebp - 0x68]);         /* lea eax, [ebp-0x68] */
            ii(0x1007_959b, 5); call(0x1007_5e64, -0x373c);             /* call 0x10075e64 */
            ii(0x1007_95a0, 1); push(eax);                              /* push eax */
            ii(0x1007_95a1, 4); movsx(eax, memb[ss, ebp - 0x18]);       /* movsx eax, byte [ebp-0x18] */
            ii(0x1007_95a5, 1); push(eax);                              /* push eax */
            ii(0x1007_95a6, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1007_95a8, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1007_95ab, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1007_95ae, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x1007_95b1, 5); call(0x100a_c220, 0x3_2c6a);            /* call 0x100ac220 */
            ii(0x1007_95b6, 3); mov(memd[ss, ebp - 0x4c], eax);         /* mov [ebp-0x4c], eax */
            ii(0x1007_95b9, 3); mov(eax, memd[ss, ebp - 0x4c]);         /* mov eax, [ebp-0x4c] */
            ii(0x1007_95bc, 6); mov(memd[ss, ebp - 0xa0], eax);         /* mov [ebp-0xa0], eax */
            ii(0x1007_95c2, 2); jmp(0x1007_95cd, 0x9); goto l_0x1007_95cd; /* jmp 0x100795cd */
        l_0x1007_95c4:
            ii(0x1007_95c4, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1007_95c7, 6); mov(memd[ss, ebp - 0xa0], eax);         /* mov [ebp-0xa0], eax */
        l_0x1007_95cd:
            ii(0x1007_95cd, 6); mov(edx, memd[ss, ebp - 0xa0]);         /* mov edx, [ebp-0xa0] */
            ii(0x1007_95d3, 3); lea(eax, memd[ss, ebp - 0x6c]);         /* lea eax, [ebp-0x6c] */
            ii(0x1007_95d6, 5); call(0x1008_a5f0, 0x1_1015);            /* call 0x1008a5f0 */
            ii(0x1007_95db, 3); mov(eax, memd[ss, ebp - 0x50]);         /* mov eax, [ebp-0x50] */
            ii(0x1007_95de, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1007_95e1, 4); mov(memw[ds, edx + 0x1e], ax);          /* mov [edx+0x1e], ax */
            ii(0x1007_95e5, 3); mov(eax, memd[ss, ebp - 0x4e]);         /* mov eax, [ebp-0x4e] */
            ii(0x1007_95e8, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1007_95eb, 4); mov(memw[ds, edx + 0x20], ax);          /* mov [edx+0x20], ax */
            ii(0x1007_95ef, 3); lea(eax, memd[ss, ebp - 0x6c]);         /* lea eax, [ebp-0x6c] */
            ii(0x1007_95f2, 5); call(0x1008_a57c, 0x1_0f85);            /* call 0x1008a57c */
            ii(0x1007_95f7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_95f9, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1007_95fe, 5); call(0x100a_4d50, 0x2_b74d);            /* call 0x100a4d50 */
            ii(0x1007_9603, 4); mov(memb[ss, ebp - 0x14], 0x1);         /* mov byte [ebp-0x14], 0x1 */
            ii(0x1007_9607, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_9609, 3); lea(eax, memd[ss, ebp - 0x6c]);         /* lea eax, [ebp-0x6c] */
            ii(0x1007_960c, 5); call(0x1008_8d4c, 0xf73b);              /* call 0x10088d4c */
            ii(0x1007_9611, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_9613, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
            ii(0x1007_9616, 5); call(0x1008_8e0c, 0xf7f1);              /* call 0x10088e0c */
            ii(0x1007_961b, 2); jmp(0x1007_9631, 0x14); goto l_0x1007_9631; /* jmp 0x10079631 */
        //  ii(0x1007_961d, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1007_961f, 3); lea(eax, memd[ss, ebp - 0x6c]);         /* lea eax, [ebp-0x6c] */
        //  ii(0x1007_9622, 5); call(0x1008_8d4c, 0xf725);              /* call 0x10088d4c */
        //  ii(0x1007_9627, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1007_9629, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
        //  ii(0x1007_962c, 5); call(0x1008_8e0c, 0xf7db);              /* call 0x10088e0c */
        l_0x1007_9631:
            ii(0x1007_9631, 3); mov(al, memb[ss, ebp - 0x14]);          /* mov al, [ebp-0x14] */
            ii(0x1007_9634, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_9636, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_9637, 1); pop(edi);                               /* pop edi */
            ii(0x1007_9638, 1); pop(esi);                               /* pop esi */
            ii(0x1007_9639, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_963a, 1); ret();                                  /* ret */
        }
    }
}
