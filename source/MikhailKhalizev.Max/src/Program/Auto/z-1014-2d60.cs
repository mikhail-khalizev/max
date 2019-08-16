using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6a704cfe-df8f-49a8-9ae8-3a60aa33a835")]
        public void Method_1014_2d60()
        {
            ii(0x1014_2d60, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1014_2d65, 5); calld(Definitions.sys_check_available_stack_size, 0x2_2fe8); /* call 0x10165d52 */
            ii(0x1014_2d6a, 1); pushd(esi);                             /* push esi */
            ii(0x1014_2d6b, 1); pushd(edi);                             /* push edi */
            ii(0x1014_2d6c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_2d6d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_2d6f, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1014_2d75, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_2d78, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1014_2d7b, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1014_2d7e, 3); mov(memd_a32[ss, ebp - 0x8], ecx);      /* mov [ebp-0x8], ecx */
            ii(0x1014_2d81, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1014_2d85, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_2d87, 6); if(jled(0x1014_2e29, 0x9c)) goto l_0x1014_2e29; /* jle 0x10142e29 */
            ii(0x1014_2d8d, 4); movsx(eax, memw_a32[ss, ebp + 0x10]);   /* movsx eax, word [ebp+0x10] */
            ii(0x1014_2d91, 5); calld(Definitions.my_get_res_data_by_id, -0xedbe); /* call 0x10133fd8 */
            ii(0x1014_2d96, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1014_2d99, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1014_2d9c, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1014_2d9f, 3); mov(edx, memd_a32[ss, ebp - 0x20]);     /* mov edx, [ebp-0x20] */
            ii(0x1014_2da2, 3); add(edx, 0x8);                          /* add edx, 0x8 */
            ii(0x1014_2da5, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1014_2da7, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1014_2dab, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1014_2dad, 3); mov(memd_a32[ss, ebp - 0x24], edx);     /* mov [ebp-0x24], edx */
            ii(0x1014_2db0, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1014_2db3, 3); mov(al, memb_a32[ds, eax + 0x8]);       /* mov al, [eax+0x8] */
            ii(0x1014_2db6, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x1014_2db9, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x1014_2dc0, 2); jmpd(0x1014_2dc8, 0x6); goto l_0x1014_2dc8; /* jmp 0x10142dc8 */
        l_0x1014_2dc2:
            ii(0x1014_2dc2, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1014_2dc5, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
        l_0x1014_2dc8:
            ii(0x1014_2dc8, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1014_2dcb, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x1014_2dcf, 2); if(jged(0x1014_2e29, 0x58)) goto l_0x1014_2e29; /* jge 0x10142e29 */
            ii(0x1014_2dd1, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1014_2dd8, 2); jmpd(0x1014_2de0, 0x6); goto l_0x1014_2de0; /* jmp 0x10142de0 */
        l_0x1014_2dda:
            ii(0x1014_2dda, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1014_2ddd, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
        l_0x1014_2de0:
            ii(0x1014_2de0, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1014_2de3, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x1014_2de7, 2); if(jged(0x1014_2e0b, 0x22)) goto l_0x1014_2e0b; /* jge 0x10142e0b */
            ii(0x1014_2de9, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1014_2dec, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1014_2dee, 3); cmp(al, memb_a32[ss, ebp - 0x14]);      /* cmp al, [ebp-0x14] */
            ii(0x1014_2df1, 2); if(jzd(0x1014_2dfd, 0xa)) goto l_0x1014_2dfd; /* jz 0x10142dfd */
            ii(0x1014_2df3, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1014_2df6, 2); mov(dl, memb_a32[ds, eax]);             /* mov dl, [eax] */
            ii(0x1014_2df8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_2dfb, 2); mov(memb_a32[ds, eax], dl);             /* mov [eax], dl */
        l_0x1014_2dfd:
            ii(0x1014_2dfd, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_2e00, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
            ii(0x1014_2e03, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1014_2e06, 3); inc(memd_a32[ss, ebp - 0x24]);          /* inc dword [ebp-0x24] */
            ii(0x1014_2e09, 2); jmpd(0x1014_2dda, -0x31); goto l_0x1014_2dda; /* jmp 0x10142dda */
        l_0x1014_2e0b:
            ii(0x1014_2e0b, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1014_2e0f, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1014_2e13, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1014_2e15, 3); add(memd_a32[ss, ebp - 0x10], edx);     /* add [ebp-0x10], edx */
            ii(0x1014_2e18, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1014_2e1b, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1014_2e1e, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1014_2e22, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1014_2e24, 3); add(memd_a32[ss, ebp - 0x24], edx);     /* add [ebp-0x24], edx */
            ii(0x1014_2e27, 2); jmpd(0x1014_2dc2, -0x67); goto l_0x1014_2dc2; /* jmp 0x10142dc2 */
        l_0x1014_2e29:
            ii(0x1014_2e29, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_2e2b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_2e2c, 1); popd(edi);                              /* pop edi */
            ii(0x1014_2e2d, 1); popd(esi);                              /* pop esi */
            ii(0x1014_2e2e, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}