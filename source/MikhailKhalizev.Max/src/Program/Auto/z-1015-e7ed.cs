using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_e7ed-87fd424f")]
        public void Method_1015_e7ed()
        {
            ii(0x1015_e7ed, 5); push(0x1cc);                            /* push 0x1cc */
            ii(0x1015_e7f2, 5); call(Definitions.sys_check_available_stack_size, 0x755b); /* call 0x10165d52 */
            ii(0x1015_e7f7, 1); push(ebx);                              /* push ebx */
            ii(0x1015_e7f8, 1); push(ecx);                              /* push ecx */
            ii(0x1015_e7f9, 1); push(edx);                              /* push edx */
            ii(0x1015_e7fa, 1); push(esi);                              /* push esi */
            ii(0x1015_e7fb, 1); push(edi);                              /* push edi */
            ii(0x1015_e7fc, 1); push(ebp);                              /* push ebp */
            ii(0x1015_e7fd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_e7ff, 6); sub(esp, 0x1a0);                        /* sub esp, 0x1a0 */
            ii(0x1015_e805, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1015_e808, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_e80b, 5); call(0x1015_41da, -0xa636);             /* call 0x101541da */
            ii(0x1015_e810, 2); test(al, al);                           /* test al, al */
            ii(0x1015_e812, 6); if(jz(0x1015_e8f7, 0xdf)) goto l_0x1015_e8f7; /* jz 0x1015e8f7 */
            ii(0x1015_e818, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_e81b, 5); call(0x1007_611c, -0xe_8704);           /* call 0x1007611c */
            ii(0x1015_e820, 3); lea(ebx, memd[ss, ebp - 8]);            /* lea ebx, [ebp-0x8] */
            ii(0x1015_e823, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_e825, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_e827, 5); call(0x1007_66ac, -0xe_8180);           /* call 0x100766ac */
            ii(0x1015_e82c, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1015_e82f, 5); call(0x1007_6574, -0xe_82c0);           /* call 0x10076574 */
            ii(0x1015_e834, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1015_e837, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_e83a, 3); imul(edx, eax, 0x33);                   /* imul edx, eax, 0x33 */
            ii(0x1015_e83d, 5); mov(eax, 0x101c_81c0);                  /* mov eax, 0x101c81c0 */
            ii(0x1015_e842, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1015_e844, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1015_e847, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_e84a, 4); mov(memb[ds, eax + 61], 0);             /* mov byte [eax+0x3d], 0x0 */
            ii(0x1015_e84e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_e851, 4); mov(memb[ds, eax + 62], 1);             /* mov byte [eax+0x3e], 0x1 */
            ii(0x1015_e855, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_e857, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_e85a, 5); call(0x1008_a998, -0xd_3ec7);           /* call 0x1008a998 */
            ii(0x1015_e85f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_e862, 5); call(0x1015_26ac, -0xc1bb);             /* call 0x101526ac */
            ii(0x1015_e867, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_e869, 2); if(jz(0x1015_e88f, 0x24)) goto l_0x1015_e88f; /* jz 0x1015e88f */
            ii(0x1015_e86b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_e86e, 5); call(0x1015_26ac, -0xc1c7);             /* call 0x101526ac */
            ii(0x1015_e873, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1015_e876, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1015_e879, 3); mov(ecx, memd[ds, eax + 2]);            /* mov ecx, [eax+0x2] */
            ii(0x1015_e87c, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1015_e87f, 5); call(0x1007_65d0, -0xe_82b4);           /* call 0x100765d0 */
            ii(0x1015_e884, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1015_e886, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1015_e889, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1015_e88c, 3); call_abs(memd[ds, ecx + 96]);           /* call dword [ecx+0x60] */
        l_0x1015_e88f:
            ii(0x1015_e88f, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1015_e894, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_e897, 5); call(0x1007_6d98, -0xe_7b04);           /* call 0x10076d98 */
            ii(0x1015_e89c, 2); test(al, al);                           /* test al, al */
            ii(0x1015_e89e, 2); if(jz(0x1015_e8ed, 0x4d)) goto l_0x1015_e8ed; /* jz 0x1015e8ed */
            ii(0x1015_e8a0, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1015_e8a3, 5); call(0x1007_6574, -0xe_8334);           /* call 0x10076574 */
            ii(0x1015_e8a8, 3); mov(al, memb[ds, eax + 39]);            /* mov al, [eax+0x27] */
            ii(0x1015_e8ab, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_e8b0, 1); push(eax);                              /* push eax */
            ii(0x1015_e8b1, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1015_e8b4, 3); push(memd[ds, eax + 23]);               /* push dword [eax+0x17] */
            ii(0x1015_e8b7, 5); mov(eax, StringDefinitions.SIHasBeenLoadedIntoAirTransport); /* mov eax, 0x101b2864 */
            ii(0x1015_e8bc, 1); push(eax);                              /* push eax */
            ii(0x1015_e8bd, 6); lea(eax, memd[ss, ebp - 416]);          /* lea eax, [ebp-0x1a0] */
            ii(0x1015_e8c3, 1); push(eax);                              /* push eax */
            ii(0x1015_e8c4, 5); call(Definitions.sys_sprintf, 0x7638);  /* call 0x10165f01 */
            ii(0x1015_e8c9, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1015_e8cc, 5); call(0x100c_aa00, -0x9_3ed1);           /* call 0x100caa00 */
            ii(0x1015_e8d1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_e8d6, 1); push(eax);                              /* push eax */
            ii(0x1015_e8d7, 5); call(0x100c_aa20, -0x9_3ebc);           /* call 0x100caa20 */
            ii(0x1015_e8dc, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1015_e8de, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_e8e0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_e8e2, 6); lea(eax, memd[ss, ebp - 416]);          /* lea eax, [ebp-0x1a0] */
            ii(0x1015_e8e8, 5); call(0x1011_5d23, -0x4_8bca);           /* call 0x10115d23 */
        l_0x1015_e8ed:
            ii(0x1015_e8ed, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_e8ef, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1015_e8f2, 5); call(0x1007_5f2c, -0xe_89cb);           /* call 0x10075f2c */
        l_0x1015_e8f7:
            ii(0x1015_e8f7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_e8f9, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_e8fa, 1); pop(edi);                               /* pop edi */
            ii(0x1015_e8fb, 1); pop(esi);                               /* pop esi */
            ii(0x1015_e8fc, 1); pop(edx);                               /* pop edx */
            ii(0x1015_e8fd, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_e8fe, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_e8ff, 1); ret();                                  /* ret */
        }
    }
}
