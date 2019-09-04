using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_ea25-83473834")]
        public void Method_1015_ea25()
        {
            ii(0x1015_ea25, 5); push(0x1cc);                            /* push 0x1cc */
            ii(0x1015_ea2a, 5); call(Definitions.sys_check_available_stack_size, 0x7323); /* call 0x10165d52 */
            ii(0x1015_ea2f, 1); push(ebx);                              /* push ebx */
            ii(0x1015_ea30, 1); push(ecx);                              /* push ecx */
            ii(0x1015_ea31, 1); push(edx);                              /* push edx */
            ii(0x1015_ea32, 1); push(esi);                              /* push esi */
            ii(0x1015_ea33, 1); push(edi);                              /* push edi */
            ii(0x1015_ea34, 1); push(ebp);                              /* push ebp */
            ii(0x1015_ea35, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_ea37, 6); sub(esp, 0x1a0);                        /* sub esp, 0x1a0 */
            ii(0x1015_ea3d, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1015_ea40, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_ea43, 5); call(0x1015_41da, -0xa86e);             /* call 0x101541da */
            ii(0x1015_ea48, 2); test(al, al);                           /* test al, al */
            ii(0x1015_ea4a, 6); if(jz(0x1015_eb2f, 0xdf)) goto l_0x1015_eb2f; /* jz 0x1015eb2f */
            ii(0x1015_ea50, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_ea53, 5); call(0x1007_611c, -0xe_893c);           /* call 0x1007611c */
            ii(0x1015_ea58, 3); lea(ebx, memd[ss, ebp - 8]);            /* lea ebx, [ebp-0x8] */
            ii(0x1015_ea5b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_ea5d, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_ea5f, 5); call(0x1007_66ac, -0xe_83b8);           /* call 0x100766ac */
            ii(0x1015_ea64, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1015_ea67, 5); call(0x1007_6574, -0xe_84f8);           /* call 0x10076574 */
            ii(0x1015_ea6c, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1015_ea6f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_ea72, 3); imul(edx, eax, 0x33);                   /* imul edx, eax, 0x33 */
            ii(0x1015_ea75, 5); mov(eax, 0x101c_81c0);                  /* mov eax, 0x101c81c0 */
            ii(0x1015_ea7a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1015_ea7c, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1015_ea7f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_ea82, 4); mov(memb[ds, eax + 61], 0);             /* mov byte [eax+0x3d], 0x0 */
            ii(0x1015_ea86, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_ea89, 4); mov(memb[ds, eax + 62], 1);             /* mov byte [eax+0x3e], 0x1 */
            ii(0x1015_ea8d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_ea8f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_ea92, 5); call(0x1008_a998, -0xd_40ff);           /* call 0x1008a998 */
            ii(0x1015_ea97, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_ea9a, 5); call(0x1015_26ac, -0xc3f3);             /* call 0x101526ac */
            ii(0x1015_ea9f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_eaa1, 2); if(jz(0x1015_eac7, 0x24)) goto l_0x1015_eac7; /* jz 0x1015eac7 */
            ii(0x1015_eaa3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_eaa6, 5); call(0x1015_26ac, -0xc3ff);             /* call 0x101526ac */
            ii(0x1015_eaab, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1015_eaae, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1015_eab1, 3); mov(ecx, memd[ds, eax + 2]);            /* mov ecx, [eax+0x2] */
            ii(0x1015_eab4, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1015_eab7, 5); call(0x1007_65d0, -0xe_84ec);           /* call 0x100765d0 */
            ii(0x1015_eabc, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1015_eabe, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1015_eac1, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1015_eac4, 3); call_abs(memd[ds, ecx + 104]);          /* call dword [ecx+0x68] */
        l_0x1015_eac7:
            ii(0x1015_eac7, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1015_eacc, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_eacf, 5); call(0x1007_6d98, -0xe_7d3c);           /* call 0x10076d98 */
            ii(0x1015_ead4, 2); test(al, al);                           /* test al, al */
            ii(0x1015_ead6, 2); if(jz(0x1015_eb25, 0x4d)) goto l_0x1015_eb25; /* jz 0x1015eb25 */
            ii(0x1015_ead8, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1015_eadb, 5); call(0x1007_6574, -0xe_856c);           /* call 0x10076574 */
            ii(0x1015_eae0, 3); mov(al, memb[ds, eax + 39]);            /* mov al, [eax+0x27] */
            ii(0x1015_eae3, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_eae8, 1); push(eax);                              /* push eax */
            ii(0x1015_eae9, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1015_eaec, 3); push(memd[ds, eax + 23]);               /* push dword [eax+0x17] */
            ii(0x1015_eaef, 5); mov(eax, StringDefinitions.SIHasBeenUnloadedFromAirTransport); /* mov eax, 0x101b288e */
            ii(0x1015_eaf4, 1); push(eax);                              /* push eax */
            ii(0x1015_eaf5, 6); lea(eax, memd[ss, ebp - 416]);          /* lea eax, [ebp-0x1a0] */
            ii(0x1015_eafb, 1); push(eax);                              /* push eax */
            ii(0x1015_eafc, 5); call(Definitions.sys_sprintf, 0x7400);  /* call 0x10165f01 */
            ii(0x1015_eb01, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1015_eb04, 5); call(0x100c_aa00, -0x9_4109);           /* call 0x100caa00 */
            ii(0x1015_eb09, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_eb0e, 1); push(eax);                              /* push eax */
            ii(0x1015_eb0f, 5); call(0x100c_aa20, -0x9_40f4);           /* call 0x100caa20 */
            ii(0x1015_eb14, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1015_eb16, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_eb18, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_eb1a, 6); lea(eax, memd[ss, ebp - 416]);          /* lea eax, [ebp-0x1a0] */
            ii(0x1015_eb20, 5); call(0x1011_5d23, -0x4_8e02);           /* call 0x10115d23 */
        l_0x1015_eb25:
            ii(0x1015_eb25, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_eb27, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1015_eb2a, 5); call(0x1007_5f2c, -0xe_8c03);           /* call 0x10075f2c */
        l_0x1015_eb2f:
            ii(0x1015_eb2f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_eb31, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_eb32, 1); pop(edi);                               /* pop edi */
            ii(0x1015_eb33, 1); pop(esi);                               /* pop esi */
            ii(0x1015_eb34, 1); pop(edx);                               /* pop edx */
            ii(0x1015_eb35, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_eb36, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_eb37, 1); ret();                                  /* ret */
        }
    }
}
