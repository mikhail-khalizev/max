using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_800c-388f5882")]
        public void Method_100e_800c()
        {
            ii(0x100e_800c, 5); push(0x38);                             /* push 0x38 */
            ii(0x100e_8011, 5); call(Definitions.sys_check_available_stack_size, 0x7_dd3c); /* call 0x10165d52 */
            ii(0x100e_8016, 1); push(ebx);                              /* push ebx */
            ii(0x100e_8017, 1); push(ecx);                              /* push ecx */
            ii(0x100e_8018, 1); push(edx);                              /* push edx */
            ii(0x100e_8019, 1); push(esi);                              /* push esi */
            ii(0x100e_801a, 1); push(edi);                              /* push edi */
            ii(0x100e_801b, 1); push(ebp);                              /* push ebp */
            ii(0x100e_801c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_801e, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100e_8024, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_8027, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_802c, 5); call(Definitions.my_3_get_count, -0x5_cbb1); /* call 0x1008b480 */
            ii(0x100e_8031, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
        l_0x100e_8034:
            ii(0x100e_8034, 3); dec(memd[ss, ebp - 12]);                /* dec dword [ebp-0xc] */
            ii(0x100e_8037, 5); cmp(memw[ss, ebp - 12], -1 /* 0xff */); /* cmp word [ebp-0xc], 0xffff */
            ii(0x100e_803c, 2); if(jz(0x100e_808e, 0x50)) goto l_0x100e_808e; /* jz 0x100e808e */
            ii(0x100e_803e, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x100e_8042, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_8047, 5); call(0x100e_84b8, 0x46c);               /* call 0x100e84b8 */
            ii(0x100e_804c, 3); lea(edi, memd[ss, ebp - 28]);           /* lea edi, [ebp-0x1c] */
            ii(0x100e_804f, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x100e_8051, 1); movsd();                                /* movsd */
            ii(0x100e_8052, 1); movsd();                                /* movsd */
            ii(0x100e_8053, 1); movsd();                                /* movsd */
            ii(0x100e_8054, 1); movsd();                                /* movsd */
            ii(0x100e_8055, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_8058, 3); mov(eax, memd[ds, eax + 8]);            /* mov eax, [eax+0x8] */
            ii(0x100e_805b, 3); cmp(eax, memd[ss, ebp - 28]);           /* cmp eax, [ebp-0x1c] */
            ii(0x100e_805e, 2); if(jle(0x100e_806a, 0xa)) goto l_0x100e_806a; /* jle 0x100e806a */
            ii(0x100e_8060, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_8063, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100e_8065, 3); cmp(eax, memd[ss, ebp - 20]);           /* cmp eax, [ebp-0x14] */
            ii(0x100e_8068, 2); if(jl(0x100e_806c, 2)) goto l_0x100e_806c; /* jl 0x100e806c */
        l_0x100e_806a:
            ii(0x100e_806a, 2); jmp(0x100e_8077, 0xb); goto l_0x100e_8077; /* jmp 0x100e8077 */
        l_0x100e_806c:
            ii(0x100e_806c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_806f, 3); mov(eax, memd[ds, eax + 12]);           /* mov eax, [eax+0xc] */
            ii(0x100e_8072, 3); cmp(eax, memd[ss, ebp - 24]);           /* cmp eax, [ebp-0x18] */
            ii(0x100e_8075, 2); if(jg(0x100e_8079, 2)) goto l_0x100e_8079; /* jg 0x100e8079 */
        l_0x100e_8077:
            ii(0x100e_8077, 2); jmp(0x100e_8084, 0xb); goto l_0x100e_8084; /* jmp 0x100e8084 */
        l_0x100e_8079:
            ii(0x100e_8079, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_807c, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x100e_807f, 3); cmp(eax, memd[ss, ebp - 16]);           /* cmp eax, [ebp-0x10] */
            ii(0x100e_8082, 2); if(jl(0x100e_8086, 2)) goto l_0x100e_8086; /* jl 0x100e8086 */
        l_0x100e_8084:
            ii(0x100e_8084, 2); jmp(0x100e_808c, 6); goto l_0x100e_808c; /* jmp 0x100e808c */
        l_0x100e_8086:
            ii(0x100e_8086, 4); mov(memb[ss, ebp - 8], 1);              /* mov byte [ebp-0x8], 0x1 */
            ii(0x100e_808a, 2); jmp(0x100e_8092, 6); goto l_0x100e_8092; /* jmp 0x100e8092 */
        l_0x100e_808c:
            ii(0x100e_808c, 2); jmp(0x100e_8034, -0x5a); goto l_0x100e_8034; /* jmp 0x100e8034 */
        l_0x100e_808e:
            ii(0x100e_808e, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
        l_0x100e_8092:
            ii(0x100e_8092, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x100e_8095, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_8097, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_8098, 1); pop(edi);                               /* pop edi */
            ii(0x100e_8099, 1); pop(esi);                               /* pop esi */
            ii(0x100e_809a, 1); pop(edx);                               /* pop edx */
            ii(0x100e_809b, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_809c, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_809d, 1); ret();                                  /* ret */
        }
    }
}
