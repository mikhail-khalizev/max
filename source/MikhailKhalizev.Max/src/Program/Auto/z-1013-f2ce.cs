using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_f2ce-95ae5089")]
        public void Method_1013_f2ce()
        {
            ii(0x1013_f2ce, 1); push(ebx);                              /* push ebx */
            ii(0x1013_f2cf, 1); push(esi);                              /* push esi */
            ii(0x1013_f2d0, 1); push(edi);                              /* push edi */
            ii(0x1013_f2d1, 1); push(ebp);                              /* push ebp */
            ii(0x1013_f2d2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_f2d4, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_f2da, 3); mov(eax, memd[ss, ebp + 0x1c]);         /* mov eax, [ebp+0x1c] */
            ii(0x1013_f2dd, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1013_f2e0, 5); jmp(0x1013_f3ec, 0x107); goto l_0x1013_f3ec; /* jmp 0x1013f3ec */
        l_0x1013_f2e5:
            ii(0x1013_f2e5, 5); jmp(0x1013_f406, 0x11c); goto l_0x1013_f406; /* jmp 0x1013f406 */
        l_0x1013_f2ea:
            ii(0x1013_f2ea, 8); cmp(memw[ds, 0x101c_7284], -1 /* 0xff */); /* cmp word [0x101c7284], 0xffff */
            ii(0x1013_f2f2, 6); if(jz(0x1013_f3e8, 0xf0)) goto l_0x1013_f3e8; /* jz 0x1013f3e8 */
            ii(0x1013_f2f8, 7); cmp(memd[ds, 0x101c_7278], 0);          /* cmp dword [0x101c7278], 0x0 */
            ii(0x1013_f2ff, 2); if(jz(0x1013_f30a, 9)) goto l_0x1013_f30a; /* jz 0x1013f30a */
            ii(0x1013_f301, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1013_f308, 2); jmp(0x1013_f323, 0x19); goto l_0x1013_f323; /* jmp 0x1013f323 */
        l_0x1013_f30a:
            ii(0x1013_f30a, 5); mov(ecx, 0x8b0);                        /* mov ecx, 0x8b0 */
            ii(0x1013_f30f, 5); mov(ebx, StringDefinitions.SoundmgrCpp); /* mov ebx, 0x101acd50 */
            ii(0x1013_f314, 5); mov(edx, StringDefinitions.SoundMgrMusicSampleNotEqual0); /* mov edx, 0x101acd5d */
            ii(0x1013_f319, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_f31b, 5); call(Definitions.sys_assert, 0x2_6a72); /* call 0x10165d92 */
            ii(0x1013_f320, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
        l_0x1013_f323:
            ii(0x1013_f323, 5); mov(eax, memd[ds, 0x101c_7278]);        /* mov eax, [0x101c7278] */
            ii(0x1013_f328, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1013_f32a, 3); cmp(eax, memd[ss, ebp + 0x20]);         /* cmp eax, [ebp+0x20] */
            ii(0x1013_f32d, 2); if(jnz(0x1013_f338, 9)) goto l_0x1013_f338; /* jnz 0x1013f338 */
            ii(0x1013_f32f, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x1013_f336, 2); jmp(0x1013_f351, 0x19); goto l_0x1013_f351; /* jmp 0x1013f351 */
        l_0x1013_f338:
            ii(0x1013_f338, 5); mov(ecx, 0x8b1);                        /* mov ecx, 0x8b1 */
            ii(0x1013_f33d, 5); mov(ebx, StringDefinitions.SoundmgrCpp2); /* mov ebx, 0x101acd79 */
            ii(0x1013_f342, 5); mov(edx, StringDefinitions.SoundMgrMusicSampleHandleEqualWsample); /* mov edx, 0x101acd86 */
            ii(0x1013_f347, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_f349, 5); call(Definitions.sys_assert, 0x2_6a44); /* call 0x10165d92 */
            ii(0x1013_f34e, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x1013_f351:
            ii(0x1013_f351, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_f353, 5); mov(al, memb[ds, 0x101c_8082]);         /* mov al, [0x101c8082] */
            ii(0x1013_f358, 7); mov(memb[ds, eax + 0x101c_8078], 0);    /* mov byte [eax+0x101c8078], 0x0 */
            ii(0x1013_f35f, 6); inc(memb[ds, 0x101c_8082]);             /* inc byte [0x101c8082] */
            ii(0x1013_f365, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_f367, 5); mov(al, memb[ds, 0x101c_8082]);         /* mov al, [0x101c8082] */
            ii(0x1013_f36c, 3); cmp(eax, 9);                            /* cmp eax, 0x9 */
            ii(0x1013_f36f, 2); if(jl(0x1013_f378, 7)) goto l_0x1013_f378; /* jl 0x1013f378 */
            ii(0x1013_f371, 7); mov(memb[ds, 0x101c_8082], 0);          /* mov byte [0x101c8082], 0x0 */
        l_0x1013_f378:
            ii(0x1013_f378, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_f37a, 5); mov(al, memb[ds, 0x101c_8082]);         /* mov al, [0x101c8082] */
            ii(0x1013_f37f, 6); mov(al, memb[ds, eax + 0x101c_8078]);   /* mov al, [eax+0x101c8078] */
            ii(0x1013_f385, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_f38a, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x1013_f38d, 2); if(jnz(0x1013_f3d2, 0x43)) goto l_0x1013_f3d2; /* jnz 0x1013f3d2 */
            ii(0x1013_f38f, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1013_f391, 6); mov(edx, memd[ds, 0x101c_728a]);        /* mov edx, [0x101c728a] */
            ii(0x1013_f397, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1013_f399, 6); mov(cl, memb[ds, 0x101c_8082]);         /* mov cl, [0x101c8082] */
            ii(0x1013_f39f, 6); imul(ecx, ecx, 0x6e00);                 /* imul ecx, ecx, 0x6e00 */
            ii(0x1013_f3a5, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1013_f3a7, 2); add(ecx, edx);                          /* add ecx, edx */
            ii(0x1013_f3a9, 5); mov(eax, memd[ds, 0x101c_7278]);        /* mov eax, [0x101c7278] */
            ii(0x1013_f3ae, 4); mov(memw[ds, eax + 0xf], bx);           /* mov [eax+0xf], bx */
            ii(0x1013_f3b2, 3); mov(memd[ds, eax + 0xb], ecx);          /* mov [eax+0xb], ecx */
            ii(0x1013_f3b5, 5); mov(eax, memd[ds, 0x101c_7278]);        /* mov eax, [0x101c7278] */
            ii(0x1013_f3ba, 3); add(eax, 0xb);                          /* add eax, 0xb */
            ii(0x1013_f3bd, 2); mov(ebx, ds);                           /* mov ebx, ds */
            ii(0x1013_f3bf, 3); mov(edx, memd[ss, ebp + 0x20]);         /* mov edx, [ebp+0x20] */
            ii(0x1013_f3c2, 3); mov(esi, memd[ss, ebp + 0x18]);         /* mov esi, [ebp+0x18] */
            ii(0x1013_f3c5, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1013_f3c7, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1013_f3c9, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1013_f3cb, 5); call(/* sys */ 0x1018_03dc, 0x4_100c);  /* call 0x101803dc */
            ii(0x1013_f3d0, 2); jmp(0x1013_f3e1, 0xf); goto l_0x1013_f3e1; /* jmp 0x1013f3e1 */
        l_0x1013_f3d2:
            ii(0x1013_f3d2, 3); mov(eax, memd[ss, ebp + 0x20]);         /* mov eax, [ebp+0x20] */
            ii(0x1013_f3d5, 5); mov(memd[ds, 0x101c_7290], eax);        /* mov [0x101c7290], eax */
            ii(0x1013_f3da, 7); mov(memb[ds, 0x101c_728f], 1);          /* mov byte [0x101c728f], 0x1 */
        l_0x1013_f3e1:
            ii(0x1013_f3e1, 7); mov(memb[ds, 0x101c_728e], 1);          /* mov byte [0x101c728e], 0x1 */
        l_0x1013_f3e8:
            ii(0x1013_f3e8, 2); jmp(0x1013_f406, 0x1c); goto l_0x1013_f406; /* jmp 0x1013f406 */
        l_0x1013_f3ea:
            ii(0x1013_f3ea, 2); jmp(0x1013_f406, 0x1a); goto l_0x1013_f406; /* jmp 0x1013f406 */
        l_0x1013_f3ec:
            ii(0x1013_f3ec, 4); cmp(memd[ss, ebp - 4], 0);              /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1013_f3f0, 6); if(jbe(0x1013_f2ea, -0x10c)) goto l_0x1013_f2ea; /* jbe 0x1013f2ea */
            ii(0x1013_f3f6, 4); cmp(memd[ss, ebp - 4], 2);              /* cmp dword [ebp-0x4], 0x2 */
            ii(0x1013_f3fa, 6); if(jbe(0x1013_f2e5, -0x11b)) goto l_0x1013_f2e5; /* jbe 0x1013f2e5 */
            ii(0x1013_f400, 2); jmp(0x1013_f3ea, -0x18); goto l_0x1013_f3ea; /* jmp 0x1013f3ea */
        //  ii(0x1013_f402, 2); jmp(0x1013_f3ea, -0x1a); goto l_0x1013_f3ea; /* jmp 0x1013f3ea */
        //  ii(0x1013_f404, 2); jmp(0x1013_f3ea, -0x1c); goto l_0x1013_f3ea; /* jmp 0x1013f3ea */
        l_0x1013_f406:
            ii(0x1013_f406, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_f408, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_f409, 1); pop(edi);                               /* pop edi */
            ii(0x1013_f40a, 1); pop(esi);                               /* pop esi */
            ii(0x1013_f40b, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_f40c, 1); retf();                                 /* retf */
        }
    }
}
