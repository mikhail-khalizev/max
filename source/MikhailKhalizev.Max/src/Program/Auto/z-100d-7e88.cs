using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_7e88-13ecaa8d")]
        public void Method_100d_7e88()
        {
            ii(0x100d_7e88, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x100d_7e8d, 5); calld(Definitions.sys_check_available_stack_size, 0x8_dec0); /* call 0x10165d52 */
            ii(0x100d_7e92, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_7e93, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_7e94, 1); pushd(esi);                             /* push esi */
            ii(0x100d_7e95, 1); pushd(edi);                             /* push edi */
            ii(0x100d_7e96, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_7e97, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_7e99, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x100d_7e9f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_7ea2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_7ea5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7ea8, 5); calld(0x100d_811c, 0x26f);              /* call 0x100d811c */
            ii(0x100d_7ead, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_7eb0, 5); calld(0x100d_4e8c, -0x3029);            /* call 0x100d4e8c */
            ii(0x100d_7eb5, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100d_7eb8, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100d_7ebb, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100d_7ebd, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x100d_7ec0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7ec3, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100d_7ec5, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100d_7ec8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_7ecb, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x100d_7ece, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_7ed1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7ed4, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100d_7ed7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_7eda, 5); calld(Definitions.my_min, -0x4_e75b);   /* call 0x10089784 */
            ii(0x100d_7edf, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100d_7ee2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_7ee5, 3); mov(edx, memd_a32[ds, eax + 0x8]);      /* mov edx, [eax+0x8] */
            ii(0x100d_7ee8, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_7eeb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7eee, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100d_7ef1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_7ef4, 5); calld(Definitions.my_min, -0x4_e775);   /* call 0x10089784 */
            ii(0x100d_7ef9, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100d_7efc, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100d_7eff, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x100d_7f02:
            ii(0x100d_7f02, 3); dec(memd_a32[ss, ebp - 0x10]);          /* dec dword [ebp-0x10] */
            ii(0x100d_7f05, 5); cmp(memw_a32[ss, ebp - 0x10], -0x1 /* 0xff */); /* cmp word [ebp-0x10], 0xffff */
            ii(0x100d_7f0a, 2); if(jzd(0x100d_7f64, 0x58)) goto l_0x100d_7f64; /* jz 0x100d7f64 */
            ii(0x100d_7f0c, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100d_7f0f, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
        l_0x100d_7f12:
            ii(0x100d_7f12, 3); dec(memd_a32[ss, ebp - 0x14]);          /* dec dword [ebp-0x14] */
            ii(0x100d_7f15, 5); cmp(memw_a32[ss, ebp - 0x14], -0x1 /* 0xff */); /* cmp word [ebp-0x14], 0xffff */
            ii(0x100d_7f1a, 2); if(jzd(0x100d_7f3e, 0x22)) goto l_0x100d_7f3e; /* jz 0x100d7f3e */
            ii(0x100d_7f1c, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100d_7f1f, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100d_7f21, 3); cmp(al, memb_a32[ss, ebp - 0xc]);       /* cmp al, [ebp-0xc] */
            ii(0x100d_7f24, 2); if(jzd(0x100d_7f30, 0xa)) goto l_0x100d_7f30; /* jz 0x100d7f30 */
            ii(0x100d_7f26, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100d_7f29, 2); mov(dl, memb_a32[ds, eax]);             /* mov dl, [eax] */
            ii(0x100d_7f2b, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100d_7f2e, 2); mov(memb_a32[ds, eax], dl);             /* mov [eax], dl */
        l_0x100d_7f30:
            ii(0x100d_7f30, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100d_7f33, 3); inc(memd_a32[ss, ebp - 0x24]);          /* inc dword [ebp-0x24] */
            ii(0x100d_7f36, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100d_7f39, 3); inc(memd_a32[ss, ebp - 0x20]);          /* inc dword [ebp-0x20] */
            ii(0x100d_7f3c, 2); jmpd(0x100d_7f12, -0x2c); goto l_0x100d_7f12; /* jmp 0x100d7f12 */
        l_0x100d_7f3e:
            ii(0x100d_7f3e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_7f41, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x100d_7f44, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_7f47, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100d_7f4b, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100d_7f4d, 3); add(memd_a32[ss, ebp - 0x24], edx);     /* add [ebp-0x24], edx */
            ii(0x100d_7f50, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7f53, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x100d_7f56, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_7f59, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100d_7f5d, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100d_7f5f, 3); add(memd_a32[ss, ebp - 0x20], edx);     /* add [ebp-0x20], edx */
            ii(0x100d_7f62, 2); jmpd(0x100d_7f02, -0x62); goto l_0x100d_7f02; /* jmp 0x100d7f02 */
        l_0x100d_7f64:
            ii(0x100d_7f64, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_7f66, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_7f67, 1); popd(edi);                              /* pop edi */
            ii(0x100d_7f68, 1); popd(esi);                              /* pop esi */
            ii(0x100d_7f69, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_7f6a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_7f6b, 1); retd(); return;                         /* ret */
        }
    }
}
