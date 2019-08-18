using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("664538ef-85e1-4dd5-a037-668f4683436a")]
        public void Method_1009_ee12()
        {
            ii(0x1009_ee12, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1009_ee17, 5); calld(Definitions.sys_check_available_stack_size, 0xc_6f36); /* call 0x10165d52 */
            ii(0x1009_ee1c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_ee1d, 1); pushd(esi);                             /* push esi */
            ii(0x1009_ee1e, 1); pushd(edi);                             /* push edi */
            ii(0x1009_ee1f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_ee20, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_ee22, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1009_ee28, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_ee2b, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1009_ee2e, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1009_ee31, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_ee34, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_ee37, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_ee3a, 6); imul(edx, eax, 0xc5);                   /* imul edx, eax, 0xc5 */
            ii(0x1009_ee40, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x1009_ee45, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_ee47, 5); calld(0x1008_a0c8, -0x1_4d84);          /* call 0x1008a0c8 */
            ii(0x1009_ee4c, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_ee4f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_ee52, 5); cmp(memw_a32[ds, eax + 0x8], 0x44);     /* cmp word [eax+0x8], 0x44 */
            ii(0x1009_ee57, 2); if(jzd(0x1009_ee63, 0xa)) goto l_0x1009_ee63; /* jz 0x1009ee63 */
            ii(0x1009_ee59, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_ee5c, 5); cmp(memw_a32[ds, eax + 0x8], 0x47);     /* cmp word [eax+0x8], 0x47 */
            ii(0x1009_ee61, 2); if(jnzd(0x1009_ee9d, 0x3a)) goto l_0x1009_ee9d; /* jnz 0x1009ee9d */
        l_0x1009_ee63:
            ii(0x1009_ee63, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_ee66, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1009_ee68, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_ee6b, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x1009_ee70, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_ee73, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1009_ee76, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_ee79, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1009_ee7c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_ee7e, 6); mov(edx, memd_a32[ds, 0x101c_9454]);    /* mov edx, [0x101c9454] */
            ii(0x1009_ee84, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_ee86, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1009_ee88, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_ee8d, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1009_ee90, 2); if(jzd(0x1009_ee9b, 0x9)) goto l_0x1009_ee9b; /* jz 0x1009ee9b */
            ii(0x1009_ee92, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1009_ee96, 5); jmpd(0x1009_ef09, 0x6e); goto l_0x1009_ef09; /* jmp 0x1009ef09 */
        l_0x1009_ee9b:
            ii(0x1009_ee9b, 2); jmpd(0x1009_eed2, 0x35); goto l_0x1009_eed2; /* jmp 0x1009eed2 */
        l_0x1009_ee9d:
            ii(0x1009_ee9d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_eea0, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1009_eea2, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_eea5, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x1009_eeaa, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_eead, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1009_eeb0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_eeb3, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1009_eeb6, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_eeb8, 6); mov(edx, memd_a32[ds, 0x101c_9454]);    /* mov edx, [0x101c9454] */
            ii(0x1009_eebe, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_eec0, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1009_eec2, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_eec7, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1009_eeca, 2); if(jzd(0x1009_eed2, 0x6)) goto l_0x1009_eed2; /* jz 0x1009eed2 */
            ii(0x1009_eecc, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1009_eed0, 2); jmpd(0x1009_ef09, 0x37); goto l_0x1009_ef09; /* jmp 0x1009ef09 */
        l_0x1009_eed2:
            ii(0x1009_eed2, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1009_eed6, 2); if(jzd(0x1009_eef7, 0x1f)) goto l_0x1009_eef7; /* jz 0x1009eef7 */
            ii(0x1009_eed8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_eedb, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1009_eede, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_eee1, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x1009_eee4, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_eee6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_eee9, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_eeeb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_eeee, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1009_eef0, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_eef2, 3); test(memb_a32[ds, eax], 0x1);           /* test byte [eax], 0x1 */
            ii(0x1009_eef5, 2); if(jnzd(0x1009_eef9, 0x2)) goto l_0x1009_eef9; /* jnz 0x1009eef9 */
        l_0x1009_eef7:
            ii(0x1009_eef7, 2); jmpd(0x1009_eeff, 0x6); goto l_0x1009_eeff; /* jmp 0x1009eeff */
        l_0x1009_eef9:
            ii(0x1009_eef9, 4); mov(memb_a32[ss, ebp - 0x18], 0x1);     /* mov byte [ebp-0x18], 0x1 */
            ii(0x1009_eefd, 2); jmpd(0x1009_ef03, 0x4); goto l_0x1009_ef03; /* jmp 0x1009ef03 */
        l_0x1009_eeff:
            ii(0x1009_eeff, 4); mov(memb_a32[ss, ebp - 0x18], 0);       /* mov byte [ebp-0x18], 0x0 */
        l_0x1009_ef03:
            ii(0x1009_ef03, 3); mov(al, memb_a32[ss, ebp - 0x18]);      /* mov al, [ebp-0x18] */
            ii(0x1009_ef06, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
        l_0x1009_ef09:
            ii(0x1009_ef09, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1009_ef0c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_ef0e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_ef0f, 1); popd(edi);                              /* pop edi */
            ii(0x1009_ef10, 1); popd(esi);                              /* pop esi */
            ii(0x1009_ef11, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_ef12, 1); retd(); return;                         /* ret */
        }
    }
}
