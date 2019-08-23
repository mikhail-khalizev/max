using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_d323-5a7cce30")]
        public void Method_1013_d323()
        {
            ii(0x1013_d323, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1013_d328, 5); call(Definitions.sys_check_available_stack_size, 0x2_8a25); /* call 0x10165d52 */
            ii(0x1013_d32d, 1); push(ebx);                              /* push ebx */
            ii(0x1013_d32e, 1); push(ecx);                              /* push ecx */
            ii(0x1013_d32f, 1); push(esi);                              /* push esi */
            ii(0x1013_d330, 1); push(edi);                              /* push edi */
            ii(0x1013_d331, 1); push(ebp);                              /* push ebp */
            ii(0x1013_d332, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_d334, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1013_d33a, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_d33d, 3); mov(memb[ss, ebp - 0x4], dl);           /* mov [ebp-0x4], dl */
            ii(0x1013_d340, 4); cmp(memb[ss, ebp - 0x4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1013_d344, 2); if(jz(0x1013_d3a1, 0x5b)) goto l_0x1013_d3a1; /* jz 0x1013d3a1 */
            ii(0x1013_d346, 7); mov(memd[ss, ebp - 0xc], 0x14);         /* mov dword [ebp-0xc], 0x14 */
        l_0x1013_d34d:
            ii(0x1013_d34d, 3); dec(memd[ss, ebp - 0xc]);               /* dec dword [ebp-0xc] */
            ii(0x1013_d350, 5); cmp(memw[ss, ebp - 0xc], -0x1 /* 0xff */); /* cmp word [ebp-0xc], 0xffff */
            ii(0x1013_d355, 2); if(jz(0x1013_d392, 0x3b)) goto l_0x1013_d392; /* jz 0x1013d392 */
            ii(0x1013_d357, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1013_d35b, 6); imul(eax, eax, 0x91);                   /* imul eax, eax, 0x91 */
            ii(0x1013_d361, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_d364, 6); add(edx, 0x251);                        /* add edx, 0x251 */
            ii(0x1013_d36a, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_d36c, 3); mov(memd[ss, ebp - 0x10], edx);         /* mov [ebp-0x10], edx */
            ii(0x1013_d36f, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_d372, 6); cmp(memd[ds, eax], 0xffff);             /* cmp dword [eax], 0xffff */
            ii(0x1013_d378, 2); if(jz(0x1013_d383, 0x9)) goto l_0x1013_d383; /* jz 0x1013d383 */
            ii(0x1013_d37a, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_d37d, 4); cmp(memb[ds, eax + 0x6], 0x2);          /* cmp byte [eax+0x6], 0x2 */
            ii(0x1013_d381, 2); if(jle(0x1013_d385, 0x2)) goto l_0x1013_d385; /* jle 0x1013d385 */
        l_0x1013_d383:
            ii(0x1013_d383, 2); jmp(0x1013_d390, 0xb); goto l_0x1013_d390; /* jmp 0x1013d390 */
        l_0x1013_d385:
            ii(0x1013_d385, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1013_d388, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_d38b, 5); call(0x1013_ce3f, -0x551);              /* call 0x1013ce3f */
        l_0x1013_d390:
            ii(0x1013_d390, 2); jmp(0x1013_d34d, -0x45); goto l_0x1013_d34d; /* jmp 0x1013d34d */
        l_0x1013_d392:
            ii(0x1013_d392, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_d395, 10); mov(memd[ds, eax + 0xda5], 0);         /* mov dword [eax+0xda5], 0x0 */
            ii(0x1013_d39f, 2); jmp(0x1013_d401, 0x60); goto l_0x1013_d401; /* jmp 0x1013d401 */
        l_0x1013_d3a1:
            ii(0x1013_d3a1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_d3a3, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x1013_d3a8, 5); call(0x1013_ad71, -0x263c);             /* call 0x1013ad71 */
            ii(0x1013_d3ad, 2); test(al, al);                           /* test al, al */
            ii(0x1013_d3af, 2); if(jz(0x1013_d401, 0x50)) goto l_0x1013_d401; /* jz 0x1013d401 */
            ii(0x1013_d3b1, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x1013_d3b6, 5); call(0x1007_6574, -0xc_6e47);           /* call 0x10076574 */
            ii(0x1013_d3bb, 3); mov(al, memb[ds, eax + 0x2c]);          /* mov al, [eax+0x2c] */
            ii(0x1013_d3be, 3); mov(memb[ss, ebp - 0x14], al);          /* mov [ebp-0x14], al */
            ii(0x1013_d3c1, 5); call(0x1010_2bf8, -0x3_a7ce);           /* call 0x10102bf8 */
            ii(0x1013_d3c6, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1013_d3c8, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1013_d3ca, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_d3cc, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x1013_d3d1, 5); call(0x1007_6600, -0xc_6dd6);           /* call 0x10076600 */
            ii(0x1013_d3d6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_d3d8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_d3db, 5); call(0x1013_d5c0, 0x1e0);               /* call 0x1013d5c0 */
            ii(0x1013_d3e0, 5); call(0x1010_2bf8, -0x3_a7ed);           /* call 0x10102bf8 */
            ii(0x1013_d3e5, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1013_d3e7, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1013_d3e9, 4); movsx(ebx, memb[ss, ebp - 0x14]);       /* movsx ebx, byte [ebp-0x14] */
            ii(0x1013_d3ed, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x1013_d3f2, 5); call(0x1007_6600, -0xc_6df7);           /* call 0x10076600 */
            ii(0x1013_d3f7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_d3f9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_d3fc, 5); call(0x1013_d5c0, 0x1bf);               /* call 0x1013d5c0 */
        l_0x1013_d401:
            ii(0x1013_d401, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_d403, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_d404, 1); pop(edi);                               /* pop edi */
            ii(0x1013_d405, 1); pop(esi);                               /* pop esi */
            ii(0x1013_d406, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_d407, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_d408, 1); ret();                                  /* ret */
        }
    }
}
