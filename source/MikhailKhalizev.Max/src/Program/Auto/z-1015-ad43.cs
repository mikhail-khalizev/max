using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_ad43-f8db9b4a")]
        public void Method_1015_ad43()
        {
            ii(0x1015_ad43, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1015_ad48, 5); calld(Definitions.sys_check_available_stack_size, 0xb005); /* call 0x10165d52 */
            ii(0x1015_ad4d, 1); pushd(esi);                             /* push esi */
            ii(0x1015_ad4e, 1); pushd(edi);                             /* push edi */
            ii(0x1015_ad4f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_ad50, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_ad52, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1015_ad58, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1015_ad5b, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1015_ad5e, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1015_ad61, 3); mov(memb_a32[ss, ebp - 0x4], cl);       /* mov [ebp-0x4], cl */
            ii(0x1015_ad64, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x1015_ad67, 1); dec(eax);                               /* dec eax */
            ii(0x1015_ad68, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1015_ad6b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_ad6e, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1015_ad71, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_ad74, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1015_ad77, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
        l_0x1015_ad7e:
            ii(0x1015_ad7e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_ad81, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1015_ad83, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_ad88, 5); cmp(eax, 0xff);                         /* cmp eax, 0xff */
            ii(0x1015_ad8d, 6); if(jzd(0x1015_aeb2, 0x11f)) goto l_0x1015_aeb2; /* jz 0x1015aeb2 */
            ii(0x1015_ad93, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_ad96, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
            ii(0x1015_ad99, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1015_ad9b, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_ad9d, 3); add(memd_a32[ss, ebp - 0x20], eax);     /* add [ebp-0x20], eax */
            ii(0x1015_ada0, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1015_ada3, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
            ii(0x1015_ada6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_ada8, 2); mov(al, memb_a32[ds, edx]);             /* mov al, [edx] */
            ii(0x1015_adaa, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1015_adad, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1015_adb1, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1015_adb5, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1015_adb7, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1015_adbb, 2); and(eax, edx);                          /* and eax, edx */
            ii(0x1015_adbd, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x1015_adc1, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1015_adc3, 4); movsx(ebx, memw_a32[ss, ebp + 0x10]);   /* movsx ebx, word [ebp+0x10] */
            ii(0x1015_adc7, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_adc9, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_adcc, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1015_adce, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_add0, 2); if(jnzd(0x1015_adea, 0x18)) goto l_0x1015_adea; /* jnz 0x1015adea */
            ii(0x1015_add2, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1015_add5, 3); add(memd_a32[ss, ebp - 0x20], eax);     /* add [ebp-0x20], eax */
            ii(0x1015_add8, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1015_addc, 2); if(jnzd(0x1015_ade5, 0x7)) goto l_0x1015_ade5; /* jnz 0x1015ade5 */
            ii(0x1015_adde, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x1015_ade2, 3); add(memd_a32[ss, ebp - 0x10], eax);     /* add [ebp-0x10], eax */
        l_0x1015_ade5:
            ii(0x1015_ade5, 5); jmpd(0x1015_aead, 0xc3); goto l_0x1015_aead; /* jmp 0x1015aead */
        l_0x1015_adea:
            ii(0x1015_adea, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1015_adee, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1015_adf2, 2); and(eax, edx);                          /* and eax, edx */
            ii(0x1015_adf4, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1015_adf8, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1015_adfa, 4); movsx(ebx, memw_a32[ss, ebp + 0x10]);   /* movsx ebx, word [ebp+0x10] */
            ii(0x1015_adfe, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_ae00, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_ae03, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1015_ae05, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1015_ae07, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_ae0a, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
            ii(0x1015_ae0d, 2); mov(memb_a32[ds, eax], dl);             /* mov [eax], dl */
            ii(0x1015_ae0f, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1015_ae12, 3); add(memd_a32[ss, ebp - 0x1c], eax);     /* add [ebp-0x1c], eax */
            ii(0x1015_ae15, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1015_ae19, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1015_ae1d, 2); and(eax, edx);                          /* and eax, edx */
            ii(0x1015_ae1f, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x1015_ae23, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1015_ae25, 4); movsx(ebx, memw_a32[ss, ebp + 0x10]);   /* movsx ebx, word [ebp+0x10] */
            ii(0x1015_ae29, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_ae2b, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_ae2e, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1015_ae30, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1015_ae32, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_ae35, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
            ii(0x1015_ae38, 2); mov(memb_a32[ds, eax], dl);             /* mov [eax], dl */
            ii(0x1015_ae3a, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1015_ae3e, 2); if(jzd(0x1015_ae48, 0x8)) goto l_0x1015_ae48; /* jz 0x1015ae48 */
            ii(0x1015_ae40, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1015_ae43, 3); add(memd_a32[ss, ebp - 0x1c], eax);     /* add [ebp-0x1c], eax */
            ii(0x1015_ae46, 2); jmpd(0x1015_aea6, 0x5e); goto l_0x1015_aea6; /* jmp 0x1015aea6 */
        l_0x1015_ae48:
            ii(0x1015_ae48, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1015_ae4b, 3); and(eax, memd_a32[ss, ebp - 0x14]);     /* and eax, [ebp-0x14] */
            ii(0x1015_ae4e, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x1015_ae51, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1015_ae53, 3); mov(memd_a32[ss, ebp - 0x20], edx);     /* mov [ebp-0x20], edx */
            ii(0x1015_ae56, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1015_ae5a, 3); add(memd_a32[ss, ebp - 0x10], eax);     /* add [ebp-0x10], eax */
            ii(0x1015_ae5d, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1015_ae60, 3); add(memd_a32[ss, ebp - 0x1c], eax);     /* add [ebp-0x1c], eax */
            ii(0x1015_ae63, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1015_ae66, 1); inc(eax);                               /* inc eax */
            ii(0x1015_ae67, 3); sub(memd_a32[ss, ebp - 0x24], eax);     /* sub [ebp-0x24], eax */
            ii(0x1015_ae6a, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1015_ae6d, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
            ii(0x1015_ae70, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_ae73, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
            ii(0x1015_ae76, 2); mov(dl, memb_a32[ds, edx]);             /* mov dl, [edx] */
            ii(0x1015_ae78, 2); mov(memb_a32[ds, eax], dl);             /* mov [eax], dl */
        l_0x1015_ae7a:
            ii(0x1015_ae7a, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1015_ae7d, 4); cmp(ax, memw_a32[ss, ebp - 0x14]);      /* cmp ax, [ebp-0x14] */
            ii(0x1015_ae81, 2); if(jled(0x1015_ae9f, 0x1c)) goto l_0x1015_ae9f; /* jle 0x1015ae9f */
            ii(0x1015_ae83, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x1015_ae86, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
            ii(0x1015_ae89, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_ae8c, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1015_ae8e, 2); mov(memb_a32[ds, edx], al);             /* mov [edx], al */
            ii(0x1015_ae90, 4); movsx(eax, memw_a32[ss, ebp + 0x10]);   /* movsx eax, word [ebp+0x10] */
            ii(0x1015_ae94, 3); add(memd_a32[ss, ebp - 0x10], eax);     /* add [ebp-0x10], eax */
            ii(0x1015_ae97, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x1015_ae9a, 3); sub(memd_a32[ss, ebp - 0x24], eax);     /* sub [ebp-0x24], eax */
            ii(0x1015_ae9d, 2); jmpd(0x1015_ae7a, -0x25); goto l_0x1015_ae7a; /* jmp 0x1015ae7a */
        l_0x1015_ae9f:
            ii(0x1015_ae9f, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x1015_aea3, 3); add(memd_a32[ss, ebp - 0x10], eax);     /* add [ebp-0x10], eax */
        l_0x1015_aea6:
            ii(0x1015_aea6, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
        l_0x1015_aead:
            ii(0x1015_aead, 5); jmpd(0x1015_ad7e, -0x134); goto l_0x1015_ad7e; /* jmp 0x1015ad7e */
        l_0x1015_aeb2:
            ii(0x1015_aeb2, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_aeb5, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
            ii(0x1015_aeb8, 3); mov(memb_a32[ds, eax], 0xff);           /* mov byte [eax], 0xff */
            ii(0x1015_aebb, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_aebe, 3); sub(eax, memd_a32[ss, ebp - 0x8]);      /* sub eax, [ebp-0x8] */
            ii(0x1015_aec1, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1015_aec4, 4); mov(memw_a32[ds, edx + 0x4], ax);       /* mov [edx+0x4], ax */
            ii(0x1015_aec8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_aecb, 3); mov(eax, memd_a32[ds, eax + 0x2]);      /* mov eax, [eax+0x2] */
            ii(0x1015_aece, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_aed1, 5); calld(Definitions.sys_new_arr, 0xb13a); /* call 0x10166010 */
            ii(0x1015_aed6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_aed8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_aedb, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1015_aedd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_aee0, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1015_aee3, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_aee6, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1015_aee9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_aeec, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1015_aeee, 5); calld(Definitions.sys_memcpy, 0xaf58);  /* call 0x10165e4b */
            ii(0x1015_aef3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_aef5, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_aef6, 1); popd(edi);                              /* pop edi */
            ii(0x1015_aef7, 1); popd(esi);                              /* pop esi */
            ii(0x1015_aef8, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
