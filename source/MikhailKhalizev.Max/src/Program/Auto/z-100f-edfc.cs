using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4d06d466-f44c-41f1-b86a-b3493a8da717")]
        public void Method_100f_edfc()
        {
            ii(0x100f_edfc, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100f_ee01, 5); calld(Definitions.sys_check_available_stack_size, 0x66f4c); /* call 0x10165d52 */
            ii(0x100f_ee06, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_ee07, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_ee08, 1); pushd(edx);                             /* push edx */
            ii(0x100f_ee09, 1); pushd(esi);                             /* push esi */
            ii(0x100f_ee0a, 1); pushd(edi);                             /* push edi */
            ii(0x100f_ee0b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_ee0c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_ee0e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100f_ee14, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_ee17, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_ee1b, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100f_ee1f, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x100f_ee25, 6); mov(ebx, memd_a32[ds, edx + 0x101c_a562]); /* mov ebx, [edx+0x101ca562] */
            ii(0x100f_ee2b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_ee2d, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100f_ee2f, 5); calld(0x100d_f3dc, -0x1fa58);           /* call 0x100df3dc */
            ii(0x100f_ee34, 5); mov(edx, 0x101c_8184);                  /* mov edx, 0x101c8184 */
            ii(0x100f_ee39, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_ee3d, 5); calld(0x100f_ecf6, -0x14c);             /* call 0x100fecf6 */
            ii(0x100f_ee42, 5); mov(edx, 0x101c_819c);                  /* mov edx, 0x101c819c */
            ii(0x100f_ee47, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_ee4b, 5); calld(0x100f_ecf6, -0x15a);             /* call 0x100fecf6 */
            ii(0x100f_ee50, 5); mov(edx, 0x101c_81a8);                  /* mov edx, 0x101c81a8 */
            ii(0x100f_ee55, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_ee59, 5); calld(0x100f_ecf6, -0x168);             /* call 0x100fecf6 */
            ii(0x100f_ee5e, 5); mov(edx, 0x101c_8184);                  /* mov edx, 0x101c8184 */
            ii(0x100f_ee63, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_ee67, 5); calld(0x100f_ed71, -0xfb);              /* call 0x100fed71 */
            ii(0x100f_ee6c, 5); mov(edx, 0x101c_819c);                  /* mov edx, 0x101c819c */
            ii(0x100f_ee71, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_ee75, 5); calld(0x100f_ed71, -0x109);             /* call 0x100fed71 */
            ii(0x100f_ee7a, 5); mov(edx, 0x101c_81a8);                  /* mov edx, 0x101c81a8 */
            ii(0x100f_ee7f, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_ee83, 5); calld(0x100f_ed71, -0x117);             /* call 0x100fed71 */
            ii(0x100f_ee88, 4); mov(memb_a32[ss, ebp - 0x8], 0x8);      /* mov byte [ebp-0x8], 0x8 */
            ii(0x100f_ee8c, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100f_ee90, 2); jmpd(0x100f_ee95, 0x3); goto l_0x100f_ee95; /* jmp 0x100fee95 */
        l_0x100f_ee92:
            ii(0x100f_ee92, 3); inc(memb_a32[ss, ebp - 0x8]);           /* inc byte [ebp-0x8] */
        l_0x100f_ee95:
            ii(0x100f_ee95, 4); cmp(memb_a32[ss, ebp - 0x8], 0x8);      /* cmp byte [ebp-0x8], 0x8 */
            ii(0x100f_ee99, 2); if(jged(0x100f_eee3, 0x48)) goto l_0x100f_eee3; /* jge 0x100feee3 */
            ii(0x100f_ee9b, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_ee9f, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_eea5, 5); mov(edx, 0x101c_a468);                  /* mov edx, 0x101ca468 */
            ii(0x100f_eeaa, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_eeac, 4); movsx(eax, memb_a32[ss, ebp - 0x8]);    /* movsx eax, byte [ebp-0x8] */
            ii(0x100f_eeb0, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x100f_eeb3, 6); add(edx, 0x88);                         /* add edx, 0x88 */
            ii(0x100f_eeb9, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_eebb, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100f_eebe, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_eec1, 4); cmp(memd_a32[ds, eax + 0x8], 0);        /* cmp dword [eax+0x8], 0x0 */
            ii(0x100f_eec5, 2); if(jzd(0x100f_eed0, 0x9)) goto l_0x100f_eed0; /* jz 0x100feed0 */
            ii(0x100f_eec7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_eeca, 4); cmp(memd_a32[ds, eax + 0x4], 0);        /* cmp dword [eax+0x4], 0x0 */
            ii(0x100f_eece, 2); if(jzd(0x100f_eed2, 0x2)) goto l_0x100f_eed2; /* jz 0x100feed2 */
        l_0x100f_eed0:
            ii(0x100f_eed0, 2); jmpd(0x100f_eee1, 0xf); goto l_0x100f_eee1; /* jmp 0x100feee1 */
        l_0x100f_eed2:
            ii(0x100f_eed2, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_eed4, 4); movsx(edx, memb_a32[ss, ebp - 0x8]);    /* movsx edx, byte [ebp-0x8] */
            ii(0x100f_eed8, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_eedc, 5); calld(0x1013_322d, 0x3434c);            /* call 0x1013322d */
        l_0x100f_eee1:
            ii(0x100f_eee1, 2); jmpd(0x100f_ee92, -0x51); goto l_0x100f_ee92; /* jmp 0x100fee92 */
        l_0x100f_eee3:
            ii(0x100f_eee3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_eee5, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_eee6, 1); popd(edi);                              /* pop edi */
            ii(0x100f_eee7, 1); popd(esi);                              /* pop esi */
            ii(0x100f_eee8, 1); popd(edx);                              /* pop edx */
            ii(0x100f_eee9, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_eeea, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_eeeb, 1); retd(); return;                         /* ret */
        }
    }
}
