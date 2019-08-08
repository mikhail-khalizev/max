using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b624e5bc-5dd8-4575-9254-dbc2d1a9671c")]
        public void /* sys */ Method_1017_f04e()
        {
            ii(0x1017_f04e, 1); pushd(edx);                             /* push edx */
            ii(0x1017_f04f, 1); pushd(esi);                             /* push esi */
            ii(0x1017_f050, 1); pushd(edi);                             /* push edi */
            ii(0x1017_f051, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_f052, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_f054, 6); sub(esp, 0x84);                         /* sub esp, 0x84 */
            ii(0x1017_f05a, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1017_f05d, 4); mov(memw_a32[ss, ebp - 0x78], cx);      /* mov [ebp-0x78], cx */
            ii(0x1017_f061, 3); mov(memd_a32[ss, ebp - 0x7c], ebx);     /* mov [ebp-0x7c], ebx */
            ii(0x1017_f064, 4); lgs(eax, ss, ebp + 0x14);               /* lgs eax, [ebp+0x14] */
            ii(0x1017_f068, 3); mov(eax, memd_a32[gs, eax]);            /* mov eax, [gs:eax] */
            ii(0x1017_f06b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1017_f06e, 4); lgs(eax, ss, ebp + 0x14);               /* lgs eax, [ebp+0x14] */
            ii(0x1017_f072, 4); mov(eax, memd_a32[gs, eax + 0x10]);     /* mov eax, [gs:eax+0x10] */
            ii(0x1017_f076, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1017_f079, 4); lgs(eax, ss, ebp + 0x14);               /* lgs eax, [ebp+0x14] */
            ii(0x1017_f07d, 5); mov(ax, memw_a32[gs, eax + 0x8]);       /* mov ax, [gs:eax+0x8] */
            ii(0x1017_f082, 4); mov(memw_a32[ss, ebp - 0x48], ax);      /* mov [ebp-0x48], ax */
            ii(0x1017_f086, 4); lgs(eax, ss, ebp + 0x14);               /* lgs eax, [ebp+0x14] */
            ii(0x1017_f08a, 4); mov(eax, memd_a32[gs, eax + 0x4]);      /* mov eax, [gs:eax+0x4] */
            ii(0x1017_f08e, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x1017_f091, 4); lgs(eax, ss, ebp + 0x14);               /* lgs eax, [ebp+0x14] */
            ii(0x1017_f095, 4); mov(eax, memd_a32[gs, eax + 0xc]);      /* mov eax, [gs:eax+0xc] */
            ii(0x1017_f099, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1017_f09c, 4); lgs(eax, ss, ebp + 0x14);               /* lgs eax, [ebp+0x14] */
            ii(0x1017_f0a0, 4); mov(eax, memd_a32[gs, eax + 0x10]);     /* mov eax, [gs:eax+0x10] */
            ii(0x1017_f0a4, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1017_f0a7, 4); lgs(eax, ss, ebp + 0x14);               /* lgs eax, [ebp+0x14] */
            ii(0x1017_f0ab, 4); mov(eax, memd_a32[gs, eax + 0x14]);     /* mov eax, [gs:eax+0x14] */
            ii(0x1017_f0af, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1017_f0b2, 4); lgs(eax, ss, ebp + 0x14);               /* lgs eax, [ebp+0x14] */
            ii(0x1017_f0b6, 4); mov(eax, memd_a32[gs, eax + 0x18]);     /* mov eax, [gs:eax+0x18] */
            ii(0x1017_f0ba, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1017_f0bd, 7); mov(memd_a32[ss, ebp - 0x2c], 0x6);     /* mov dword [ebp-0x2c], 0x6 */
            ii(0x1017_f0c4, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
        l_0x1017_f0cb:
            ii(0x1017_f0cb, 4); cmp(memd_a32[ss, ebp - 0x28], 0x5);     /* cmp dword [ebp-0x28], 0x5 */
            ii(0x1017_f0cf, 2); if(jbd(0x1017_f0d8, 0x7)) goto l_0x1017_f0d8; /* jb 0x1017f0d8 */
            ii(0x1017_f0d1, 2); jmpd(0x1017_f0f1, 0x1e); goto l_0x1017_f0f1; /* jmp 0x1017f0f1 */
        l_0x1017_f0d3:
            ii(0x1017_f0d3, 3); inc(memd_a32[ss, ebp - 0x28]);          /* inc dword [ebp-0x28] */
            ii(0x1017_f0d6, 2); jmpd(0x1017_f0cb, -0xd); goto l_0x1017_f0cb; /* jmp 0x1017f0cb */
        l_0x1017_f0d8:
            ii(0x1017_f0d8, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1017_f0db, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_f0de, 7); cmp(memd_a32[ds, eax + 0x101c_03cc], 0); /* cmp dword [eax+0x101c03cc], 0x0 */
            ii(0x1017_f0e5, 2); if(jnzd(0x1017_f0ef, 0x8)) goto l_0x1017_f0ef; /* jnz 0x1017f0ef */
            ii(0x1017_f0e7, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1017_f0ea, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1017_f0ed, 2); jmpd(0x1017_f0f1, 0x2); goto l_0x1017_f0f1; /* jmp 0x1017f0f1 */
        l_0x1017_f0ef:
            ii(0x1017_f0ef, 2); jmpd(0x1017_f0d3, -0x1e); goto l_0x1017_f0d3; /* jmp 0x1017f0d3 */
        l_0x1017_f0f1:
            ii(0x1017_f0f1, 4); cmp(memd_a32[ss, ebp - 0x2c], 0x6);     /* cmp dword [ebp-0x2c], 0x6 */
            ii(0x1017_f0f5, 2); if(jnzd(0x1017_f103, 0xc)) goto l_0x1017_f103; /* jnz 0x1017f103 */
            ii(0x1017_f0f7, 7); mov(memd_a32[ss, ebp - 0x24], 0xb);     /* mov dword [ebp-0x24], 0xb */
            ii(0x1017_f0fe, 5); jmpd(0x1017_f8a0, 0x79d); goto l_0x1017_f8a0; /* jmp 0x1017f8a0 */
        l_0x1017_f103:
            ii(0x1017_f103, 3); mov(edx, memd_a32[ss, ebp - 0x2c]);     /* mov edx, [ebp-0x2c] */
            ii(0x1017_f106, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1017_f109, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1017_f10c, 6); mov(memd_a32[ds, edx + 0x101c_03cc], eax); /* mov [edx+0x101c03cc], eax */
            ii(0x1017_f112, 4); lgs(eax, ss, ebp + 0x14);               /* lgs eax, [ebp+0x14] */
            ii(0x1017_f116, 5); cmp(memd_a32[gs, eax + 0x24], 0);       /* cmp dword [gs:eax+0x24], 0x0 */
            ii(0x1017_f11b, 2); if(jnzd(0x1017_f129, 0xc)) goto l_0x1017_f129; /* jnz 0x1017f129 */
            ii(0x1017_f11d, 4); lgs(eax, ss, ebp + 0x14);               /* lgs eax, [ebp+0x14] */
            ii(0x1017_f121, 6); cmp(memw_a32[gs, eax + 0x28], 0);       /* cmp word [gs:eax+0x28], 0x0 */
            ii(0x1017_f127, 2); if(jzd(0x1017_f18c, 0x63)) goto l_0x1017_f18c; /* jz 0x1017f18c */
        l_0x1017_f129:
            ii(0x1017_f129, 4); lgs(eax, ss, ebp + 0x14);               /* lgs eax, [ebp+0x14] */
            ii(0x1017_f12d, 5); mov(ax, memw_a32[gs, eax + 0x28]);      /* mov ax, [gs:eax+0x28] */
            ii(0x1017_f132, 4); mov(memw_a32[ss, ebp - 0x58], ax);      /* mov [ebp-0x58], ax */
            ii(0x1017_f136, 4); lgs(eax, ss, ebp + 0x14);               /* lgs eax, [ebp+0x14] */
            ii(0x1017_f13a, 4); mov(eax, memd_a32[gs, eax + 0x24]);     /* mov eax, [gs:eax+0x24] */
            ii(0x1017_f13e, 3); mov(memd_a32[ss, ebp - 0x5c], eax);     /* mov [ebp-0x5c], eax */
            ii(0x1017_f141, 4); lgs(eax, ss, ebp + 0x14);               /* lgs eax, [ebp+0x14] */
            ii(0x1017_f145, 5); mov(ax, memw_a32[gs, eax + 0x30]);      /* mov ax, [gs:eax+0x30] */
            ii(0x1017_f14a, 4); mov(memw_a32[ss, ebp - 0x60], ax);      /* mov [ebp-0x60], ax */
            ii(0x1017_f14e, 4); lgs(eax, ss, ebp + 0x14);               /* lgs eax, [ebp+0x14] */
            ii(0x1017_f152, 4); mov(eax, memd_a32[gs, eax + 0x2c]);     /* mov eax, [gs:eax+0x2c] */
            ii(0x1017_f156, 3); mov(memd_a32[ss, ebp - 0x64], eax);     /* mov [ebp-0x64], eax */
            ii(0x1017_f159, 4); imul(edx, memd_a32[ss, ebp - 0x2c], 0x6); /* imul edx, [ebp-0x2c], 0x6 */
            ii(0x1017_f15d, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x1017_f160, 7); mov(memw_a32[ds, edx + 0x101c_0214], ax); /* mov [edx+0x101c0214], ax */
            ii(0x1017_f167, 3); mov(eax, memd_a32[ss, ebp - 0x5c]);     /* mov eax, [ebp-0x5c] */
            ii(0x1017_f16a, 6); mov(memd_a32[ds, edx + 0x101c_0210], eax); /* mov [edx+0x101c0210], eax */
            ii(0x1017_f170, 4); imul(edx, memd_a32[ss, ebp - 0x2c], 0x6); /* imul edx, [ebp-0x2c], 0x6 */
            ii(0x1017_f174, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x1017_f177, 7); mov(memw_a32[ds, edx + 0x101c_0232], ax); /* mov [edx+0x101c0232], ax */
            ii(0x1017_f17e, 3); mov(eax, memd_a32[ss, ebp - 0x64]);     /* mov eax, [ebp-0x64] */
            ii(0x1017_f181, 6); mov(memd_a32[ds, edx + 0x101c_022e], eax); /* mov [edx+0x101c022e], eax */
            ii(0x1017_f187, 5); jmpd(0x1017_f22c, 0xa0); goto l_0x1017_f22c; /* jmp 0x1017f22c */
        l_0x1017_f18c:
            ii(0x1017_f18c, 3); mov(edx, memd_a32[ss, ebp - 0x2c]);     /* mov edx, [ebp-0x2c] */
            ii(0x1017_f18f, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1017_f192, 5); mov(eax, 0x101c_0288);                  /* mov eax, 0x101c0288 */
            ii(0x1017_f197, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_f199, 1); pushd(eax);                             /* push eax */
            ii(0x1017_f19a, 2); mov(ebx, ss);                           /* mov ebx, ss */
            ii(0x1017_f19c, 3); lea(esi, ebp - 0x5c);                   /* lea esi, [ebp-0x5c] */
            ii(0x1017_f19f, 3); movzx(eax, bx);                         /* movzx eax, bx */
            ii(0x1017_f1a2, 1); pushd(eax);                             /* push eax */
            ii(0x1017_f1a3, 1); pushd(esi);                             /* push esi */
            ii(0x1017_f1a4, 2); mov(esi, ss);                           /* mov esi, ss */
            ii(0x1017_f1a6, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1017_f1a9, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x1017_f1ab, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1017_f1ad, 3); mov(edx, memd_a32[ss, ebp - 0x2c]);     /* mov edx, [ebp-0x2c] */
            ii(0x1017_f1b0, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1017_f1b3, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1017_f1b5, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x1017_f1b7, 5); calld(/* sys */ 0x1019_5535, 0x1_6379); /* call 0x10195535 */
            ii(0x1017_f1bc, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1017_f1bf, 4); cmp(memd_a32[ss, ebp - 0x30], 0);       /* cmp dword [ebp-0x30], 0x0 */
            ii(0x1017_f1c3, 2); if(jzd(0x1017_f1d0, 0xb)) goto l_0x1017_f1d0; /* jz 0x1017f1d0 */
            ii(0x1017_f1c5, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1017_f1c8, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1017_f1cb, 5); jmpd(0x1017_f8a0, 0x6d0); goto l_0x1017_f8a0; /* jmp 0x1017f8a0 */
        l_0x1017_f1d0:
            ii(0x1017_f1d0, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x1017_f1d3, 4); lgs(edx, ss, ebp + 0x14);               /* lgs edx, [ebp+0x14] */
            ii(0x1017_f1d7, 5); mov(memw_a32[gs, edx + 0x28], ax);      /* mov [gs:edx+0x28], ax */
            ii(0x1017_f1dc, 3); mov(eax, memd_a32[ss, ebp - 0x5c]);     /* mov eax, [ebp-0x5c] */
            ii(0x1017_f1df, 4); lgs(edx, ss, ebp + 0x14);               /* lgs edx, [ebp+0x14] */
            ii(0x1017_f1e3, 4); mov(memd_a32[gs, edx + 0x24], eax);     /* mov [gs:edx+0x24], eax */
            ii(0x1017_f1e7, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x1017_f1ea, 4); lgs(edx, ss, ebp + 0x14);               /* lgs edx, [ebp+0x14] */
            ii(0x1017_f1ee, 5); mov(memw_a32[gs, edx + 0x30], ax);      /* mov [gs:edx+0x30], ax */
            ii(0x1017_f1f3, 3); mov(eax, memd_a32[ss, ebp - 0x64]);     /* mov eax, [ebp-0x64] */
            ii(0x1017_f1f6, 4); lgs(edx, ss, ebp + 0x14);               /* lgs edx, [ebp+0x14] */
            ii(0x1017_f1fa, 4); mov(memd_a32[gs, edx + 0x2c], eax);     /* mov [gs:edx+0x2c], eax */
            ii(0x1017_f1fe, 4); imul(edx, memd_a32[ss, ebp - 0x2c], 0x6); /* imul edx, [ebp-0x2c], 0x6 */
            ii(0x1017_f202, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x1017_f205, 7); mov(memw_a32[ds, edx + 0x101c_0214], ax); /* mov [edx+0x101c0214], ax */
            ii(0x1017_f20c, 3); mov(eax, memd_a32[ss, ebp - 0x5c]);     /* mov eax, [ebp-0x5c] */
            ii(0x1017_f20f, 6); mov(memd_a32[ds, edx + 0x101c_0210], eax); /* mov [edx+0x101c0210], eax */
            ii(0x1017_f215, 4); imul(edx, memd_a32[ss, ebp - 0x2c], 0x6); /* imul edx, [ebp-0x2c], 0x6 */
            ii(0x1017_f219, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x1017_f21c, 7); mov(memw_a32[ds, edx + 0x101c_0232], ax); /* mov [edx+0x101c0232], ax */
            ii(0x1017_f223, 3); mov(eax, memd_a32[ss, ebp - 0x64]);     /* mov eax, [ebp-0x64] */
            ii(0x1017_f226, 6); mov(memd_a32[ds, edx + 0x101c_022e], eax); /* mov [edx+0x101c022e], eax */
        l_0x1017_f22c:
            ii(0x1017_f22c, 4); imul(eax, memd_a32[ss, ebp - 0x2c], 0x6c); /* imul eax, [ebp-0x2c], 0x6c */
            ii(0x1017_f230, 5); mov(edx, 0x101c_03e4);                  /* mov edx, 0x101c03e4 */
            ii(0x1017_f235, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1017_f237, 2); mov(ebx, ds);                           /* mov ebx, ds */
            ii(0x1017_f239, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1017_f23c, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1017_f23e, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1017_f240, 5); calld(/* sys */ 0x1019_45bc, 0x1_5377); /* call 0x101945bc */
            ii(0x1017_f245, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1017_f248, 4); cmp(memd_a32[ss, ebp - 0x30], 0);       /* cmp dword [ebp-0x30], 0x0 */
            ii(0x1017_f24c, 2); if(jzd(0x1017_f259, 0xb)) goto l_0x1017_f259; /* jz 0x1017f259 */
            ii(0x1017_f24e, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1017_f251, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1017_f254, 5); jmpd(0x1017_f8a0, 0x647); goto l_0x1017_f8a0; /* jmp 0x1017f8a0 */
        l_0x1017_f259:
            ii(0x1017_f259, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1017_f25c, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_f25f, 10); cmp(memd_a32[ds, eax + 0x101c_03cc], 0xe106); /* cmp dword [eax+0x101c03cc], 0xe106 */
            ii(0x1017_f269, 6); if(jaed(0x1017_f624, 0x3b5)) goto l_0x1017_f624; /* jae 0x1017f624 */
            ii(0x1017_f26f, 3); mov(edx, memd_a32[ss, ebp - 0x2c]);     /* mov edx, [ebp-0x2c] */
            ii(0x1017_f272, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1017_f275, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1017_f278, 6); mov(memd_a32[ds, edx + 0x101c_0300], eax); /* mov [edx+0x101c0300], eax */
            ii(0x1017_f27e, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1017_f282, 6); if(jzd(0x1017_f3a3, 0x11b)) goto l_0x1017_f3a3; /* jz 0x1017f3a3 */
            ii(0x1017_f288, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1017_f28b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_f28e, 10); mov(memd_a32[ds, eax + 0x101b_e544], 0x1); /* mov dword [eax+0x101be544], 0x1 */
            ii(0x1017_f298, 6); mov(memw_a32[ss, ebp - 0x80], 0);       /* mov word [ebp-0x80], 0x0 */
            ii(0x1017_f29e, 10); mov(memd_a32[ss, ebp - 0x84], 0);      /* mov dword [ebp-0x84], 0x0 */
            ii(0x1017_f2a8, 3); mov(ebx, memd_a32[ss, ebp - 0x2c]);     /* mov ebx, [ebp-0x2c] */
            ii(0x1017_f2ab, 3); shl(ebx, 0x2);                          /* shl ebx, 0x2 */
            ii(0x1017_f2ae, 5); mov(eax, 0x101c_0346);                  /* mov eax, 0x101c0346 */
            ii(0x1017_f2b3, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1017_f2b5, 3); lea(edx, ebp - 0x3c);                   /* lea edx, [ebp-0x3c] */
            ii(0x1017_f2b8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1017_f2bb, 5); calld(/* sys */ 0x1017_fac2, 0x802);    /* call 0x1017fac2 */
            ii(0x1017_f2c0, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1017_f2c2, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1017_f2c4, 4); mov(memw_a32[ss, ebp - 0x48], bx);      /* mov [ebp-0x48], bx */
            ii(0x1017_f2c8, 3); mov(memd_a32[ss, ebp - 0x4c], ecx);     /* mov [ebp-0x4c], ecx */
            ii(0x1017_f2cb, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1017_f2ce, 6); cmp(eax, memd_a32[ss, ebp - 0x84]);     /* cmp eax, [ebp-0x84] */
            ii(0x1017_f2d4, 2); if(jnzd(0x1017_f303, 0x2d)) goto l_0x1017_f303; /* jnz 0x1017f303 */
            ii(0x1017_f2d6, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1017_f2d9, 4); cmp(ax, memw_a32[ss, ebp - 0x80]);      /* cmp ax, [ebp-0x80] */
            ii(0x1017_f2dd, 2); if(jnzd(0x1017_f303, 0x24)) goto l_0x1017_f303; /* jnz 0x1017f303 */
            ii(0x1017_f2df, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1017_f2e2, 5); calld(/* sys */ 0x1019_5726, 0x1_643f); /* call 0x10195726 */
            ii(0x1017_f2e7, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1017_f2ea, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_f2ed, 10); mov(memd_a32[ds, eax + 0x101c_03cc], 0); /* mov dword [eax+0x101c03cc], 0x0 */
            ii(0x1017_f2f7, 7); mov(memd_a32[ss, ebp - 0x24], 0x5);     /* mov dword [ebp-0x24], 0x5 */
            ii(0x1017_f2fe, 5); jmpd(0x1017_f8a0, 0x59d); goto l_0x1017_f8a0; /* jmp 0x1017f8a0 */
        l_0x1017_f303:
            ii(0x1017_f303, 4); imul(edx, memd_a32[ss, ebp - 0x2c], 0x6); /* imul edx, [ebp-0x2c], 0x6 */
            ii(0x1017_f307, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1017_f30a, 7); mov(memw_a32[ds, edx + 0x101c_0318], ax); /* mov [edx+0x101c0318], ax */
            ii(0x1017_f311, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1017_f314, 6); mov(memd_a32[ds, edx + 0x101c_0314], eax); /* mov [edx+0x101c0314], eax */
            ii(0x1017_f31a, 4); imul(eax, memd_a32[ss, ebp - 0x2c], 0x6c); /* imul eax, [ebp-0x2c], 0x6c */
            ii(0x1017_f31e, 7); cmp(memd_a32[ds, eax + 0x101c_0408], 0x8); /* cmp dword [eax+0x101c0408], 0x8 */
            ii(0x1017_f325, 2); if(jnzd(0x1017_f37e, 0x57)) goto l_0x1017_f37e; /* jnz 0x1017f37e */
            ii(0x1017_f327, 4); imul(eax, memd_a32[ss, ebp - 0x2c], 0x6c); /* imul eax, [ebp-0x2c], 0x6c */
            ii(0x1017_f32b, 7); test(memb_a32[ds, eax + 0x101c_0421], 0x80); /* test byte [eax+0x101c0421], 0x80 */
            ii(0x1017_f332, 2); if(jzd(0x1017_f359, 0x25)) goto l_0x1017_f359; /* jz 0x1017f359 */
            ii(0x1017_f334, 7); mov(memd_a32[ss, ebp - 0x44], 0);       /* mov dword [ebp-0x44], 0x0 */
        l_0x1017_f33b:
            ii(0x1017_f33b, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1017_f33e, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1017_f341, 2); if(jbd(0x1017_f34a, 0x7)) goto l_0x1017_f34a; /* jb 0x1017f34a */
            ii(0x1017_f343, 2); jmpd(0x1017_f357, 0x12); goto l_0x1017_f357; /* jmp 0x1017f357 */
        l_0x1017_f345:
            ii(0x1017_f345, 3); inc(memd_a32[ss, ebp - 0x44]);          /* inc dword [ebp-0x44] */
            ii(0x1017_f348, 2); jmpd(0x1017_f33b, -0xf); goto l_0x1017_f33b; /* jmp 0x1017f33b */
        l_0x1017_f34a:
            ii(0x1017_f34a, 4); lgs(eax, ss, ebp - 0x4c);               /* lgs eax, [ebp-0x4c] */
            ii(0x1017_f34e, 3); add(eax, memd_a32[ss, ebp - 0x44]);     /* add eax, [ebp-0x44] */
            ii(0x1017_f351, 4); mov(memb_a32[gs, eax], 0);              /* mov byte [gs:eax], 0x0 */
            ii(0x1017_f355, 2); jmpd(0x1017_f345, -0x12); goto l_0x1017_f345; /* jmp 0x1017f345 */
        l_0x1017_f357:
            ii(0x1017_f357, 2); jmpd(0x1017_f37c, 0x23); goto l_0x1017_f37c; /* jmp 0x1017f37c */
        l_0x1017_f359:
            ii(0x1017_f359, 7); mov(memd_a32[ss, ebp - 0x44], 0);       /* mov dword [ebp-0x44], 0x0 */
        l_0x1017_f360:
            ii(0x1017_f360, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1017_f363, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1017_f366, 2); if(jbd(0x1017_f36f, 0x7)) goto l_0x1017_f36f; /* jb 0x1017f36f */
            ii(0x1017_f368, 2); jmpd(0x1017_f37c, 0x12); goto l_0x1017_f37c; /* jmp 0x1017f37c */
        l_0x1017_f36a:
            ii(0x1017_f36a, 3); inc(memd_a32[ss, ebp - 0x44]);          /* inc dword [ebp-0x44] */
            ii(0x1017_f36d, 2); jmpd(0x1017_f360, -0xf); goto l_0x1017_f360; /* jmp 0x1017f360 */
        l_0x1017_f36f:
            ii(0x1017_f36f, 4); lgs(eax, ss, ebp - 0x4c);               /* lgs eax, [ebp-0x4c] */
            ii(0x1017_f373, 3); add(eax, memd_a32[ss, ebp - 0x44]);     /* add eax, [ebp-0x44] */
            ii(0x1017_f376, 4); mov(memb_a32[gs, eax], 0x80);           /* mov byte [gs:eax], 0x80 */
            ii(0x1017_f37a, 2); jmpd(0x1017_f36a, -0x12); goto l_0x1017_f36a; /* jmp 0x1017f36a */
        l_0x1017_f37c:
            ii(0x1017_f37c, 2); jmpd(0x1017_f3a1, 0x23); goto l_0x1017_f3a1; /* jmp 0x1017f3a1 */
        l_0x1017_f37e:
            ii(0x1017_f37e, 7); mov(memd_a32[ss, ebp - 0x44], 0);       /* mov dword [ebp-0x44], 0x0 */
        l_0x1017_f385:
            ii(0x1017_f385, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1017_f388, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1017_f38b, 2); if(jbd(0x1017_f394, 0x7)) goto l_0x1017_f394; /* jb 0x1017f394 */
            ii(0x1017_f38d, 2); jmpd(0x1017_f3a1, 0x12); goto l_0x1017_f3a1; /* jmp 0x1017f3a1 */
        l_0x1017_f38f:
            ii(0x1017_f38f, 3); inc(memd_a32[ss, ebp - 0x44]);          /* inc dword [ebp-0x44] */
            ii(0x1017_f392, 2); jmpd(0x1017_f385, -0xf); goto l_0x1017_f385; /* jmp 0x1017f385 */
        l_0x1017_f394:
            ii(0x1017_f394, 4); lgs(eax, ss, ebp - 0x4c);               /* lgs eax, [ebp-0x4c] */
            ii(0x1017_f398, 3); add(eax, memd_a32[ss, ebp - 0x44]);     /* add eax, [ebp-0x44] */
            ii(0x1017_f39b, 4); mov(memb_a32[gs, eax], 0);              /* mov byte [gs:eax], 0x0 */
            ii(0x1017_f39f, 2); jmpd(0x1017_f38f, -0x12); goto l_0x1017_f38f; /* jmp 0x1017f38f */
        l_0x1017_f3a1:
            ii(0x1017_f3a1, 2); jmpd(0x1017_f3d5, 0x32); goto l_0x1017_f3d5; /* jmp 0x1017f3d5 */
        l_0x1017_f3a3:
            ii(0x1017_f3a3, 4); imul(edx, memd_a32[ss, ebp - 0x2c], 0x6); /* imul edx, [ebp-0x2c], 0x6 */
            ii(0x1017_f3a7, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1017_f3aa, 7); mov(memw_a32[ds, edx + 0x101c_0318], ax); /* mov [edx+0x101c0318], ax */
            ii(0x1017_f3b1, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1017_f3b4, 6); mov(memd_a32[ds, edx + 0x101c_0314], eax); /* mov [edx+0x101c0314], eax */
            ii(0x1017_f3ba, 4); lgs(eax, ss, ebp + 0x14);               /* lgs eax, [ebp+0x14] */
            ii(0x1017_f3be, 4); mov(eax, memd_a32[gs, eax + 0x48]);     /* mov eax, [gs:eax+0x48] */
            ii(0x1017_f3c2, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1017_f3c5, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1017_f3c8, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_f3cb, 10); mov(memd_a32[ds, eax + 0x101b_e544], 0); /* mov dword [eax+0x101be544], 0x0 */
        l_0x1017_f3d5:
            ii(0x1017_f3d5, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1017_f3d8, 4); lgs(edx, ss, ebp + 0x14);               /* lgs edx, [ebp+0x14] */
            ii(0x1017_f3dc, 5); mov(memw_a32[gs, edx + 0x8], ax);       /* mov [gs:edx+0x8], ax */
            ii(0x1017_f3e1, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1017_f3e4, 4); lgs(edx, ss, ebp + 0x14);               /* lgs edx, [ebp+0x14] */
            ii(0x1017_f3e8, 4); mov(memd_a32[gs, edx + 0x4], eax);      /* mov [gs:edx+0x4], eax */
            ii(0x1017_f3ec, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1017_f3ef, 4); lgs(edx, ss, ebp + 0x14);               /* lgs edx, [ebp+0x14] */
            ii(0x1017_f3f3, 4); mov(memd_a32[gs, edx + 0x48], eax);     /* mov [gs:edx+0x48], eax */
            ii(0x1017_f3f7, 4); lgs(eax, ss, ebp + 0x14);               /* lgs eax, [ebp+0x14] */
            ii(0x1017_f3fb, 5); cmp(memd_a32[gs, eax + 0x34], 0);       /* cmp dword [gs:eax+0x34], 0x0 */
            ii(0x1017_f400, 6); if(jnzd(0x1017_f4b3, 0xad)) goto l_0x1017_f4b3; /* jnz 0x1017f4b3 */
            ii(0x1017_f406, 4); lgs(eax, ss, ebp + 0x14);               /* lgs eax, [ebp+0x14] */
            ii(0x1017_f40a, 6); cmp(memw_a32[gs, eax + 0x38], 0);       /* cmp word [gs:eax+0x38], 0x0 */
            ii(0x1017_f410, 6); if(jnzd(0x1017_f4b3, 0x9d)) goto l_0x1017_f4b3; /* jnz 0x1017f4b3 */
            ii(0x1017_f416, 4); lgs(eax, ss, ebp + 0x14);               /* lgs eax, [ebp+0x14] */
            ii(0x1017_f41a, 5); cmp(memd_a32[gs, eax + 0x44], 0);       /* cmp dword [gs:eax+0x44], 0x0 */
            ii(0x1017_f41f, 2); if(jzd(0x1017_f469, 0x48)) goto l_0x1017_f469; /* jz 0x1017f469 */
            ii(0x1017_f421, 3); mov(edx, memd_a32[ss, ebp - 0x2c]);     /* mov edx, [ebp-0x2c] */
            ii(0x1017_f424, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1017_f427, 5); mov(eax, 0x101c_029c);                  /* mov eax, 0x101c029c */
            ii(0x1017_f42c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_f42e, 1); pushd(eax);                             /* push eax */
            ii(0x1017_f42f, 2); mov(eax, ss);                           /* mov eax, ss */
            ii(0x1017_f431, 3); lea(edx, ebp - 0x6c);                   /* lea edx, [ebp-0x6c] */
            ii(0x1017_f434, 3); movzx(eax, ax);                         /* movzx eax, ax */
            ii(0x1017_f437, 1); pushd(eax);                             /* push eax */
            ii(0x1017_f438, 1); pushd(edx);                             /* push edx */
            ii(0x1017_f439, 2); mov(edx, ss);                           /* mov edx, ss */
            ii(0x1017_f43b, 3); lea(eax, ebp - 0x74);                   /* lea eax, [ebp-0x74] */
            ii(0x1017_f43e, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1017_f440, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_f442, 4); lgs(eax, ss, ebp + 0x14);               /* lgs eax, [ebp+0x14] */
            ii(0x1017_f446, 4); mov(eax, memd_a32[gs, eax + 0x44]);     /* mov eax, [gs:eax+0x44] */
            ii(0x1017_f44a, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1017_f44c, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1017_f44e, 5); calld(/* sys */ 0x1019_57ce, 0x1_637b); /* call 0x101957ce */
            ii(0x1017_f453, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1017_f456, 4); cmp(memd_a32[ss, ebp - 0x30], 0);       /* cmp dword [ebp-0x30], 0x0 */
            ii(0x1017_f45a, 2); if(jzd(0x1017_f467, 0xb)) goto l_0x1017_f467; /* jz 0x1017f467 */
            ii(0x1017_f45c, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1017_f45f, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1017_f462, 5); jmpd(0x1017_f8a0, 0x439); goto l_0x1017_f8a0; /* jmp 0x1017f8a0 */
        l_0x1017_f467:
            ii(0x1017_f467, 2); jmpd(0x1017_f4b1, 0x48); goto l_0x1017_f4b1; /* jmp 0x1017f4b1 */
        l_0x1017_f469:
            ii(0x1017_f469, 3); mov(edx, memd_a32[ss, ebp - 0x2c]);     /* mov edx, [ebp-0x2c] */
            ii(0x1017_f46c, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1017_f46f, 5); mov(eax, 0x101c_029c);                  /* mov eax, 0x101c029c */
            ii(0x1017_f474, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_f476, 1); pushd(eax);                             /* push eax */
            ii(0x1017_f477, 2); mov(edx, ss);                           /* mov edx, ss */
            ii(0x1017_f479, 3); lea(eax, ebp - 0x6c);                   /* lea eax, [ebp-0x6c] */
            ii(0x1017_f47c, 3); movzx(edx, dx);                         /* movzx edx, dx */
            ii(0x1017_f47f, 1); pushd(edx);                             /* push edx */
            ii(0x1017_f480, 1); pushd(eax);                             /* push eax */
            ii(0x1017_f481, 2); mov(edx, ss);                           /* mov edx, ss */
            ii(0x1017_f483, 3); lea(eax, ebp - 0x74);                   /* lea eax, [ebp-0x74] */
            ii(0x1017_f486, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1017_f488, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_f48a, 4); imul(eax, memd_a32[ss, ebp - 0x2c], 0x6c); /* imul eax, [ebp-0x2c], 0x6c */
            ii(0x1017_f48e, 6); mov(eax, memd_a32[ds, eax + 0x101c_044c]); /* mov eax, [eax+0x101c044c] */
            ii(0x1017_f494, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1017_f496, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1017_f498, 5); calld(/* sys */ 0x1019_57ce, 0x1_6331); /* call 0x101957ce */
            ii(0x1017_f49d, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1017_f4a0, 4); cmp(memd_a32[ss, ebp - 0x30], 0);       /* cmp dword [ebp-0x30], 0x0 */
            ii(0x1017_f4a4, 2); if(jzd(0x1017_f4b1, 0xb)) goto l_0x1017_f4b1; /* jz 0x1017f4b1 */
            ii(0x1017_f4a6, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1017_f4a9, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1017_f4ac, 5); jmpd(0x1017_f8a0, 0x3ef); goto l_0x1017_f8a0; /* jmp 0x1017f8a0 */
        l_0x1017_f4b1:
            ii(0x1017_f4b1, 2); jmpd(0x1017_f4cb, 0x18); goto l_0x1017_f4cb; /* jmp 0x1017f4cb */
        l_0x1017_f4b3:
            ii(0x1017_f4b3, 4); lgs(eax, ss, ebp + 0x14);               /* lgs eax, [ebp+0x14] */
            ii(0x1017_f4b7, 5); mov(ax, memw_a32[gs, eax + 0x38]);      /* mov ax, [gs:eax+0x38] */
            ii(0x1017_f4bc, 4); mov(memw_a32[ss, ebp - 0x68], ax);      /* mov [ebp-0x68], ax */
            ii(0x1017_f4c0, 4); lgs(eax, ss, ebp + 0x14);               /* lgs eax, [ebp+0x14] */
            ii(0x1017_f4c4, 4); mov(eax, memd_a32[gs, eax + 0x34]);     /* mov eax, [gs:eax+0x34] */
            ii(0x1017_f4c8, 3); mov(memd_a32[ss, ebp - 0x6c], eax);     /* mov [ebp-0x6c], eax */
        l_0x1017_f4cb:
            ii(0x1017_f4cb, 4); imul(eax, memd_a32[ss, ebp - 0x2c], 0x6c); /* imul eax, [ebp-0x2c], 0x6c */
            ii(0x1017_f4cf, 7); test(memb_a32[ds, eax + 0x101c_0421], 0x2); /* test byte [eax+0x101c0421], 0x2 */
            ii(0x1017_f4d6, 2); if(jzd(0x1017_f500, 0x28)) goto l_0x1017_f500; /* jz 0x1017f500 */
            ii(0x1017_f4d8, 4); movzx(eax, memw_a32[ss, ebp - 0x58]);   /* movzx eax, word [ebp-0x58] */
            ii(0x1017_f4dc, 1); pushd(eax);                             /* push eax */
            ii(0x1017_f4dd, 3); pushd(memd_a32[ss, ebp - 0x5c]);        /* push dword [ebp-0x5c] */
            ii(0x1017_f4e0, 4); movzx(eax, memw_a32[ss, ebp - 0x60]);   /* movzx eax, word [ebp-0x60] */
            ii(0x1017_f4e4, 1); pushd(eax);                             /* push eax */
            ii(0x1017_f4e5, 3); pushd(memd_a32[ss, ebp - 0x64]);        /* push dword [ebp-0x64] */
            ii(0x1017_f4e8, 4); movzx(eax, memw_a32[ss, ebp - 0x68]);   /* movzx eax, word [ebp-0x68] */
            ii(0x1017_f4ec, 1); pushd(eax);                             /* push eax */
            ii(0x1017_f4ed, 3); pushd(memd_a32[ss, ebp - 0x6c]);        /* push dword [ebp-0x6c] */
            ii(0x1017_f4f0, 4); movzx(eax, memw_a32[ss, ebp - 0x70]);   /* movzx eax, word [ebp-0x70] */
            ii(0x1017_f4f4, 1); pushd(eax);                             /* push eax */
            ii(0x1017_f4f5, 3); pushd(memd_a32[ss, ebp - 0x74]);        /* push dword [ebp-0x74] */
            ii(0x1017_f4f8, 5); calld(/* sys */ 0x1019_5267, 0x1_5d6a); /* call 0x10195267 */
            ii(0x1017_f4fd, 3); add(esp, 0x20);                         /* add esp, 0x20 */
        l_0x1017_f500:
            ii(0x1017_f500, 3); mov(eax, memd_a32[ss, ebp - 0x68]);     /* mov eax, [ebp-0x68] */
            ii(0x1017_f503, 4); lgs(edx, ss, ebp + 0x14);               /* lgs edx, [ebp+0x14] */
            ii(0x1017_f507, 5); mov(memw_a32[gs, edx + 0x38], ax);      /* mov [gs:edx+0x38], ax */
            ii(0x1017_f50c, 3); mov(eax, memd_a32[ss, ebp - 0x6c]);     /* mov eax, [ebp-0x6c] */
            ii(0x1017_f50f, 4); lgs(edx, ss, ebp + 0x14);               /* lgs edx, [ebp+0x14] */
            ii(0x1017_f513, 4); mov(memd_a32[gs, edx + 0x34], eax);     /* mov [gs:edx+0x34], eax */
            ii(0x1017_f517, 3); mov(eax, memd_a32[ss, ebp - 0x70]);     /* mov eax, [ebp-0x70] */
            ii(0x1017_f51a, 4); lgs(edx, ss, ebp + 0x14);               /* lgs edx, [ebp+0x14] */
            ii(0x1017_f51e, 5); mov(memw_a32[gs, edx + 0x40], ax);      /* mov [gs:edx+0x40], ax */
            ii(0x1017_f523, 3); mov(eax, memd_a32[ss, ebp - 0x74]);     /* mov eax, [ebp-0x74] */
            ii(0x1017_f526, 4); lgs(edx, ss, ebp + 0x14);               /* lgs edx, [ebp+0x14] */
            ii(0x1017_f52a, 4); mov(memd_a32[gs, edx + 0x3c], eax);     /* mov [gs:edx+0x3c], eax */
            ii(0x1017_f52e, 4); imul(edx, memd_a32[ss, ebp - 0x2c], 0x6); /* imul edx, [ebp-0x2c], 0x6 */
            ii(0x1017_f532, 3); mov(eax, memd_a32[ss, ebp - 0x68]);     /* mov eax, [ebp-0x68] */
            ii(0x1017_f535, 7); mov(memw_a32[ds, edx + 0x101c_0250], ax); /* mov [edx+0x101c0250], ax */
            ii(0x1017_f53c, 3); mov(eax, memd_a32[ss, ebp - 0x6c]);     /* mov eax, [ebp-0x6c] */
            ii(0x1017_f53f, 6); mov(memd_a32[ds, edx + 0x101c_024c], eax); /* mov [edx+0x101c024c], eax */
            ii(0x1017_f545, 4); imul(edx, memd_a32[ss, ebp - 0x2c], 0x6); /* imul edx, [ebp-0x2c], 0x6 */
            ii(0x1017_f549, 3); mov(eax, memd_a32[ss, ebp - 0x70]);     /* mov eax, [ebp-0x70] */
            ii(0x1017_f54c, 7); mov(memw_a32[ds, edx + 0x101c_026e], ax); /* mov [edx+0x101c026e], ax */
            ii(0x1017_f553, 3); mov(eax, memd_a32[ss, ebp - 0x74]);     /* mov eax, [ebp-0x74] */
            ii(0x1017_f556, 6); mov(memd_a32[ds, edx + 0x101c_026a], eax); /* mov [edx+0x101c026a], eax */
            ii(0x1017_f55c, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1017_f55f, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_f562, 10); mov(memd_a32[ds, eax + 0x101c_02c4], 0x1); /* mov dword [eax+0x101c02c4], 0x1 */
            ii(0x1017_f56c, 4); lgs(eax, ss, ebp - 0x7c);               /* lgs eax, [ebp-0x7c] */
            ii(0x1017_f570, 4); mov(eax, memd_a32[gs, eax + 0x8]);      /* mov eax, [gs:eax+0x8] */
            ii(0x1017_f574, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1017_f577, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1017_f57a, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_f57d, 6); mov(eax, memd_a32[ds, eax + 0x101c_066c]); /* mov eax, [eax+0x101c066c] */
            ii(0x1017_f583, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1017_f586, 5); mov(eax, 0x1020_a1c4);                  /* mov eax, 0x1020a1c4 */
            ii(0x1017_f58b, 1); pushd(eax);                             /* push eax */
            ii(0x1017_f58c, 3); pushd(memd_a32[ss, ebp - 0x2c]);        /* push dword [ebp-0x2c] */
            ii(0x1017_f58f, 3); pushd(memd_a32[ss, ebp - 0x38]);        /* push dword [ebp-0x38] */
            ii(0x1017_f592, 3); pushd(memd_a32[ss, ebp - 0x4]);         /* push dword [ebp-0x4] */
            ii(0x1017_f595, 4); movzx(eax, memw_a32[ss, ebp - 0x48]);   /* movzx eax, word [ebp-0x48] */
            ii(0x1017_f599, 1); pushd(eax);                             /* push eax */
            ii(0x1017_f59a, 3); pushd(memd_a32[ss, ebp - 0x4c]);        /* push dword [ebp-0x4c] */
            ii(0x1017_f59d, 4); movzx(eax, memw_a32[ss, ebp - 0x68]);   /* movzx eax, word [ebp-0x68] */
            ii(0x1017_f5a1, 1); pushd(eax);                             /* push eax */
            ii(0x1017_f5a2, 3); pushd(memd_a32[ss, ebp - 0x6c]);        /* push dword [ebp-0x6c] */
            ii(0x1017_f5a5, 4); movzx(eax, memw_a32[ss, ebp - 0x70]);   /* movzx eax, word [ebp-0x70] */
            ii(0x1017_f5a9, 1); pushd(eax);                             /* push eax */
            ii(0x1017_f5aa, 3); pushd(memd_a32[ss, ebp - 0x74]);        /* push dword [ebp-0x74] */
            ii(0x1017_f5ad, 5); calld(/* sys */ 0x1019_5016, 0x1_5a64); /* call 0x10195016 */
            ii(0x1017_f5b2, 3); add(esp, 0x28);                         /* add esp, 0x28 */
            ii(0x1017_f5b5, 4); imul(eax, memd_a32[ss, ebp - 0x2c], 0x6); /* imul eax, [ebp-0x2c], 0x6 */
            ii(0x1017_f5b9, 7); mov(dx, memw_a32[ds, 0x1020_a1c8]);     /* mov dx, [0x1020a1c8] */
            ii(0x1017_f5c0, 6); mov(ebx, memd_a32[ds, 0x1020_a1c4]);    /* mov ebx, [0x1020a1c4] */
            ii(0x1017_f5c6, 7); mov(memw_a32[ds, eax + 0x101c_0372], dx); /* mov [eax+0x101c0372], dx */
            ii(0x1017_f5cd, 6); mov(memd_a32[ds, eax + 0x101c_036e], ebx); /* mov [eax+0x101c036e], ebx */
            ii(0x1017_f5d3, 4); imul(eax, memd_a32[ss, ebp - 0x2c], 0x6); /* imul eax, [ebp-0x2c], 0x6 */
            ii(0x1017_f5d7, 7); mov(dx, memw_a32[ds, 0x1020_a1d0]);     /* mov dx, [0x1020a1d0] */
            ii(0x1017_f5de, 6); mov(ebx, memd_a32[ds, 0x1020_a1cc]);    /* mov ebx, [0x1020a1cc] */
            ii(0x1017_f5e4, 7); mov(memw_a32[ds, eax + 0x101c_03ae], dx); /* mov [eax+0x101c03ae], dx */
            ii(0x1017_f5eb, 6); mov(memd_a32[ds, eax + 0x101c_03aa], ebx); /* mov [eax+0x101c03aa], ebx */
            ii(0x1017_f5f1, 6); mov(ax, memw_a32[ds, 0x1020_a1d8]);     /* mov ax, [0x1020a1d8] */
            ii(0x1017_f5f7, 4); mov(memw_a32[ss, ebp - 0x50], ax);      /* mov [ebp-0x50], ax */
            ii(0x1017_f5fb, 5); mov(eax, memd_a32[ds, 0x1020_a1d4]);    /* mov eax, [0x1020a1d4] */
            ii(0x1017_f600, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x1017_f603, 4); movzx(eax, memw_a32[ss, ebp - 0x50]);   /* movzx eax, word [ebp-0x50] */
            ii(0x1017_f607, 1); pushd(eax);                             /* push eax */
            ii(0x1017_f608, 3); pushd(memd_a32[ss, ebp - 0x54]);        /* push dword [ebp-0x54] */
            ii(0x1017_f60b, 7); imul(edx, memd_a32[ss, ebp - 0x2c], 0xc0); /* imul edx, [ebp-0x2c], 0xc0 */
            ii(0x1017_f612, 5); mov(eax, 0x1020_b718);                  /* mov eax, 0x1020b718 */
            ii(0x1017_f617, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_f619, 1); pushd(eax);                             /* push eax */
            ii(0x1017_f61a, 5); calld(/* sys */ 0x1019_4dd7, 0x1_57b8); /* call 0x10194dd7 */
            ii(0x1017_f61f, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1017_f622, 2); jmpd(0x1017_f63b, 0x17); goto l_0x1017_f63b; /* jmp 0x1017f63b */
        l_0x1017_f624:
            ii(0x1017_f624, 4); imul(eax, memd_a32[ss, ebp - 0x2c], 0x6); /* imul eax, [ebp-0x2c], 0x6 */
            ii(0x1017_f628, 9); mov(memw_a32[ds, eax + 0x101c_0372], 0); /* mov word [eax+0x101c0372], 0x0 */
            ii(0x1017_f631, 10); mov(memd_a32[ds, eax + 0x101c_036e], 0); /* mov dword [eax+0x101c036e], 0x0 */
        l_0x1017_f63b:
            ii(0x1017_f63b, 4); imul(eax, memd_a32[ss, ebp - 0x2c], 0x6); /* imul eax, [ebp-0x2c], 0x6 */
            ii(0x1017_f63f, 7); mov(dx, memw_a32[ds, eax + 0x101c_0372]); /* mov dx, [eax+0x101c0372] */
            ii(0x1017_f646, 6); mov(ebx, memd_a32[ds, eax + 0x101c_036e]); /* mov ebx, [eax+0x101c036e] */
            ii(0x1017_f64c, 4); lgs(eax, ss, ebp + 0x14);               /* lgs eax, [ebp+0x14] */
            ii(0x1017_f650, 5); mov(memw_a32[gs, eax + 0x20], dx);      /* mov [gs:eax+0x20], dx */
            ii(0x1017_f655, 4); lgs(eax, ss, ebp + 0x14);               /* lgs eax, [ebp+0x14] */
            ii(0x1017_f659, 4); mov(memd_a32[gs, eax + 0x1c], ebx);     /* mov [gs:eax+0x1c], ebx */
            ii(0x1017_f65d, 4); lgs(eax, ss, ebp - 0x7c);               /* lgs eax, [ebp-0x7c] */
            ii(0x1017_f661, 4); pushd(memd_a32[gs, eax + 0x8]);         /* push dword [gs:eax+0x8] */
            ii(0x1017_f665, 5); calld(/* sys */ 0x1019_513e, 0x1_5ad4); /* call 0x1019513e */
            ii(0x1017_f66a, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1017_f66d, 3); mov(ebx, memd_a32[ss, ebp - 0x2c]);     /* mov ebx, [ebp-0x2c] */
            ii(0x1017_f670, 3); shl(ebx, 0x2);                          /* shl ebx, 0x2 */
            ii(0x1017_f673, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1017_f676, 6); mov(memd_a32[ds, ebx + 0x101c_0332], eax); /* mov [ebx+0x101c0332], eax */
            ii(0x1017_f67c, 4); lgs(eax, ss, ebp - 0x7c);               /* lgs eax, [ebp-0x7c] */
            ii(0x1017_f680, 3); mov(eax, memd_a32[gs, eax]);            /* mov eax, [gs:eax] */
            ii(0x1017_f683, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1017_f686, 4); lgs(eax, ss, ebp - 0x7c);               /* lgs eax, [ebp-0x7c] */
            ii(0x1017_f68a, 4); mov(eax, memd_a32[gs, eax + 0x4]);      /* mov eax, [gs:eax+0x4] */
            ii(0x1017_f68e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1017_f691, 4); lgs(eax, ss, ebp - 0x7c);               /* lgs eax, [ebp-0x7c] */
            ii(0x1017_f695, 4); mov(eax, memd_a32[gs, eax + 0x8]);      /* mov eax, [gs:eax+0x8] */
            ii(0x1017_f699, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1017_f69c, 4); lgs(eax, ss, ebp - 0x7c);               /* lgs eax, [ebp-0x7c] */
            ii(0x1017_f6a0, 4); mov(eax, memd_a32[gs, eax + 0xc]);      /* mov eax, [gs:eax+0xc] */
            ii(0x1017_f6a4, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1017_f6a7, 3); mov(al, memb_a32[ss, ebp - 0x38]);      /* mov al, [ebp-0x38] */
            ii(0x1017_f6aa, 3); mov(edx, memd_a32[ss, ebp - 0x2c]);     /* mov edx, [ebp-0x2c] */
            ii(0x1017_f6ad, 6); mov(memb_a32[ds, edx + 0x101c_068c], al); /* mov [edx+0x101c068c], al */
            ii(0x1017_f6b3, 3); pushd(memd_a32[ss, ebp - 0x20]);        /* push dword [ebp-0x20] */
            ii(0x1017_f6b6, 3); pushd(memd_a32[ss, ebp - 0x1c]);        /* push dword [ebp-0x1c] */
            ii(0x1017_f6b9, 3); pushd(memd_a32[ss, ebp - 0x18]);        /* push dword [ebp-0x18] */
            ii(0x1017_f6bc, 3); pushd(memd_a32[ss, ebp - 0x38]);        /* push dword [ebp-0x38] */
            ii(0x1017_f6bf, 3); pushd(memd_a32[ss, ebp - 0xc]);         /* push dword [ebp-0xc] */
            ii(0x1017_f6c2, 3); pushd(memd_a32[ss, ebp - 0x40]);        /* push dword [ebp-0x40] */
            ii(0x1017_f6c5, 4); movzx(eax, memw_a32[ss, ebp - 0x58]);   /* movzx eax, word [ebp-0x58] */
            ii(0x1017_f6c9, 1); pushd(eax);                             /* push eax */
            ii(0x1017_f6ca, 3); pushd(memd_a32[ss, ebp - 0x5c]);        /* push dword [ebp-0x5c] */
            ii(0x1017_f6cd, 4); movzx(eax, memw_a32[ss, ebp - 0x60]);   /* movzx eax, word [ebp-0x60] */
            ii(0x1017_f6d1, 1); pushd(eax);                             /* push eax */
            ii(0x1017_f6d2, 3); pushd(memd_a32[ss, ebp - 0x64]);        /* push dword [ebp-0x64] */
            ii(0x1017_f6d5, 5); calld(/* sys */ 0x1019_5069, 0x1_598f); /* call 0x10195069 */
            ii(0x1017_f6da, 3); add(esp, 0x28);                         /* add esp, 0x28 */
            ii(0x1017_f6dd, 4); movzx(eax, memw_a32[ss, ebp - 0x58]);   /* movzx eax, word [ebp-0x58] */
            ii(0x1017_f6e1, 1); pushd(eax);                             /* push eax */
            ii(0x1017_f6e2, 3); pushd(memd_a32[ss, ebp - 0x5c]);        /* push dword [ebp-0x5c] */
            ii(0x1017_f6e5, 4); movzx(eax, memw_a32[ss, ebp - 0x60]);   /* movzx eax, word [ebp-0x60] */
            ii(0x1017_f6e9, 1); pushd(eax);                             /* push eax */
            ii(0x1017_f6ea, 3); pushd(memd_a32[ss, ebp - 0x64]);        /* push dword [ebp-0x64] */
            ii(0x1017_f6ed, 5); calld(/* sys */ 0x1019_50ed, 0x1_59fb); /* call 0x101950ed */
            ii(0x1017_f6f2, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1017_f6f5, 3); pushd(memd_a32[ss, ebp - 0x14]);        /* push dword [ebp-0x14] */
            ii(0x1017_f6f8, 4); movzx(eax, memw_a32[ss, ebp - 0x58]);   /* movzx eax, word [ebp-0x58] */
            ii(0x1017_f6fc, 1); pushd(eax);                             /* push eax */
            ii(0x1017_f6fd, 3); pushd(memd_a32[ss, ebp - 0x5c]);        /* push dword [ebp-0x5c] */
            ii(0x1017_f700, 4); movzx(eax, memw_a32[ss, ebp - 0x60]);   /* movzx eax, word [ebp-0x60] */
            ii(0x1017_f704, 1); pushd(eax);                             /* push eax */
            ii(0x1017_f705, 3); pushd(memd_a32[ss, ebp - 0x64]);        /* push dword [ebp-0x64] */
            ii(0x1017_f708, 5); calld(/* sys */ 0x1019_50c7, 0x1_59ba); /* call 0x101950c7 */
            ii(0x1017_f70d, 3); add(esp, 0x14);                         /* add esp, 0x14 */
            ii(0x1017_f710, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1017_f713, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_f716, 6); mov(eax, memd_a32[ds, eax + 0x101c_0332]); /* mov eax, [eax+0x101c0332] */
            ii(0x1017_f71c, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1017_f71f, 3); pushd(memd_a32[ss, ebp - 0x4]);         /* push dword [ebp-0x4] */
            ii(0x1017_f722, 3); pushd(memd_a32[ss, ebp - 0x3c]);        /* push dword [ebp-0x3c] */
            ii(0x1017_f725, 4); movzx(eax, memw_a32[ss, ebp - 0x58]);   /* movzx eax, word [ebp-0x58] */
            ii(0x1017_f729, 1); pushd(eax);                             /* push eax */
            ii(0x1017_f72a, 3); pushd(memd_a32[ss, ebp - 0x5c]);        /* push dword [ebp-0x5c] */
            ii(0x1017_f72d, 4); movzx(eax, memw_a32[ss, ebp - 0x60]);   /* movzx eax, word [ebp-0x60] */
            ii(0x1017_f731, 1); pushd(eax);                             /* push eax */
            ii(0x1017_f732, 3); pushd(memd_a32[ss, ebp - 0x64]);        /* push dword [ebp-0x64] */
            ii(0x1017_f735, 5); calld(/* sys */ 0x1019_509e, 0x1_5964); /* call 0x1019509e */
            ii(0x1017_f73a, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x1017_f73d, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1017_f740, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_f743, 10); mov(memd_a32[ds, eax + 0x101c_02b0], 0x1); /* mov dword [eax+0x101c02b0], 0x1 */
            ii(0x1017_f74d, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1017_f750, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_f753, 10); mov(memd_a32[ds, eax + 0x101c_02d8], 0x1); /* mov dword [eax+0x101c02d8], 0x1 */
            ii(0x1017_f75d, 4); imul(eax, memd_a32[ss, ebp - 0x2c], 0x4c); /* imul eax, [ebp-0x2c], 0x4c */
            ii(0x1017_f761, 4); lgs(ebx, ss, ebp + 0x14);               /* lgs ebx, [ebp+0x14] */
            ii(0x1017_f765, 3); mov(ebx, memd_a32[gs, ebx]);            /* mov ebx, [gs:ebx] */
            ii(0x1017_f768, 6); mov(memd_a32[ds, eax + 0x1020_bad8], ebx); /* mov [eax+0x1020bad8], ebx */
            ii(0x1017_f76e, 4); imul(eax, memd_a32[ss, ebp - 0x2c], 0x4c); /* imul eax, [ebp-0x2c], 0x4c */
            ii(0x1017_f772, 4); lgs(edx, ss, ebp + 0x14);               /* lgs edx, [ebp+0x14] */
            ii(0x1017_f776, 5); mov(dx, memw_a32[gs, edx + 0x8]);       /* mov dx, [gs:edx+0x8] */
            ii(0x1017_f77b, 4); lgs(ebx, ss, ebp + 0x14);               /* lgs ebx, [ebp+0x14] */
            ii(0x1017_f77f, 4); mov(ebx, memd_a32[gs, ebx + 0x4]);      /* mov ebx, [gs:ebx+0x4] */
            ii(0x1017_f783, 7); mov(memw_a32[ds, eax + 0x1020_bae0], dx); /* mov [eax+0x1020bae0], dx */
            ii(0x1017_f78a, 6); mov(memd_a32[ds, eax + 0x1020_badc], ebx); /* mov [eax+0x1020badc], ebx */
            ii(0x1017_f790, 4); imul(eax, memd_a32[ss, ebp - 0x2c], 0x4c); /* imul eax, [ebp-0x2c], 0x4c */
            ii(0x1017_f794, 4); lgs(ebx, ss, ebp + 0x14);               /* lgs ebx, [ebp+0x14] */
            ii(0x1017_f798, 4); mov(ebx, memd_a32[gs, ebx + 0xc]);      /* mov ebx, [gs:ebx+0xc] */
            ii(0x1017_f79c, 6); mov(memd_a32[ds, eax + 0x1020_bae4], ebx); /* mov [eax+0x1020bae4], ebx */
            ii(0x1017_f7a2, 4); imul(eax, memd_a32[ss, ebp - 0x2c], 0x4c); /* imul eax, [ebp-0x2c], 0x4c */
            ii(0x1017_f7a6, 4); lgs(ebx, ss, ebp + 0x14);               /* lgs ebx, [ebp+0x14] */
            ii(0x1017_f7aa, 4); mov(ebx, memd_a32[gs, ebx + 0x10]);     /* mov ebx, [gs:ebx+0x10] */
            ii(0x1017_f7ae, 6); mov(memd_a32[ds, eax + 0x1020_bae8], ebx); /* mov [eax+0x1020bae8], ebx */
            ii(0x1017_f7b4, 4); imul(ebx, memd_a32[ss, ebp - 0x2c], 0x4c); /* imul ebx, [ebp-0x2c], 0x4c */
            ii(0x1017_f7b8, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1017_f7bb, 6); mov(memd_a32[ds, ebx + 0x1020_baec], eax); /* mov [ebx+0x1020baec], eax */
            ii(0x1017_f7c1, 4); imul(eax, memd_a32[ss, ebp - 0x2c], 0x4c); /* imul eax, [ebp-0x2c], 0x4c */
            ii(0x1017_f7c5, 4); lgs(ebx, ss, ebp + 0x14);               /* lgs ebx, [ebp+0x14] */
            ii(0x1017_f7c9, 4); mov(ebx, memd_a32[gs, ebx + 0x18]);     /* mov ebx, [gs:ebx+0x18] */
            ii(0x1017_f7cd, 6); mov(memd_a32[ds, eax + 0x1020_baf0], ebx); /* mov [eax+0x1020baf0], ebx */
            ii(0x1017_f7d3, 4); imul(eax, memd_a32[ss, ebp - 0x2c], 0x4c); /* imul eax, [ebp-0x2c], 0x4c */
            ii(0x1017_f7d7, 4); lgs(edx, ss, ebp + 0x14);               /* lgs edx, [ebp+0x14] */
            ii(0x1017_f7db, 5); mov(dx, memw_a32[gs, edx + 0x20]);      /* mov dx, [gs:edx+0x20] */
            ii(0x1017_f7e0, 4); lgs(ebx, ss, ebp + 0x14);               /* lgs ebx, [ebp+0x14] */
            ii(0x1017_f7e4, 4); mov(ebx, memd_a32[gs, ebx + 0x1c]);     /* mov ebx, [gs:ebx+0x1c] */
            ii(0x1017_f7e8, 7); mov(memw_a32[ds, eax + 0x1020_baf8], dx); /* mov [eax+0x1020baf8], dx */
            ii(0x1017_f7ef, 6); mov(memd_a32[ds, eax + 0x1020_baf4], ebx); /* mov [eax+0x1020baf4], ebx */
            ii(0x1017_f7f5, 4); imul(eax, memd_a32[ss, ebp - 0x2c], 0x4c); /* imul eax, [ebp-0x2c], 0x4c */
            ii(0x1017_f7f9, 4); lgs(edx, ss, ebp + 0x14);               /* lgs edx, [ebp+0x14] */
            ii(0x1017_f7fd, 5); mov(dx, memw_a32[gs, edx + 0x28]);      /* mov dx, [gs:edx+0x28] */
            ii(0x1017_f802, 4); lgs(ebx, ss, ebp + 0x14);               /* lgs ebx, [ebp+0x14] */
            ii(0x1017_f806, 4); mov(ebx, memd_a32[gs, ebx + 0x24]);     /* mov ebx, [gs:ebx+0x24] */
            ii(0x1017_f80a, 7); mov(memw_a32[ds, eax + 0x1020_bb00], dx); /* mov [eax+0x1020bb00], dx */
            ii(0x1017_f811, 6); mov(memd_a32[ds, eax + 0x1020_bafc], ebx); /* mov [eax+0x1020bafc], ebx */
            ii(0x1017_f817, 4); imul(eax, memd_a32[ss, ebp - 0x2c], 0x4c); /* imul eax, [ebp-0x2c], 0x4c */
            ii(0x1017_f81b, 4); lgs(edx, ss, ebp + 0x14);               /* lgs edx, [ebp+0x14] */
            ii(0x1017_f81f, 5); mov(dx, memw_a32[gs, edx + 0x38]);      /* mov dx, [gs:edx+0x38] */
            ii(0x1017_f824, 4); lgs(ebx, ss, ebp + 0x14);               /* lgs ebx, [ebp+0x14] */
            ii(0x1017_f828, 4); mov(ebx, memd_a32[gs, ebx + 0x34]);     /* mov ebx, [gs:ebx+0x34] */
            ii(0x1017_f82c, 7); mov(memw_a32[ds, eax + 0x1020_bb10], dx); /* mov [eax+0x1020bb10], dx */
            ii(0x1017_f833, 6); mov(memd_a32[ds, eax + 0x1020_bb0c], ebx); /* mov [eax+0x1020bb0c], ebx */
            ii(0x1017_f839, 4); imul(eax, memd_a32[ss, ebp - 0x2c], 0x4c); /* imul eax, [ebp-0x2c], 0x4c */
            ii(0x1017_f83d, 4); lgs(edx, ss, ebp + 0x14);               /* lgs edx, [ebp+0x14] */
            ii(0x1017_f841, 5); mov(dx, memw_a32[gs, edx + 0x30]);      /* mov dx, [gs:edx+0x30] */
            ii(0x1017_f846, 4); lgs(ebx, ss, ebp + 0x14);               /* lgs ebx, [ebp+0x14] */
            ii(0x1017_f84a, 4); mov(ebx, memd_a32[gs, ebx + 0x2c]);     /* mov ebx, [gs:ebx+0x2c] */
            ii(0x1017_f84e, 7); mov(memw_a32[ds, eax + 0x1020_bb08], dx); /* mov [eax+0x1020bb08], dx */
            ii(0x1017_f855, 6); mov(memd_a32[ds, eax + 0x1020_bb04], ebx); /* mov [eax+0x1020bb04], ebx */
            ii(0x1017_f85b, 4); imul(eax, memd_a32[ss, ebp - 0x2c], 0x4c); /* imul eax, [ebp-0x2c], 0x4c */
            ii(0x1017_f85f, 4); lgs(edx, ss, ebp + 0x14);               /* lgs edx, [ebp+0x14] */
            ii(0x1017_f863, 5); mov(dx, memw_a32[gs, edx + 0x40]);      /* mov dx, [gs:edx+0x40] */
            ii(0x1017_f868, 4); lgs(ebx, ss, ebp + 0x14);               /* lgs ebx, [ebp+0x14] */
            ii(0x1017_f86c, 4); mov(ebx, memd_a32[gs, ebx + 0x3c]);     /* mov ebx, [gs:ebx+0x3c] */
            ii(0x1017_f870, 7); mov(memw_a32[ds, eax + 0x1020_bb18], dx); /* mov [eax+0x1020bb18], dx */
            ii(0x1017_f877, 6); mov(memd_a32[ds, eax + 0x1020_bb14], ebx); /* mov [eax+0x1020bb14], ebx */
            ii(0x1017_f87d, 4); imul(ebx, memd_a32[ss, ebp - 0x2c], 0x4c); /* imul ebx, [ebp-0x2c], 0x4c */
            ii(0x1017_f881, 4); lgs(eax, ss, ebp + 0x14);               /* lgs eax, [ebp+0x14] */
            ii(0x1017_f885, 4); mov(eax, memd_a32[gs, eax + 0x44]);     /* mov eax, [gs:eax+0x44] */
            ii(0x1017_f889, 6); mov(memd_a32[ds, ebx + 0x1020_bb1c], eax); /* mov [ebx+0x1020bb1c], eax */
            ii(0x1017_f88f, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1017_f892, 4); lgs(ebx, ss, ebp + 0x1c);               /* lgs ebx, [ebp+0x1c] */
            ii(0x1017_f896, 3); mov(memd_a32[gs, ebx], eax);            /* mov [gs:ebx], eax */
            ii(0x1017_f899, 7); mov(memd_a32[ss, ebp - 0x24], 0);       /* mov dword [ebp-0x24], 0x0 */
        l_0x1017_f8a0:
            ii(0x1017_f8a0, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1017_f8a3, 1); leaved();                               /* leave */
            ii(0x1017_f8a4, 1); popd(edi);                              /* pop edi */
            ii(0x1017_f8a5, 1); popd(esi);                              /* pop esi */
            ii(0x1017_f8a6, 1); popd(edx);                              /* pop edx */
            ii(0x1017_f8a7, 3); retd(0x10); return;                     /* ret 0x10 */
        }
    }
}
