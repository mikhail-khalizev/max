using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b9384a66-f902-4940-9e12-379eea9214ad")]
        public void Method_1013_d08a()
        {
            ii(0x1013_d08a, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1013_d08f, 5); calld(Definitions.sys_check_available_stack_size, 0x28cbe); /* call 0x10165d52 */
            ii(0x1013_d094, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_d095, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_d096, 1); pushd(edx);                             /* push edx */
            ii(0x1013_d097, 1); pushd(esi);                             /* push esi */
            ii(0x1013_d098, 1); pushd(edi);                             /* push edi */
            ii(0x1013_d099, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_d09a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_d09c, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_d0a2, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_d0a5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_d0a8, 5); calld(0x1013_d111, 0x64);               /* call 0x1013d111 */
            ii(0x1013_d0ad, 7); mov(memd_a32[ss, ebp - 0x8], 0x14);     /* mov dword [ebp-0x8], 0x14 */
        l_0x1013_d0b4:
            ii(0x1013_d0b4, 3); dec(memd_a32[ss, ebp - 0x8]);           /* dec dword [ebp-0x8] */
            ii(0x1013_d0b7, 5); cmp(memw_a32[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xffff */
            ii(0x1013_d0bc, 2); if(jzd(0x1013_d0ee, 0x30)) goto l_0x1013_d0ee; /* jz 0x1013d0ee */
            ii(0x1013_d0be, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_d0c2, 6); imul(eax, eax, 0x91);                   /* imul eax, eax, 0x91 */
            ii(0x1013_d0c8, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1013_d0cb, 6); add(edx, 0x251);                        /* add edx, 0x251 */
            ii(0x1013_d0d1, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_d0d3, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1013_d0d6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_d0d9, 6); cmp(memd_a32[ds, eax], 0xffff);         /* cmp dword [eax], 0xffff */
            ii(0x1013_d0df, 2); if(jzd(0x1013_d0ec, 0xb)) goto l_0x1013_d0ec; /* jz 0x1013d0ec */
            ii(0x1013_d0e1, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1013_d0e4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_d0e7, 5); calld(0x1013_ce3f, -0x2ad);             /* call 0x1013ce3f */
        l_0x1013_d0ec:
            ii(0x1013_d0ec, 2); jmpd(0x1013_d0b4, -0x3a); goto l_0x1013_d0b4; /* jmp 0x1013d0b4 */
        l_0x1013_d0ee:
            ii(0x1013_d0ee, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_d0f1, 4); mov(memb_a32[ds, eax + 0x20], 0);       /* mov byte [eax+0x20], 0x0 */
            ii(0x1013_d0f5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_d0f8, 7); mov(memd_a32[ds, eax + 0x4], 0);        /* mov dword [eax+0x4], 0x0 */
            ii(0x1013_d0ff, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_d102, 6); mov(memw_a32[ds, eax + 0x10], 0xffff);  /* mov word [eax+0x10], 0xffff */
            ii(0x1013_d108, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_d10a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_d10b, 1); popd(edi);                              /* pop edi */
            ii(0x1013_d10c, 1); popd(esi);                              /* pop esi */
            ii(0x1013_d10d, 1); popd(edx);                              /* pop edx */
            ii(0x1013_d10e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_d10f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_d110, 1); retd(); return;                         /* ret */
        }
    }
}
