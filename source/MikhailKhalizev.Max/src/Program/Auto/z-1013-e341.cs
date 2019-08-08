using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("be0d36be-04d8-4b04-ac03-9d6d3304e398")]
        public void Method_1013_e341()
        {
            ii(0x1013_e341, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1013_e346, 5); calld(Definitions.sys_check_available_stack_size, 0x2_7a07); /* call 0x10165d52 */
            ii(0x1013_e34b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_e34c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_e34d, 1); pushd(edx);                             /* push edx */
            ii(0x1013_e34e, 1); pushd(esi);                             /* push esi */
            ii(0x1013_e34f, 1); pushd(edi);                             /* push edi */
            ii(0x1013_e350, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_e351, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_e353, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_e359, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_e35c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_e35f, 7); cmp(memb_a32[ds, eax + 0xdc9], 0);      /* cmp byte [eax+0xdc9], 0x0 */
            ii(0x1013_e366, 6); if(jzd(0x1013_e46d, 0x101)) goto l_0x1013_e46d; /* jz 0x1013e46d */
            ii(0x1013_e36c, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1013_e373, 2); jmpd(0x1013_e37b, 0x6); goto l_0x1013_e37b; /* jmp 0x1013e37b */
        l_0x1013_e375:
            ii(0x1013_e375, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_e378, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x1013_e37b:
            ii(0x1013_e37b, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_e37f, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x1013_e382, 2); if(jzd(0x1013_e398, 0x14)) goto l_0x1013_e398; /* jz 0x1013e398 */
            ii(0x1013_e384, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_e388, 6); mov(al, memb_a32[ds, eax + 0x101c_8084]); /* mov al, [eax+0x101c8084] */
            ii(0x1013_e38e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_e393, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1013_e396, 2); if(jnzd(0x1013_e375, -0x23)) goto l_0x1013_e375; /* jnz 0x1013e375 */
        l_0x1013_e398:
            ii(0x1013_e398, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_e39c, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x1013_e39f, 2); if(jnzd(0x1013_e3c6, 0x25)) goto l_0x1013_e3c6; /* jnz 0x1013e3c6 */
            ii(0x1013_e3a1, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1013_e3a8, 2); jmpd(0x1013_e3b0, 0x6); goto l_0x1013_e3b0; /* jmp 0x1013e3b0 */
        l_0x1013_e3aa:
            ii(0x1013_e3aa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_e3ad, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x1013_e3b0:
            ii(0x1013_e3b0, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_e3b4, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x1013_e3b7, 2); if(jzd(0x1013_e3c6, 0xd)) goto l_0x1013_e3c6; /* jz 0x1013e3c6 */
            ii(0x1013_e3b9, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_e3bd, 7); mov(memb_a32[ds, eax + 0x101c_8084], 0x1); /* mov byte [eax+0x101c8084], 0x1 */
            ii(0x1013_e3c4, 2); jmpd(0x1013_e3aa, -0x1c); goto l_0x1013_e3aa; /* jmp 0x1013e3aa */
        l_0x1013_e3c6:
            ii(0x1013_e3c6, 5); calld(/* sys */ 0x1016_5e9b, 0x2_7ad0); /* call 0x10165e9b */
            ii(0x1013_e3cb, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x1013_e3ce, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x1013_e3d1, 5); add(eax, 0x6a5);                        /* add eax, 0x6a5 */
            ii(0x1013_e3d6, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_e3d9, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_e3dd, 6); mov(al, memb_a32[ds, eax + 0x101c_79df]); /* mov al, [eax+0x101c79df] */
            ii(0x1013_e3e3, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_e3e8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_e3ea, 2); if(jzd(0x1013_e3c6, -0x26)) goto l_0x1013_e3c6; /* jz 0x1013e3c6 */
            ii(0x1013_e3ec, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_e3f0, 7); mov(memb_a32[ds, eax + 0x101c_79df], 0); /* mov byte [eax+0x101c79df], 0x0 */
            ii(0x1013_e3f7, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1013_e3fb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_e3fe, 5); calld(0x1013_e1ae, -0x255);             /* call 0x1013e1ae */
            ii(0x1013_e403, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_e405, 2); if(jnzd(0x1013_e46b, 0x64)) goto l_0x1013_e46b; /* jnz 0x1013e46b */
            ii(0x1013_e407, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1013_e40e, 2); jmpd(0x1013_e416, 0x6); goto l_0x1013_e416; /* jmp 0x1013e416 */
        l_0x1013_e410:
            ii(0x1013_e410, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_e413, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x1013_e416:
            ii(0x1013_e416, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_e41a, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x1013_e41d, 2); if(jzd(0x1013_e433, 0x14)) goto l_0x1013_e433; /* jz 0x1013e433 */
            ii(0x1013_e41f, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_e423, 6); mov(al, memb_a32[ds, eax + 0x101c_8084]); /* mov al, [eax+0x101c8084] */
            ii(0x1013_e429, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_e42e, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1013_e431, 2); if(jnzd(0x1013_e410, -0x23)) goto l_0x1013_e410; /* jnz 0x1013e410 */
        l_0x1013_e433:
            ii(0x1013_e433, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_e437, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x1013_e43a, 2); if(jnzd(0x1013_e466, 0x2a)) goto l_0x1013_e466; /* jnz 0x1013e466 */
            ii(0x1013_e43c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_e43e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_e441, 6); mov(edx, memd_a32[ds, eax + 0xdc5]);    /* mov edx, [eax+0xdc5] */
            ii(0x1013_e447, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_e44a, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x1013_e44d, 5); calld(Definitions.my_fseek, -0x4_effd); /* call 0x100ef455 */
            ii(0x1013_e452, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_e455, 6); mov(edx, memd_a32[ds, eax + 0xdca]);    /* mov edx, [eax+0xdca] */
            ii(0x1013_e45b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_e45e, 6); mov(memd_a32[ds, eax + 0xdce], edx);    /* mov [eax+0xdce], edx */
            ii(0x1013_e464, 2); jmpd(0x1013_e46b, 0x5); goto l_0x1013_e46b; /* jmp 0x1013e46b */
        l_0x1013_e466:
            ii(0x1013_e466, 5); jmpd(0x1013_e3c6, -0xa5); goto l_0x1013_e3c6; /* jmp 0x1013e3c6 */
        l_0x1013_e46b:
            ii(0x1013_e46b, 2); jmpd(0x1013_e495, 0x28); goto l_0x1013_e495; /* jmp 0x1013e495 */
        l_0x1013_e46d:
            ii(0x1013_e46d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_e46f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_e472, 6); mov(edx, memd_a32[ds, eax + 0xdc5]);    /* mov edx, [eax+0xdc5] */
            ii(0x1013_e478, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_e47b, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x1013_e47e, 5); calld(Definitions.my_fseek, -0x4_f02e); /* call 0x100ef455 */
            ii(0x1013_e483, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_e486, 6); mov(edx, memd_a32[ds, eax + 0xdca]);    /* mov edx, [eax+0xdca] */
            ii(0x1013_e48c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_e48f, 6); mov(memd_a32[ds, eax + 0xdce], edx);    /* mov [eax+0xdce], edx */
        l_0x1013_e495:
            ii(0x1013_e495, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_e497, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_e498, 1); popd(edi);                              /* pop edi */
            ii(0x1013_e499, 1); popd(esi);                              /* pop esi */
            ii(0x1013_e49a, 1); popd(edx);                              /* pop edx */
            ii(0x1013_e49b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_e49c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_e49d, 1); retd(); return;                         /* ret */
        }
    }
}
